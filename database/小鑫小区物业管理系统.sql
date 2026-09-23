/*==============================================================================
  小鑫小区物业管理系统 - 数据库建库脚本
  ----------------------------------------------------------------------------
  数据库名 : XiaoxinCommunityDB
  适用版本 : SQL Server 2005 / 2008 / 2012 / 2014 / 2016 / 2017 / 2019 / 2022
             以及 Azure SQL Database（未使用任何高版本专有语法）
  ----------------------------------------------------------------------------
  使用方法 :
     1. 打开 SSMS（SQL Server Management Studio），连接到你的数据库实例；
     2. 直接打开本文件，按 F5 执行（或点击“执行”按钮）；
     3. 脚本会自动完成：建库 -> 建表 -> 建索引/外键 -> 灌入演示数据。
     4. 若想让脚本删表重建，请把【第 2 步】的 @RebuildDatabase 改为 1 后重新执行
        （注意：重建会清空原有数据）。

  语法兼容性说明（为什么不挑版本也能跑） :
     * 不使用 DROP TABLE IF EXISTS（2016+）        -> 改用 OBJECT_ID() 判断
     * 不使用 DATEDIFF_BIG / IIF / CONCAT / FORMAT -> 改用基础函数
     * 不使用 DATE / TIME / DATETIME2 等新类型     -> 统一用 DATETIME
     * 不使用 SEQUENCE / MERGE / 时态表 / JSON     -> 全部为基础 T-SQL
     * 不使用 OFFSET FETCH / STRING_AGG            -> 分页在程序端完成

  默认登录账号（密码在库中以 MD5 大写十六进制保存） :
     管理员 : admin          密码 admin123
     业主   : 13800000001    密码 123456
     业主   : 13800000002    密码 123456
     （其余业主账号见 tb_SysUser 表，登录名即业主手机号，密码均为 123456）
==============================================================================*/

SET NOCOUNT ON;
GO

/*------------------------------------------------------------------------------
  第 0 步：参数
------------------------------------------------------------------------------*/
DECLARE @DatabaseName NVARCHAR(128);
SET @DatabaseName = N'XiaoxinCommunityDB';

/*------------------------------------------------------------------------------
  第 1 步：创建数据库（已存在则跳过）
------------------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE name = @DatabaseName)
BEGIN
    PRINT N'>> 正在创建数据库 ' + @DatabaseName + N' ...';
    EXEC (N'CREATE DATABASE [' + @DatabaseName + N']');
END
ELSE
BEGIN
    PRINT N'>> 数据库 ' + @DatabaseName + N' 已存在，跳过创建。';
END
GO

USE [XiaoxinCommunityDB];
GO

PRINT N'>> 当前数据库：' + DB_NAME();
GO

/*------------------------------------------------------------------------------
  第 2 步：删除旧表（仅在需要重建时）
  注意：删除顺序必须“先子表、后主表”，否则外键会阻止删除。
------------------------------------------------------------------------------*/
DECLARE @RebuildDatabase INT;
SET @RebuildDatabase = 0;              -- ← 需要删表重建时改成 1（会清空原有数据）

IF @RebuildDatabase = 1
BEGIN
    PRINT N'>> 检测到重建模式，正在删除旧表 ...';

    IF OBJECT_ID(N'dbo.tb_SysLog',    N'U') IS NOT NULL DROP TABLE dbo.tb_SysLog;
    IF OBJECT_ID(N'dbo.tb_Feedback',  N'U') IS NOT NULL DROP TABLE dbo.tb_Feedback;
    IF OBJECT_ID(N'dbo.tb_Fee',       N'U') IS NOT NULL DROP TABLE dbo.tb_Fee;
    IF OBJECT_ID(N'dbo.tb_Repair',    N'U') IS NOT NULL DROP TABLE dbo.tb_Repair;
    IF OBJECT_ID(N'dbo.tb_Notice',    N'U') IS NOT NULL DROP TABLE dbo.tb_Notice;
    IF OBJECT_ID(N'dbo.tb_SysUser',   N'U') IS NOT NULL DROP TABLE dbo.tb_SysUser;
    IF OBJECT_ID(N'dbo.tb_Parking',   N'U') IS NOT NULL DROP TABLE dbo.tb_Parking;
    IF OBJECT_ID(N'dbo.tb_Household', N'U') IS NOT NULL DROP TABLE dbo.tb_Household;
    IF OBJECT_ID(N'dbo.tb_Building',  N'U') IS NOT NULL DROP TABLE dbo.tb_Building;
    IF OBJECT_ID(N'dbo.tb_Community', N'U') IS NOT NULL DROP TABLE dbo.tb_Community;
END
GO

/*------------------------------------------------------------------------------
  第 3 步：建表
------------------------------------------------------------------------------*/

/* 3.1 小区基本信息（整库只有一行，属配置型数据） */
IF OBJECT_ID(N'dbo.tb_Community', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tb_Community
    (
        CommunityId      INT             IDENTITY(1,1) NOT NULL,
        CommunityName    NVARCHAR(100)   NOT NULL,
        Address          NVARCHAR(200)   NULL,
        Area             DECIMAL(18,2)   NULL,   -- 占地面积（平方米）
        BuildingCount    INT             NULL,   -- 楼栋数量
        HouseholdCount   INT             NULL,   -- 住户数量
        GreenRate        NVARCHAR(20)    NULL,   -- 绿化率
        ParkingCount     INT             NULL,   -- 车位数量
        PropertyCompany  NVARCHAR(100)   NULL,   -- 物业公司
        PropertyFeeRate  NVARCHAR(50)    NULL,   -- 物业费标准
        Manager          NVARCHAR(50)    NULL,   -- 物业负责人
        ContactPhone     NVARCHAR(50)    NULL,
        Email            NVARCHAR(100)   NULL,
        Remark           NVARCHAR(500)   NULL,
        UpdateTime       DATETIME        NULL,
        CONSTRAINT PK_tb_Community PRIMARY KEY (CommunityId)
    );
    PRINT N'>> 已创建 tb_Community（小区信息）';
END
GO

/* 3.2 楼栋 */
IF OBJECT_ID(N'dbo.tb_Building', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tb_Building
    (
        BuildingId    INT            IDENTITY(1,1) NOT NULL,
        BuildingName  NVARCHAR(50)   NOT NULL,   -- 例如：1栋
        UnitCount     INT            NULL,       -- 单元数
        FloorCount    INT            NULL,       -- 层数
        Remark        NVARCHAR(200)  NULL,
        CreateTime    DATETIME       NULL,
        CONSTRAINT PK_tb_Building PRIMARY KEY (BuildingId)
    );
    PRINT N'>> 已创建 tb_Building（楼栋）';
END
GO

/* 3.3 住户档案（业主） */
IF OBJECT_ID(N'dbo.tb_Household', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tb_Household
    (
        HouseholdId   INT            IDENTITY(1,1) NOT NULL,
        OwnerName     NVARCHAR(50)   NOT NULL,
        Gender        NVARCHAR(4)    NULL,       -- 男 / 女
        Phone         NVARCHAR(20)   NULL,
        IdCard        NVARCHAR(30)   NULL,
        BuildingId    INT            NULL,
        RoomNo        NVARCHAR(50)   NULL,       -- 门牌号，例如：1栋1单元101
        Area          DECIMAL(18,2)  NULL,       -- 建筑面积
        FamilyCount   INT            NULL,       -- 家庭人数
        MoveInDate    DATETIME       NULL,
        Remark        NVARCHAR(500)  NULL,
        CreateTime    DATETIME       NULL,
        CONSTRAINT PK_tb_Household PRIMARY KEY (HouseholdId)
    );
    PRINT N'>> 已创建 tb_Household（住户档案）';
END
GO

/* 3.4 车位 */
IF OBJECT_ID(N'dbo.tb_Parking', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tb_Parking
    (
        ParkId       INT            IDENTITY(1,1) NOT NULL,
        ParkNo       NVARCHAR(30)   NOT NULL,    -- 车位编号，例如：A-001
        ParkArea     NVARCHAR(50)   NULL,        -- 区域，例如：地下车库 / 地面停车区
        ParkType     NVARCHAR(20)   NULL,        -- 地下 / 地上
        HouseholdId  INT            NULL,        -- 使用住户，NULL 表示未分配
        CarNo        NVARCHAR(20)   NULL,        -- 车牌号
        Status       NVARCHAR(20)   NULL,        -- 空闲 / 已租 / 已售
        RentFee      DECIMAL(18,2)  NULL,        -- 月租金
        Remark       NVARCHAR(200)  NULL,
        CreateTime   DATETIME       NULL,
        CONSTRAINT PK_tb_Parking PRIMARY KEY (ParkId)
    );
    PRINT N'>> 已创建 tb_Parking（车位）';
END
GO

/* 3.5 系统用户（管理员 + 业主登录账号） */
IF OBJECT_ID(N'dbo.tb_SysUser', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tb_SysUser
    (
        UserId       INT            IDENTITY(1,1) NOT NULL,
        LoginName    NVARCHAR(50)   NOT NULL,    -- 管理员为 admin，业主为手机号
        Password     NVARCHAR(50)   NOT NULL,    -- MD5 大写十六进制
        RealName     NVARCHAR(50)   NULL,
        Phone        NVARCHAR(20)   NULL,
        Email        NVARCHAR(100)  NULL,
        Role         NVARCHAR(20)   NOT NULL,    -- 管理员 / 业主
        HouseholdId  INT            NULL,        -- 业主关联的住户档案
        Status       INT            NOT NULL,    -- 1 启用 / 0 停用
        CreateTime   DATETIME       NULL,
        CONSTRAINT PK_tb_SysUser PRIMARY KEY (UserId)
    );
    PRINT N'>> 已创建 tb_SysUser（系统用户）';
END
GO

/* 3.6 公告 */
IF OBJECT_ID(N'dbo.tb_Notice', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tb_Notice
    (
        NoticeId     INT             IDENTITY(1,1) NOT NULL,
        Title        NVARCHAR(200)   NOT NULL,
        Category     NVARCHAR(20)    NULL,       -- 通知 / 停水 / 停电 / 活动
        Content      NVARCHAR(4000)  NULL,
        PublishUser  NVARCHAR(50)    NULL,
        PublishTime  DATETIME        NULL,
        IsTop        INT             NULL,       -- 1 置顶 / 0 普通
        CONSTRAINT PK_tb_Notice PRIMARY KEY (NoticeId)
    );
    PRINT N'>> 已创建 tb_Notice（公告）';
END
GO

/* 3.7 报修工单（对应旧版 tb_Report，字段做了规范化扩展） */
IF OBJECT_ID(N'dbo.tb_Repair', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tb_Repair
    (
        RepairId     INT             IDENTITY(1,1) NOT NULL,
        HouseholdId  INT             NULL,       -- 发起报修的住户
        Content      NVARCHAR(500)   NULL,       -- 报修问题
        ReportDate   DATETIME        NULL,       -- 上报时间
        SolveDate    DATETIME        NULL,       -- 维修时间
        RepairMan    NVARCHAR(50)    NULL,       -- 维修人
        Fee          DECIMAL(18,2)   NULL,       -- 维修费用
        Status       NVARCHAR(20)    NULL,       -- 待处理 / 处理中 / 已完成
        Remark       NVARCHAR(500)   NULL,
        CreateTime   DATETIME        NULL,
        CONSTRAINT PK_tb_Repair PRIMARY KEY (RepairId)
    );
    PRINT N'>> 已创建 tb_Repair（报修工单）';
END
GO

/* 3.8 收费记录 */
IF OBJECT_ID(N'dbo.tb_Fee', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tb_Fee
    (
        FeeId       INT             IDENTITY(1,1) NOT NULL,
        HouseholdId INT             NULL,
        FeeType     NVARCHAR(20)    NULL,        -- 物业费 / 水费 / 电费 / 停车费
        FeeMonth    NVARCHAR(20)    NULL,        -- 费用所属月份，例如：2026-09
        Amount      DECIMAL(18,2)   NULL,
        PayStatus   NVARCHAR(10)    NULL,        -- 未缴 / 已缴
        PayDate     DATETIME        NULL,
        Operator    NVARCHAR(50)    NULL,        -- 经办人
        Remark      NVARCHAR(200)   NULL,
        CreateTime  DATETIME        NULL,
        CONSTRAINT PK_tb_Fee PRIMARY KEY (FeeId)
    );
    PRINT N'>> 已创建 tb_Fee（收费记录）';
END
GO

/* 3.9 投诉与建议 */
IF OBJECT_ID(N'dbo.tb_Feedback', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tb_Feedback
    (
        FeedbackId    INT             IDENTITY(1,1) NOT NULL,
        HouseholdId   INT             NULL,
        FType         NVARCHAR(20)    NULL,      -- 投诉 / 建议
        Title         NVARCHAR(100)   NULL,
        Content       NVARCHAR(1000)  NULL,
        CreateTime    DATETIME        NULL,
        ReplyContent  NVARCHAR(1000)  NULL,
        ReplyUser     NVARCHAR(50)    NULL,
        ReplyTime     DATETIME        NULL,
        Status        NVARCHAR(20)    NULL,      -- 待处理 / 已回复
        CONSTRAINT PK_tb_Feedback PRIMARY KEY (FeedbackId)
    );
    PRINT N'>> 已创建 tb_Feedback（投诉建议）';
END
GO

/* 3.10 系统操作日志 */
IF OBJECT_ID(N'dbo.tb_SysLog', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tb_SysLog
    (
        LogId     INT             IDENTITY(1,1) NOT NULL,
        UserName  NVARCHAR(50)    NULL,
        Action    NVARCHAR(50)    NULL,
        Detail    NVARCHAR(500)   NULL,
        LogTime   DATETIME        NULL,
        CONSTRAINT PK_tb_SysLog PRIMARY KEY (LogId)
    );
    PRINT N'>> 已创建 tb_SysLog（系统日志）';
END
GO

/*------------------------------------------------------------------------------
  第 4 步：索引与外键（用 OBJECT_ID / 系统视图判断，避免重复创建报错）
------------------------------------------------------------------------------*/

/* 4.1 普通索引 —— 只建在常用的查询列上 */
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_tb_Household_Phone'
               AND object_id = OBJECT_ID(N'dbo.tb_Household'))
    CREATE INDEX IX_tb_Household_Phone ON dbo.tb_Household (Phone);
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_tb_Household_RoomNo'
               AND object_id = OBJECT_ID(N'dbo.tb_Household'))
    CREATE INDEX IX_tb_Household_RoomNo ON dbo.tb_Household (RoomNo);
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_tb_Fee_Household'
               AND object_id = OBJECT_ID(N'dbo.tb_Fee'))
    CREATE INDEX IX_tb_Fee_Household ON dbo.tb_Fee (HouseholdId, PayStatus);
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_tb_Repair_Status'
               AND object_id = OBJECT_ID(N'dbo.tb_Repair'))
    CREATE INDEX IX_tb_Repair_Status ON dbo.tb_Repair (Status);

GO

/* 4.2 外键 —— 用 sys.foreign_keys 判断，已存在则跳过 */
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_Household_Building')
    ALTER TABLE dbo.tb_Household
        ADD CONSTRAINT FK_Household_Building FOREIGN KEY (BuildingId)
            REFERENCES dbo.tb_Building (BuildingId);
GO

IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_Parking_Household')
    ALTER TABLE dbo.tb_Parking
        ADD CONSTRAINT FK_Parking_Household FOREIGN KEY (HouseholdId)
            REFERENCES dbo.tb_Household (HouseholdId);
GO

IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_User_Household')
    ALTER TABLE dbo.tb_SysUser
        ADD CONSTRAINT FK_User_Household FOREIGN KEY (HouseholdId)
            REFERENCES dbo.tb_Household (HouseholdId);
GO

IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_Repair_Household')
    ALTER TABLE dbo.tb_Repair
        ADD CONSTRAINT FK_Repair_Household FOREIGN KEY (HouseholdId)
            REFERENCES dbo.tb_Household (HouseholdId);
GO

IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_Fee_Household')
    ALTER TABLE dbo.tb_Fee
        ADD CONSTRAINT FK_Fee_Household FOREIGN KEY (HouseholdId)
            REFERENCES dbo.tb_Household (HouseholdId);
GO

IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_Feedback_Household')
    ALTER TABLE dbo.tb_Feedback
        ADD CONSTRAINT FK_Feedback_Household FOREIGN KEY (HouseholdId)
            REFERENCES dbo.tb_Household (HouseholdId);
GO

/*------------------------------------------------------------------------------
  第 5 步：演示数据
  说明：主键是 IDENTITY，为了让外键能稳定对应，使用 SET IDENTITY_INSERT 显式插入。
        同一会话内 IDENTITY_INSERT 只能对一张表开启，因此逐表开关。
------------------------------------------------------------------------------*/

/* 5.1 小区信息 */
IF NOT EXISTS (SELECT 1 FROM dbo.tb_Community)
BEGIN
    SET IDENTITY_INSERT dbo.tb_Community ON;

    INSERT INTO dbo.tb_Community
        (CommunityId, CommunityName, Address, Area, BuildingCount, HouseholdCount,
         GreenRate, ParkingCount, PropertyCompany, PropertyFeeRate, Manager,
         ContactPhone, Email, Remark, UpdateTime)
    VALUES
        (1, N'小鑫小区', N'幸福路128号', 86000.00, 8, 468,
         N'38%', 300, N'小鑫物业服务有限公司', N'1.80 元/平方米·月', N'张建国',
         N'0755-88886666', N'xiaoxin@xiaoxinwuye.com',
         N'小区共 8 栋住宅楼，配套地下车库与地面停车区，设有中心花园、健身广场和社区服务站。',
         CONVERT(DATETIME, '2026-09-01 09:00:00', 120));

    SET IDENTITY_INSERT dbo.tb_Community OFF;
    PRINT N'>> 已写入 tb_Community 演示数据';
END
GO

/* 5.2 楼栋 */
IF NOT EXISTS (SELECT 1 FROM dbo.tb_Building)
BEGIN
    SET IDENTITY_INSERT dbo.tb_Building ON;

    INSERT INTO dbo.tb_Building (BuildingId, BuildingName, UnitCount, FloorCount, Remark, CreateTime)
    SELECT 1, N'1栋', 2, 18, N'临街，一层为商铺', CONVERT(DATETIME, '2020-01-10', 120)
    UNION ALL SELECT 2, N'2栋', 2, 18, NULL, CONVERT(DATETIME, '2020-01-10', 120)
    UNION ALL SELECT 3, N'3栋', 2, 18, NULL, CONVERT(DATETIME, '2020-01-10', 120)
    UNION ALL SELECT 4, N'4栋', 1, 12, N'小高层', CONVERT(DATETIME, '2020-01-10', 120)
    UNION ALL SELECT 5, N'5栋', 1, 12, N'小高层', CONVERT(DATETIME, '2020-01-10', 120)
    UNION ALL SELECT 6, N'6栋', 3, 26, N'高层', CONVERT(DATETIME, '2020-01-10', 120)
    UNION ALL SELECT 7, N'7栋', 3, 26, N'高层', CONVERT(DATETIME, '2020-01-10', 120)
    UNION ALL SELECT 8, N'8栋', 2, 18, N'靠中心花园', CONVERT(DATETIME, '2020-01-10', 120);

    SET IDENTITY_INSERT dbo.tb_Building OFF;
    PRINT N'>> 已写入 tb_Building 演示数据';
END
GO

/* 5.3 住户档案 */
IF NOT EXISTS (SELECT 1 FROM dbo.tb_Household)
BEGIN
    SET IDENTITY_INSERT dbo.tb_Household ON;

    INSERT INTO dbo.tb_Household
        (HouseholdId, OwnerName, Gender, Phone, IdCard, BuildingId, RoomNo,
         Area, FamilyCount, MoveInDate, Remark, CreateTime)
    SELECT 1, N'张伟', N'男', N'13800000001', N'440301199001011234', 1, N'1栋1单元101', 126.50, 3, CONVERT(DATETIME, '2020-03-15', 120), N'业主委员会成员', CONVERT(DATETIME, '2020-03-15', 120)
    UNION ALL SELECT 2, N'李娜', N'女', N'13800000002', N'440301199202022345', 1, N'1栋1单元102', 98.20, 2, CONVERT(DATETIME, '2020-04-02', 120), NULL, CONVERT(DATETIME, '2020-04-02', 120)
    UNION ALL SELECT 3, N'王强', N'男', N'13800000003', N'440301198805053456', 1, N'1栋1单元201', 126.50, 4, CONVERT(DATETIME, '2020-05-11', 120), NULL, CONVERT(DATETIME, '2020-05-11', 120)
    UNION ALL SELECT 4, N'刘敏', N'女', N'13800000004', N'440301199311114567', 2, N'2栋1单元301', 143.80, 3, CONVERT(DATETIME, '2020-06-20', 120), NULL, CONVERT(DATETIME, '2020-06-20', 120)
    UNION ALL SELECT 5, N'陈晨', N'男', N'13800000005', N'440301199504045678', 2, N'2栋2单元502', 98.20, 2, CONVERT(DATETIME, '2020-07-08', 120), N'租户转业主', CONVERT(DATETIME, '2020-07-08', 120)
    UNION ALL SELECT 6, N'赵磊', N'男', N'13800000006', N'440301198706066789', 3, N'3栋1单元601', 126.50, 5, CONVERT(DATETIME, '2020-08-19', 120), N'家中有老人，需留意电梯', CONVERT(DATETIME, '2020-08-19', 120)
    UNION ALL SELECT 7, N'孙丽', N'女', N'13800000007', N'440301199007077890', 3, N'3栋2单元802', 143.80, 3, CONVERT(DATETIME, '2020-09-01', 120), NULL, CONVERT(DATETIME, '2020-09-01', 120)
    UNION ALL SELECT 8, N'周杰', N'男', N'13800000008', N'440301199108088901', 4, N'4栋1单元1101', 98.20, 2, CONVERT(DATETIME, '2020-10-12', 120), NULL, CONVERT(DATETIME, '2020-10-12', 120)
    UNION ALL SELECT 9, N'吴静', N'女', N'13800000009', N'440301199209099012', 4, N'4栋1单元1102', 126.50, 3, CONVERT(DATETIME, '2020-11-23', 120), NULL, CONVERT(DATETIME, '2020-11-23', 120)
    UNION ALL SELECT 10, N'郑凯', N'男', N'13800000010', N'440301198510101123', 5, N'5栋1单元901', 143.80, 4, CONVERT(DATETIME, '2021-01-15', 120), NULL, CONVERT(DATETIME, '2021-01-15', 120)
    UNION ALL SELECT 11, N'冯雪', N'女', N'13800000011', N'440301199411111234', 6, N'6栋1单元1503', 98.20, 2, CONVERT(DATETIME, '2021-03-06', 120), NULL, CONVERT(DATETIME, '2021-03-06', 120)
    UNION ALL SELECT 12, N'韩磊', N'男', N'13800000012', N'440301198812121345', 6, N'6栋2单元1806', 126.50, 4, CONVERT(DATETIME, '2021-05-18', 120), NULL, CONVERT(DATETIME, '2021-05-18', 120)
    UNION ALL SELECT 13, N'杨帆', N'男', N'13800000013', N'440301199601011456', 7, N'7栋1单元2201', 143.80, 3, CONVERT(DATETIME, '2021-07-29', 120), NULL, CONVERT(DATETIME, '2021-07-29', 120)
    UNION ALL SELECT 14, N'许晴', N'女', N'13800000014', N'440301199702021567', 7, N'7栋3单元2402', 98.20, 1, CONVERT(DATETIME, '2021-09-09', 120), N'长期出差，报修请电话联系', CONVERT(DATETIME, '2021-09-09', 120)
    UNION ALL SELECT 15, N'何军', N'男', N'13800000015', N'440301198403031678', 8, N'8栋1单元1201', 126.50, 4, CONVERT(DATETIME, '2021-11-11', 120), NULL, CONVERT(DATETIME, '2021-11-11', 120)
    UNION ALL SELECT 16, N'邓丽', N'女', N'13800000016', N'440301199304041789', 8, N'8栋2单元1602', 143.80, 3, CONVERT(DATETIME, '2022-02-14', 120), NULL, CONVERT(DATETIME, '2022-02-14', 120);

    SET IDENTITY_INSERT dbo.tb_Household OFF;
    PRINT N'>> 已写入 tb_Household 演示数据（16 户）';
END
GO

/* 5.4 车位 */
IF NOT EXISTS (SELECT 1 FROM dbo.tb_Parking)
BEGIN
    SET IDENTITY_INSERT dbo.tb_Parking ON;

    INSERT INTO dbo.tb_Parking
        (ParkId, ParkNo, ParkArea, ParkType, HouseholdId, CarNo, Status, RentFee, Remark, CreateTime)
    SELECT 1,  N'A-001', N'地下车库', N'地下', 1,    N'粤B12345', N'已售', 300.00, NULL, CONVERT(DATETIME, '2020-03-15', 120)
    UNION ALL SELECT 2,  N'A-002', N'地下车库', N'地下', 2,    N'粤B23456', N'已租', 300.00, NULL, CONVERT(DATETIME, '2020-04-02', 120)
    UNION ALL SELECT 3,  N'A-003', N'地下车库', N'地下', 3,    N'粤B34567', N'已租', 300.00, NULL, CONVERT(DATETIME, '2020-05-11', 120)
    UNION ALL SELECT 4,  N'A-004', N'地下车库', N'地下', NULL, NULL,        N'空闲', 300.00, N'车位照明待检查', CONVERT(DATETIME, '2020-03-15', 120)
    UNION ALL SELECT 5,  N'A-005', N'地下车库', N'地下', 4,    N'粤B45678', N'已售', 300.00, NULL, CONVERT(DATETIME, '2020-06-20', 120)
    UNION ALL SELECT 6,  N'A-006', N'地下车库', N'地下', 5,    N'粤B56789', N'已租', 300.00, NULL, CONVERT(DATETIME, '2020-07-08', 120)
    UNION ALL SELECT 7,  N'A-007', N'地下车库', N'地下', NULL, NULL,        N'空闲', 300.00, NULL, CONVERT(DATETIME, '2020-03-15', 120)
    UNION ALL SELECT 8,  N'A-008', N'地下车库', N'地下', 6,    N'粤B67890', N'已租', 300.00, NULL, CONVERT(DATETIME, '2020-08-19', 120)
    UNION ALL SELECT 9,  N'B-001', N'地面停车区', N'地上', 7,    N'粤B78901', N'已租', 150.00, NULL, CONVERT(DATETIME, '2020-09-01', 120)
    UNION ALL SELECT 10, N'B-002', N'地面停车区', N'地上', 8,    N'粤B89012', N'已租', 150.00, NULL, CONVERT(DATETIME, '2020-10-12', 120)
    UNION ALL SELECT 11, N'B-003', N'地面停车区', N'地上', NULL, NULL,        N'空闲', 150.00, NULL, CONVERT(DATETIME, '2020-03-15', 120)
    UNION ALL SELECT 12, N'B-004', N'地面停车区', N'地上', 9,    N'粤B90123', N'已租', 150.00, NULL, CONVERT(DATETIME, '2020-11-23', 120)
    UNION ALL SELECT 13, N'B-005', N'地面停车区', N'地上', 10,   N'粤B01234', N'已售', 150.00, NULL, CONVERT(DATETIME, '2021-01-15', 120)
    UNION ALL SELECT 14, N'B-006', N'地面停车区', N'地上', NULL, NULL,        N'空闲', 150.00, NULL, CONVERT(DATETIME, '2020-03-15', 120)
    UNION ALL SELECT 15, N'B-007', N'地面停车区', N'地上', 11,   N'粤B13579', N'已租', 150.00, NULL, CONVERT(DATETIME, '2021-03-06', 120)
    UNION ALL SELECT 16, N'B-008', N'地面停车区', N'地上', NULL, NULL,        N'空闲', 150.00, NULL, CONVERT(DATETIME, '2020-03-15', 120);

    SET IDENTITY_INSERT dbo.tb_Parking OFF;
    PRINT N'>> 已写入 tb_Parking 演示数据（16 个车位）';
END
GO

/* 5.5 系统用户
   密码为 MD5 大写十六进制：
       admin123        -> 0192023A7BBD73250516F069DF18B500
       123456          -> E10ADC3949BA59ABBE56E057F20F883E
   如需把某个账号密码重置为 123456，可直接执行：
       UPDATE dbo.tb_SysUser SET Password = N'E10ADC3949BA59ABBE56E057F20F883E' WHERE LoginName = N'账号';
*/
IF NOT EXISTS (SELECT 1 FROM dbo.tb_SysUser)
BEGIN
    SET IDENTITY_INSERT dbo.tb_SysUser ON;

    INSERT INTO dbo.tb_SysUser
        (UserId, LoginName, Password, RealName, Phone, Email, Role, HouseholdId, Status, CreateTime)
    SELECT 1, N'admin', N'0192023A7BBD73250516F069DF18B500', N'系统管理员', N'075588886666', N'admin@xiaoxinwuye.com', N'管理员', NULL, 1, CONVERT(DATETIME, '2020-01-01', 120)
    UNION ALL SELECT 2, N'13800000001', N'E10ADC3949BA59ABBE56E057F20F883E', N'张伟', N'13800000001', N'zhangwei@qq.com',  N'业主', 1,  1, CONVERT(DATETIME, '2020-03-15', 120)
    UNION ALL SELECT 3, N'13800000002', N'E10ADC3949BA59ABBE56E057F20F883E', N'李娜', N'13800000002', N'lina@qq.com',      N'业主', 2,  1, CONVERT(DATETIME, '2020-04-02', 120)
    UNION ALL SELECT 4, N'13800000004', N'E10ADC3949BA59ABBE56E057F20F883E', N'刘敏', N'13800000004', N'liumin@qq.com',    N'业主', 4,  1, CONVERT(DATETIME, '2020-06-20', 120)
    UNION ALL SELECT 5, N'13800000006', N'E10ADC3949BA59ABBE56E057F20F883E', N'赵磊', N'13800000006', N'zhaolei@qq.com',   N'业主', 6,  1, CONVERT(DATETIME, '2020-08-19', 120)
    UNION ALL SELECT 6, N'13800000008', N'E10ADC3949BA59ABBE56E057F20F883E', N'周杰', N'13800000008', N'zhoujie@qq.com',   N'业主', 8,  1, CONVERT(DATETIME, '2020-10-12', 120)
    UNION ALL SELECT 7, N'13800000010', N'E10ADC3949BA59ABBE56E057F20F883E', N'郑凯', N'13800000010', N'zhengkai@qq.com',  N'业主', 10, 1, CONVERT(DATETIME, '2021-01-15', 120)
    UNION ALL SELECT 8, N'13800000012', N'E10ADC3949BA59ABBE56E057F20F883E', N'韩磊', N'13800000012', N'hanlei@qq.com',    N'业主', 12, 1, CONVERT(DATETIME, '2021-05-18', 120)
    UNION ALL SELECT 9, N'13800000015', N'E10ADC3949BA59ABBE56E057F20F883E', N'何军', N'13800000015', N'hejun@qq.com',     N'业主', 15, 1, CONVERT(DATETIME, '2021-11-11', 120);

    SET IDENTITY_INSERT dbo.tb_SysUser OFF;
    PRINT N'>> 已写入 tb_SysUser 演示数据（1 个管理员 + 8 个业主账号）';
END
GO

/* 5.6 公告 */
IF NOT EXISTS (SELECT 1 FROM dbo.tb_Notice)
BEGIN
    SET IDENTITY_INSERT dbo.tb_Notice ON;

    INSERT INTO dbo.tb_Notice (NoticeId, Title, Category, Content, PublishUser, PublishTime, IsTop)
    SELECT 1, N'关于小区地下车库照明改造的通知', N'通知',
           N'为改善地下车库照明条件，物业将于 2026 年 9 月 20 日至 9 月 25 日对地下一层照明灯具进行整体更换。施工时间为每日 8:30-17:30，期间请业主将车辆停至地下一层东侧预留区域，工程给您的出行带来不便，敬请谅解。',
           N'admin', CONVERT(DATETIME, '2026-09-12 09:00:00', 120), 1
    UNION ALL SELECT 2, N'9月1日计划性停水通知', N'停水',
           N'因市政管网检修，本小区将于 2026 年 9 月 1 日 09:00 至 16:00 停水，请各位业主提前储备生活用水。恢复供水初期水质可能出现短暂浑浊，放水数分钟即可正常使用。',
           N'admin', CONVERT(DATETIME, '2026-08-28 15:30:00', 120), 1
    UNION ALL SELECT 3, N'中秋节社区活动安排', N'活动',
           N'中秋节当天 19:00，小区中心花园将举办灯谜会和月饼分享活动，现场设有儿童手工区，欢迎业主带着家人参加。报名请到物业服务中心登记或致电 0755-88886666。',
           N'admin', CONVERT(DATETIME, '2026-09-05 10:20:00', 120), 0
    UNION ALL SELECT 4, N'电梯年度检修计划', N'通知',
           N'8 栋住宅电梯将按楼栋顺序进行年度安全检修，检修期间每栋停梯约 4 小时。具体时间安排已在各单元公告栏张贴，请业主留意并提前安排出行。',
           N'admin', CONVERT(DATETIME, '2026-09-10 14:00:00', 120), 0
    UNION ALL SELECT 5, N'物业费缴纳提醒', N'通知',
           N'2026 年第三季度物业费已开始收取，业主可通过物业服务中心现场缴纳，也可联系管家上门收取。缴费标准为 1.80 元/平方米·月，感谢您的支持与配合。',
           N'admin', CONVERT(DATETIME, '2026-09-15 09:10:00', 120), 0
    UNION ALL SELECT 6, N'关于开展消防演练的通知', N'通知',
           N'为提高业主消防安全意识，物业将于 2026 年 9 月 27 日 15:00 在中心花园组织消防疏散演练，演练过程中会拉响警报并模拟烟雾，请业主不必惊慌，并配合工作人员指引。',
           N'admin', CONVERT(DATETIME, '2026-09-18 11:00:00', 120), 0;

    SET IDENTITY_INSERT dbo.tb_Notice OFF;
    PRINT N'>> 已写入 tb_Notice 演示数据（6 条公告）';
END
GO

/* 5.7 报修工单 */
IF NOT EXISTS (SELECT 1 FROM dbo.tb_Repair)
BEGIN
    SET IDENTITY_INSERT dbo.tb_Repair ON;

    INSERT INTO dbo.tb_Repair
        (RepairId, HouseholdId, Content, ReportDate, SolveDate, RepairMan, Fee, Status, Remark, CreateTime)
    SELECT 1, 1, N'厨房水管接口漏水', CONVERT(DATETIME, '2026-08-20 09:15:00', 120), CONVERT(DATETIME, '2026-08-20 15:40:00', 120), N'赵师傅', 80.00, N'已完成', N'更换角阀一只', CONVERT(DATETIME, '2026-08-20 09:15:00', 120)
    UNION ALL SELECT 2, 2, N'客厅吸顶灯不亮', CONVERT(DATETIME, '2026-08-23 19:30:00', 120), CONVERT(DATETIME, '2026-08-24 10:05:00', 120), N'钱师傅', 45.00, N'已完成', N'更换LED灯芯', CONVERT(DATETIME, '2026-08-23 19:30:00', 120)
    UNION ALL SELECT 3, 3, N'卫生间马桶堵塞', CONVERT(DATETIME, '2026-09-02 08:20:00', 120), NULL, NULL, NULL, N'待处理', N'业主反映早上返水', CONVERT(DATETIME, '2026-09-02 08:20:00', 120)
    UNION ALL SELECT 4, 4, N'阳台推拉窗关不严', CONVERT(DATETIME, '2026-09-04 16:45:00', 120), NULL, N'孙师傅', NULL, N'处理中', N'需要定制窗轮', CONVERT(DATETIME, '2026-09-04 16:45:00', 120)
    UNION ALL SELECT 5, 5, N'入户门锁损坏', CONVERT(DATETIME, '2026-09-06 21:10:00', 120), CONVERT(DATETIME, '2026-09-07 09:30:00', 120), N'李师傅', 160.00, N'已完成', N'更换锁芯', CONVERT(DATETIME, '2026-09-06 21:10:00', 120)
    UNION ALL SELECT 6, 6, N'空调不制冷', CONVERT(DATETIME, '2026-09-09 13:00:00', 120), NULL, NULL, NULL, N'待处理', N'业主希望周末上门', CONVERT(DATETIME, '2026-09-09 13:00:00', 120)
    UNION ALL SELECT 7, 8, N'楼道感应灯损坏', CONVERT(DATETIME, '2026-09-11 07:40:00', 120), NULL, N'赵师傅', NULL, N'处理中', N'已下单采购感应模块', CONVERT(DATETIME, '2026-09-11 07:40:00', 120)
    UNION ALL SELECT 8, 9, N'厨房下水道返味', CONVERT(DATETIME, '2026-09-13 18:25:00', 120), CONVERT(DATETIME, '2026-09-14 11:00:00', 120), N'钱师傅', 60.00, N'已完成', N'疏通并更换防臭地漏', CONVERT(DATETIME, '2026-09-13 18:25:00', 120)
    UNION ALL SELECT 9, 10, N'卧室插座无电', CONVERT(DATETIME, '2026-09-15 20:05:00', 120), NULL, NULL, NULL, N'待处理', NULL, CONVERT(DATETIME, '2026-09-15 20:05:00', 120)
    UNION ALL SELECT 10, 12, N'电梯按钮失灵', CONVERT(DATETIME, '2026-09-16 08:50:00', 120), CONVERT(DATETIME, '2026-09-16 14:20:00', 120), N'李师傅', 0.00, N'已完成', N'公共设施，费用由物业承担', CONVERT(DATETIME, '2026-09-16 08:50:00', 120)
    UNION ALL SELECT 11, 13, N'卫生间漏水到楼下', CONVERT(DATETIME, '2026-09-17 10:30:00', 120), NULL, N'孙师傅', NULL, N'处理中', N'已上门查看，需做防水处理', CONVERT(DATETIME, '2026-09-17 10:30:00', 120)
    UNION ALL SELECT 12, 15, N'阳台晾衣架脱落', CONVERT(DATETIME, '2026-09-19 17:15:00', 120), NULL, NULL, NULL, N'待处理', N'请安排师傅带膨胀螺栓', CONVERT(DATETIME, '2026-09-19 17:15:00', 120);

    SET IDENTITY_INSERT dbo.tb_Repair OFF;
    PRINT N'>> 已写入 tb_Repair 演示数据（12 条工单）';
END
GO

/* 5.8 收费记录 */
IF NOT EXISTS (SELECT 1 FROM dbo.tb_Fee)
BEGIN
    SET IDENTITY_INSERT dbo.tb_Fee ON;

    INSERT INTO dbo.tb_Fee
        (FeeId, HouseholdId, FeeType, FeeMonth, Amount, PayStatus, PayDate, Operator, Remark, CreateTime)
    SELECT 1,  1,  N'物业费', N'2026-09', 227.70, N'已缴', CONVERT(DATETIME, '2026-09-03 10:20:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 2,  1,  N'水费',   N'2026-09', 42.60,  N'已缴', CONVERT(DATETIME, '2026-09-03 10:20:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 3,  1,  N'电费',   N'2026-09', 186.30, N'未缴', NULL, NULL, N'请于月底前缴纳', CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 4,  1,  N'停车费', N'2026-09', 300.00, N'已缴', CONVERT(DATETIME, '2026-09-03 10:20:00', 120), N'admin', N'A-001 车位', CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 5,  2,  N'物业费', N'2026-09', 176.76, N'已缴', CONVERT(DATETIME, '2026-09-05 14:10:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 6,  2,  N'水费',   N'2026-09', 31.20,  N'未缴', NULL, NULL, NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 7,  3,  N'物业费', N'2026-09', 227.70, N'未缴', NULL, NULL, N'已电话提醒', CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 8,  4,  N'物业费', N'2026-09', 258.84, N'已缴', CONVERT(DATETIME, '2026-09-06 09:40:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 9,  4,  N'电费',   N'2026-09', 243.50, N'已缴', CONVERT(DATETIME, '2026-09-06 09:40:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 10, 5,  N'物业费', N'2026-09', 176.76, N'未缴', NULL, NULL, NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 11, 5,  N'停车费', N'2026-09', 300.00, N'已缴', CONVERT(DATETIME, '2026-09-08 16:00:00', 120), N'admin', N'A-006 车位', CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 12, 6,  N'物业费', N'2026-09', 227.70, N'已缴', CONVERT(DATETIME, '2026-09-09 11:25:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 13, 6,  N'水费',   N'2026-09', 55.80,  N'已缴', CONVERT(DATETIME, '2026-09-09 11:25:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 14, 7,  N'物业费', N'2026-09', 258.84, N'未缴', NULL, NULL, NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 15, 8,  N'物业费', N'2026-09', 176.76, N'已缴', CONVERT(DATETIME, '2026-09-12 08:30:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 16, 9,  N'物业费', N'2026-09', 227.70, N'已缴', CONVERT(DATETIME, '2026-09-13 15:45:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 17, 10, N'物业费', N'2026-09', 258.84, N'未缴', NULL, NULL, N'业主出差，回来自行缴纳', CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 18, 11, N'物业费', N'2026-09', 176.76, N'已缴', CONVERT(DATETIME, '2026-09-15 09:15:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 19, 12, N'物业费', N'2026-09', 227.70, N'已缴', CONVERT(DATETIME, '2026-09-16 10:50:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 20, 13, N'物业费', N'2026-09', 258.84, N'未缴', NULL, NULL, NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 21, 14, N'物业费', N'2026-09', 176.76, N'已缴', CONVERT(DATETIME, '2026-09-18 14:05:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 22, 15, N'物业费', N'2026-09', 227.70, N'已缴', CONVERT(DATETIME, '2026-09-19 16:35:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    UNION ALL SELECT 23, 16, N'物业费', N'2026-09', 258.84, N'未缴', NULL, NULL, NULL, CONVERT(DATETIME, '2026-09-01 08:00:00', 120)
    /* 上一个月（2026-08）的历史数据，全部已缴 */
    UNION ALL SELECT 24, 1,  N'物业费', N'2026-08', 227.70, N'已缴', CONVERT(DATETIME, '2026-08-04 10:00:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-08-01 08:00:00', 120)
    UNION ALL SELECT 25, 2,  N'物业费', N'2026-08', 176.76, N'已缴', CONVERT(DATETIME, '2026-08-05 11:10:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-08-01 08:00:00', 120)
    UNION ALL SELECT 26, 3,  N'物业费', N'2026-08', 227.70, N'已缴', CONVERT(DATETIME, '2026-08-06 09:05:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-08-01 08:00:00', 120)
    UNION ALL SELECT 27, 4,  N'物业费', N'2026-08', 258.84, N'已缴', CONVERT(DATETIME, '2026-08-07 15:20:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-08-01 08:00:00', 120)
    UNION ALL SELECT 28, 6,  N'物业费', N'2026-08', 227.70, N'已缴', CONVERT(DATETIME, '2026-08-10 10:40:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-08-01 08:00:00', 120)
    UNION ALL SELECT 29, 8,  N'物业费', N'2026-08', 176.76, N'已缴', CONVERT(DATETIME, '2026-08-12 08:55:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-08-01 08:00:00', 120)
    UNION ALL SELECT 30, 12, N'物业费', N'2026-08', 227.70, N'已缴', CONVERT(DATETIME, '2026-08-15 14:30:00', 120), N'admin', NULL, CONVERT(DATETIME, '2026-08-01 08:00:00', 120);

    SET IDENTITY_INSERT dbo.tb_Fee OFF;
    PRINT N'>> 已写入 tb_Fee 演示数据（30 条收费记录）';
END
GO

/* 5.9 投诉与建议 */
IF NOT EXISTS (SELECT 1 FROM dbo.tb_Feedback)
BEGIN
    SET IDENTITY_INSERT dbo.tb_Feedback ON;

    INSERT INTO dbo.tb_Feedback
        (FeedbackId, HouseholdId, FType, Title, Content, CreateTime, ReplyContent, ReplyUser, ReplyTime, Status)
    SELECT 1, 3, N'投诉', N'夜间施工噪音',
           N'3栋1单元楼下最近几天晚上十点后仍有施工噪音，影响老人休息，希望物业协调处理。',
           CONVERT(DATETIME, '2026-09-08 22:30:00', 120),
           N'已核实为地库照明改造施工，已要求施工方严格控制在 17:30 前收工，感谢您的监督。',
           N'admin', CONVERT(DATETIME, '2026-09-09 09:20:00', 120), N'已回复'
    UNION ALL SELECT 2, 5, N'建议', N'增加儿童游乐设施',
           N'中心花园的空地可以加一组滑梯和秋千，小区里小朋友比较多。',
           CONVERT(DATETIME, '2026-09-10 17:15:00', 120),
           N'建议已列入本年度设施改造计划，将在下一次业主大会上讨论预算。',
           N'admin', CONVERT(DATETIME, '2026-09-11 10:05:00', 120), N'已回复'
    UNION ALL SELECT 3, 7, N'投诉', N'垃圾分类点异味',
           N'2栋旁边的垃圾分类点清理不及时，天热时有明显异味。',
           CONVERT(DATETIME, '2026-09-14 08:40:00', 120), NULL, NULL, NULL, N'待处理'
    UNION ALL SELECT 4, 9, N'建议', N'增设非机动车充电桩',
           N'电动车充电需要推到地下室，建议在每栋楼下加装几组充电桩。',
           CONVERT(DATETIME, '2026-09-16 19:50:00', 120),
           N'已联系厂家现场勘察，预计下月先在 4 栋、5 栋试点安装。',
           N'admin', CONVERT(DATETIME, '2026-09-17 09:35:00', 120), N'已回复'
    UNION ALL SELECT 5, 11, N'投诉', N'电梯内部卫生较差',
           N'6栋1单元电梯地板经常有水渍和杂物，希望加强清扫频次。',
           CONVERT(DATETIME, '2026-09-18 12:20:00', 120), NULL, NULL, NULL, N'待处理'
    UNION ALL SELECT 6, 15, N'建议', N'小区快递柜位置调整',
           N'快递柜放在小区门口，取件要绕一大圈，建议移到中心花园旁。',
           CONVERT(DATETIME, '2026-09-20 20:10:00', 120), NULL, NULL, NULL, N'待处理';

    SET IDENTITY_INSERT dbo.tb_Feedback OFF;
    PRINT N'>> 已写入 tb_Feedback 演示数据（6 条）';
END
GO

/* 5.10 系统日志 */
IF NOT EXISTS (SELECT 1 FROM dbo.tb_SysLog)
BEGIN
    SET IDENTITY_INSERT dbo.tb_SysLog ON;

    INSERT INTO dbo.tb_SysLog (LogId, UserName, Action, Detail, LogTime)
    SELECT 1, N'admin', N'登录', N'管理员登录系统', CONVERT(DATETIME, '2026-09-20 08:30:12', 120)
    UNION ALL SELECT 2, N'admin', N'新增公告', N'新增公告：关于开展消防演练的通知', CONVERT(DATETIME, '2026-09-18 11:00:05', 120)
    UNION ALL SELECT 3, N'admin', N'收费登记', N'为 6栋1单元1503 登记物业费 176.76 元', CONVERT(DATETIME, '2026-09-15 09:15:20', 120)
    UNION ALL SELECT 4, N'13800000001', N'登录', N'业主登录系统', CONVERT(DATETIME, '2026-09-19 20:02:41', 120)
    UNION ALL SELECT 5, N'13800000001', N'提交报修', N'提交报修：厨房水管接口漏水', CONVERT(DATETIME, '2026-08-20 09:15:33', 120)
    UNION ALL SELECT 6, N'admin', N'处理报修', N'工单 10 已完成，维修人：李师傅', CONVERT(DATETIME, '2026-09-16 14:20:18', 120);

    SET IDENTITY_INSERT dbo.tb_SysLog OFF;
    PRINT N'>> 已写入 tb_SysLog 演示数据（6 条）';
END
GO

/*------------------------------------------------------------------------------
  第 6 步：执行结果自检
------------------------------------------------------------------------------*/
PRINT N'';
PRINT N'==================== 建库完成，数据统计 ====================';

SELECT N'tb_Community' AS 表名, COUNT(*) AS 记录数 FROM dbo.tb_Community
UNION ALL SELECT N'tb_Building',  COUNT(*) FROM dbo.tb_Building
UNION ALL SELECT N'tb_Household', COUNT(*) FROM dbo.tb_Household
UNION ALL SELECT N'tb_Parking',   COUNT(*) FROM dbo.tb_Parking
UNION ALL SELECT N'tb_SysUser',   COUNT(*) FROM dbo.tb_SysUser
UNION ALL SELECT N'tb_Notice',    COUNT(*) FROM dbo.tb_Notice
UNION ALL SELECT N'tb_Repair',    COUNT(*) FROM dbo.tb_Repair
UNION ALL SELECT N'tb_Fee',       COUNT(*) FROM dbo.tb_Fee
UNION ALL SELECT N'tb_Feedback',  COUNT(*) FROM dbo.tb_Feedback
UNION ALL SELECT N'tb_SysLog',    COUNT(*) FROM dbo.tb_SysLog;
GO

PRINT N'';
PRINT N'登录账号：admin / admin123（管理员），13800000001 / 123456（业主）';
PRINT N'接下来请在程序的 App.config 中把连接字符串改成你自己的实例地址。';
GO
