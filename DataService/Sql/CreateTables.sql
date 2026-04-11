-- CreateTables.sql
-- Idempotent SQL Server create script for initial CRM schema
-- Includes audit fields and soft-delete columns on every table

SET NOCOUNT ON;

-- Users
IF NOT EXISTS (SELECT 1 FROM sys.tables t JOIN sys.schemas s ON t.schema_id = s.schema_id WHERE s.name = 'dbo' AND t.name = 'Users')
BEGIN
CREATE TABLE dbo.Users (
    Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
    Username NVARCHAR(100) NOT NULL,
    FullName NVARCHAR(200) NULL,
    Email NVARCHAR(200) NULL,
    PasswordHash NVARCHAR(MAX) NULL,
    IsActive BIT NOT NULL DEFAULT(1),

    ActionId UNIQUEIDENTIFIER NULL,
    CreatedById UNIQUEIDENTIFIER NULL,
    ModifiedById UNIQUEIDENTIFIER NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    ModifiedAt DATETIME2 NULL,
    DeletedById UNIQUEIDENTIFIER NULL,
    DeletedAt DATETIME2 NULL,
    CreatedOnBehalfById UNIQUEIDENTIFIER NULL,
    ModifiedOnBehalfById UNIQUEIDENTIFIER NULL
);
END

-- Action (fact table for activities)
IF NOT EXISTS (SELECT 1 FROM sys.tables t JOIN sys.schemas s ON t.schema_id = s.schema_id WHERE s.name = 'dbo' AND t.name = 'Actions')
BEGIN
CREATE TABLE dbo.Actions (
    Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
    ActionType NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX) NULL,
    PerformedByUserId UNIQUEIDENTIFIER NULL,
    PerformedAt DATETIME2 NULL,

    -- standard audit + soft-delete
    CreatedById UNIQUEIDENTIFIER NULL,
    ModifiedById UNIQUEIDENTIFIER NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    ModifiedAt DATETIME2 NULL,
    DeletedById UNIQUEIDENTIFIER NULL,
    DeletedAt DATETIME2 NULL,
    CreatedOnBehalfById UNIQUEIDENTIFIER NULL,
    ModifiedOnBehalfById UNIQUEIDENTIFIER NULL
);

ALTER TABLE dbo.Actions
    ADD CONSTRAINT FK_Actions_PerformedByUser FOREIGN KEY (PerformedByUserId) REFERENCES dbo.Users(Id);
END

-- Account
IF NOT EXISTS (SELECT 1 FROM sys.tables t JOIN sys.schemas s ON t.schema_id = s.schema_id WHERE s.name = 'dbo' AND t.name = 'Accounts')
BEGIN
CREATE TABLE dbo.Accounts (
    Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
    Name NVARCHAR(250) NOT NULL,
    Industry NVARCHAR(100) NULL,
    Website NVARCHAR(250) NULL,

    ActionId UNIQUEIDENTIFIER NULL,
    CreatedById UNIQUEIDENTIFIER NULL,
    ModifiedById UNIQUEIDENTIFIER NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    ModifiedAt DATETIME2 NULL,
    DeletedById UNIQUEIDENTIFIER NULL,
    DeletedAt DATETIME2 NULL,
    CreatedOnBehalfById UNIQUEIDENTIFIER NULL,
    ModifiedOnBehalfById UNIQUEIDENTIFIER NULL
);

ALTER TABLE dbo.Accounts
    ADD CONSTRAINT FK_Accounts_Action FOREIGN KEY (ActionId) REFERENCES dbo.Actions(Id);
END

-- Contact (can be account contact, customer contact, etc.)
IF NOT EXISTS (SELECT 1 FROM sys.tables t JOIN sys.schemas s ON t.schema_id = s.schema_id WHERE s.name = 'dbo' AND t.name = 'Contacts')
BEGIN
CREATE TABLE dbo.Contacts (
    Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
    FirstName NVARCHAR(150) NULL,
    LastName NVARCHAR(150) NULL,
    ContactType NVARCHAR(100) NULL, -- e.g., AccountContact, CustomerContact
    Email NVARCHAR(200) NULL,
    Phone NVARCHAR(100) NULL,

    ActionId UNIQUEIDENTIFIER NULL,
    CreatedById UNIQUEIDENTIFIER NULL,
    ModifiedById UNIQUEIDENTIFIER NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    ModifiedAt DATETIME2 NULL,
    DeletedById UNIQUEIDENTIFIER NULL,
    DeletedAt DATETIME2 NULL,
    CreatedOnBehalfById UNIQUEIDENTIFIER NULL,
    ModifiedOnBehalfById UNIQUEIDENTIFIER NULL
);

ALTER TABLE dbo.Contacts
    ADD CONSTRAINT FK_Contacts_Action FOREIGN KEY (ActionId) REFERENCES dbo.Actions(Id);
END

-- Lead (potential customer)
IF NOT EXISTS (SELECT 1 FROM sys.tables t JOIN sys.schemas s ON t.schema_id = s.schema_id WHERE s.name = 'dbo' AND t.name = 'Leads')
BEGIN
CREATE TABLE dbo.Leads (
    Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
    Source NVARCHAR(200) NULL,
    Status NVARCHAR(100) NULL,
    FirstName NVARCHAR(150) NULL,
    LastName NVARCHAR(150) NULL,
    Email NVARCHAR(200) NULL,
    Phone NVARCHAR(100) NULL,

    ActionId UNIQUEIDENTIFIER NULL,
    CreatedById UNIQUEIDENTIFIER NULL,
    ModifiedById UNIQUEIDENTIFIER NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    ModifiedAt DATETIME2 NULL,
    DeletedById UNIQUEIDENTIFIER NULL,
    DeletedAt DATETIME2 NULL,
    CreatedOnBehalfById UNIQUEIDENTIFIER NULL,
    ModifiedOnBehalfById UNIQUEIDENTIFIER NULL
);

ALTER TABLE dbo.Leads
    ADD CONSTRAINT FK_Leads_Action FOREIGN KEY (ActionId) REFERENCES dbo.Actions(Id);
END

-- PhoneCall (also considered an Action, but keep specific metadata here)
IF NOT EXISTS (SELECT 1 FROM sys.tables t JOIN sys.schemas s ON t.schema_id = s.schema_id WHERE s.name = 'dbo' AND t.name = 'PhoneCalls')
BEGIN
CREATE TABLE dbo.PhoneCalls (
    Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
    Subject NVARCHAR(250) NULL,
    OccurredAt DATETIME2 NOT NULL,
    DurationSeconds INT NULL,
    FromUserId UNIQUEIDENTIFIER NULL,
    ToUserId UNIQUEIDENTIFIER NULL,
    AccountId UNIQUEIDENTIFIER NULL,
    ContactId UNIQUEIDENTIFIER NULL,
    LeadId UNIQUEIDENTIFIER NULL,
    Notes NVARCHAR(MAX) NULL,

    ActionId UNIQUEIDENTIFIER NULL,
    CreatedById UNIQUEIDENTIFIER NULL,
    ModifiedById UNIQUEIDENTIFIER NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    ModifiedAt DATETIME2 NULL,
    DeletedById UNIQUEIDENTIFIER NULL,
    DeletedAt DATETIME2 NULL,
    CreatedOnBehalfById UNIQUEIDENTIFIER NULL,
    ModifiedOnBehalfById UNIQUEIDENTIFIER NULL
);

ALTER TABLE dbo.PhoneCalls ADD CONSTRAINT FK_PhoneCalls_FromUser FOREIGN KEY (FromUserId) REFERENCES dbo.Users(Id);
ALTER TABLE dbo.PhoneCalls ADD CONSTRAINT FK_PhoneCalls_ToUser FOREIGN KEY (ToUserId) REFERENCES dbo.Users(Id);
ALTER TABLE dbo.PhoneCalls ADD CONSTRAINT FK_PhoneCalls_Account FOREIGN KEY (AccountId) REFERENCES dbo.Accounts(Id);
ALTER TABLE dbo.PhoneCalls ADD CONSTRAINT FK_PhoneCalls_Contact FOREIGN KEY (ContactId) REFERENCES dbo.Contacts(Id);
ALTER TABLE dbo.PhoneCalls ADD CONSTRAINT FK_PhoneCalls_Lead FOREIGN KEY (LeadId) REFERENCES dbo.Leads(Id);
ALTER TABLE dbo.PhoneCalls ADD CONSTRAINT FK_PhoneCalls_Action FOREIGN KEY (ActionId) REFERENCES dbo.Actions(Id);
END

-- Email
IF NOT EXISTS (SELECT 1 FROM sys.tables t JOIN sys.schemas s ON t.schema_id = s.schema_id WHERE s.name = 'dbo' AND t.name = 'Emails')
BEGIN
CREATE TABLE dbo.Emails (
    Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
    Subject NVARCHAR(500) NULL,
    Body NVARCHAR(MAX) NULL,
    SentAt DATETIME2 NULL,
    FromUserId UNIQUEIDENTIFIER NULL,
    ToUserId UNIQUEIDENTIFIER NULL,
    AccountId UNIQUEIDENTIFIER NULL,
    ContactId UNIQUEIDENTIFIER NULL,
    LeadId UNIQUEIDENTIFIER NULL,

    ActionId UNIQUEIDENTIFIER NULL,
    CreatedById UNIQUEIDENTIFIER NULL,
    ModifiedById UNIQUEIDENTIFIER NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    ModifiedAt DATETIME2 NULL,
    DeletedById UNIQUEIDENTIFIER NULL,
    DeletedAt DATETIME2 NULL,
    CreatedOnBehalfById UNIQUEIDENTIFIER NULL,
    ModifiedOnBehalfById UNIQUEIDENTIFIER NULL
);

ALTER TABLE dbo.Emails ADD CONSTRAINT FK_Emails_FromUser FOREIGN KEY (FromUserId) REFERENCES dbo.Users(Id);
ALTER TABLE dbo.Emails ADD CONSTRAINT FK_Emails_ToUser FOREIGN KEY (ToUserId) REFERENCES dbo.Users(Id);
ALTER TABLE dbo.Emails ADD CONSTRAINT FK_Emails_Account FOREIGN KEY (AccountId) REFERENCES dbo.Accounts(Id);
ALTER TABLE dbo.Emails ADD CONSTRAINT FK_Emails_Contact FOREIGN KEY (ContactId) REFERENCES dbo.Contacts(Id);
ALTER TABLE dbo.Emails ADD CONSTRAINT FK_Emails_Lead FOREIGN KEY (LeadId) REFERENCES dbo.Leads(Id);
ALTER TABLE dbo.Emails ADD CONSTRAINT FK_Emails_Action FOREIGN KEY (ActionId) REFERENCES dbo.Actions(Id);
END

-- Chat messages
IF NOT EXISTS (SELECT 1 FROM sys.tables t JOIN sys.schemas s ON t.schema_id = s.schema_id WHERE s.name = 'dbo' AND t.name = 'Chats')
BEGIN
CREATE TABLE dbo.Chats (
    Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
    Message NVARCHAR(MAX) NOT NULL,
    SentAt DATETIME2 NOT NULL,
    FromUserId UNIQUEIDENTIFIER NULL,
    ToUserId UNIQUEIDENTIFIER NULL,
    AccountId UNIQUEIDENTIFIER NULL,
    ContactId UNIQUEIDENTIFIER NULL,
    LeadId UNIQUEIDENTIFIER NULL,

    ActionId UNIQUEIDENTIFIER NULL,
    CreatedById UNIQUEIDENTIFIER NULL,
    ModifiedById UNIQUEIDENTIFIER NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    ModifiedAt DATETIME2 NULL,
    DeletedById UNIQUEIDENTIFIER NULL,
    DeletedAt DATETIME2 NULL,
    CreatedOnBehalfById UNIQUEIDENTIFIER NULL,
    ModifiedOnBehalfById UNIQUEIDENTIFIER NULL
);

ALTER TABLE dbo.Chats ADD CONSTRAINT FK_Chats_FromUser FOREIGN KEY (FromUserId) REFERENCES dbo.Users(Id);
ALTER TABLE dbo.Chats ADD CONSTRAINT FK_Chats_ToUser FOREIGN KEY (ToUserId) REFERENCES dbo.Users(Id);
ALTER TABLE dbo.Chats ADD CONSTRAINT FK_Chats_Account FOREIGN KEY (AccountId) REFERENCES dbo.Accounts(Id);
ALTER TABLE dbo.Chats ADD CONSTRAINT FK_Chats_Contact FOREIGN KEY (ContactId) REFERENCES dbo.Contacts(Id);
ALTER TABLE dbo.Chats ADD CONSTRAINT FK_Chats_Lead FOREIGN KEY (LeadId) REFERENCES dbo.Leads(Id);
ALTER TABLE dbo.Chats ADD CONSTRAINT FK_Chats_Action FOREIGN KEY (ActionId) REFERENCES dbo.Actions(Id);
END

-- Calendar
IF NOT EXISTS (SELECT 1 FROM sys.tables t JOIN sys.schemas s ON t.schema_id = s.schema_id WHERE s.name = 'dbo' AND t.name = 'Calendars')
BEGIN
CREATE TABLE dbo.Calendars (
    Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
    Name NVARCHAR(250) NOT NULL,
    Description NVARCHAR(MAX) NULL,
    TimeZone NVARCHAR(100) NULL,
    OwnerUserId UNIQUEIDENTIFIER NULL,

    ActionId UNIQUEIDENTIFIER NULL,
    CreatedById UNIQUEIDENTIFIER NULL,
    ModifiedById UNIQUEIDENTIFIER NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    ModifiedAt DATETIME2 NULL,
    DeletedById UNIQUEIDENTIFIER NULL,
    DeletedAt DATETIME2 NULL,
    CreatedOnBehalfById UNIQUEIDENTIFIER NULL,
    ModifiedOnBehalfById UNIQUEIDENTIFIER NULL
);

ALTER TABLE dbo.Calendars ADD CONSTRAINT FK_Calendars_OwnerUser FOREIGN KEY (OwnerUserId) REFERENCES dbo.Users(Id);
ALTER TABLE dbo.Calendars ADD CONSTRAINT FK_Calendars_Action FOREIGN KEY (ActionId) REFERENCES dbo.Actions(Id);
END

-- CalendarActionXref (many-to-many between Calendar and Action)
IF NOT EXISTS (SELECT 1 FROM sys.tables t JOIN sys.schemas s ON t.schema_id = s.schema_id WHERE s.name = 'dbo' AND t.name = 'CalendarActionXref')
BEGIN
CREATE TABLE dbo.CalendarActionXref (
    CalendarId UNIQUEIDENTIFIER NOT NULL,
    ActionId UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY (CalendarId, ActionId)
);
ALTER TABLE dbo.CalendarActionXref ADD CONSTRAINT FK_CalendarActionXref_Calendar FOREIGN KEY (CalendarId) REFERENCES dbo.Calendars(Id);
ALTER TABLE dbo.CalendarActionXref ADD CONSTRAINT FK_CalendarActionXref_Action FOREIGN KEY (ActionId) REFERENCES dbo.Actions(Id);
END

-- AccountActionXref
IF NOT EXISTS (SELECT 1 FROM sys.tables t JOIN sys.schemas s ON t.schema_id = s.schema_id WHERE s.name = 'dbo' AND t.name = 'AccountActionXref')
BEGIN
CREATE TABLE dbo.AccountActionXref (
    AccountId UNIQUEIDENTIFIER NOT NULL,
    ActionId UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY (AccountId, ActionId)
);
ALTER TABLE dbo.AccountActionXref ADD CONSTRAINT FK_AccountActionXref_Account FOREIGN KEY (AccountId) REFERENCES dbo.Accounts(Id);
ALTER TABLE dbo.AccountActionXref ADD CONSTRAINT FK_AccountActionXref_Action FOREIGN KEY (ActionId) REFERENCES dbo.Actions(Id);
END

-- AccountContactXref
IF NOT EXISTS (SELECT 1 FROM sys.tables t JOIN sys.schemas s ON t.schema_id = s.schema_id WHERE s.name = 'dbo' AND t.name = 'AccountContactXref')
BEGIN
CREATE TABLE dbo.AccountContactXref (
    AccountId UNIQUEIDENTIFIER NOT NULL,
    ContactId UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY (AccountId, ContactId)
);
ALTER TABLE dbo.AccountContactXref ADD CONSTRAINT FK_AccountContactXref_Account FOREIGN KEY (AccountId) REFERENCES dbo.Accounts(Id);
ALTER TABLE dbo.AccountContactXref ADD CONSTRAINT FK_AccountContactXref_Contact FOREIGN KEY (ContactId) REFERENCES dbo.Contacts(Id);
END

-- ContactActionXref
IF NOT EXISTS (SELECT 1 FROM sys.tables t JOIN sys.schemas s ON t.schema_id = s.schema_id WHERE s.name = 'dbo' AND t.name = 'ContactActionXref')
BEGIN
CREATE TABLE dbo.ContactActionXref (
    ContactId UNIQUEIDENTIFIER NOT NULL,
    ActionId UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY (ContactId, ActionId)
);
ALTER TABLE dbo.ContactActionXref ADD CONSTRAINT FK_ContactActionXref_Contact FOREIGN KEY (ContactId) REFERENCES dbo.Contacts(Id);
ALTER TABLE dbo.ContactActionXref ADD CONSTRAINT FK_ContactActionXref_Action FOREIGN KEY (ActionId) REFERENCES dbo.Actions(Id);
END

-- Add FK constraints that reference Users for audit columns (optional, avoid cascading)
-- Helper: add FK for CreatedById, ModifiedById, DeletedById, CreatedOnBehalfById, ModifiedOnBehalfById where relevant

-- Actions audit FKs
IF EXISTS (SELECT 1 FROM sys.tables t WHERE t.name = 'Actions')
BEGIN
    IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys fk WHERE fk.parent_object_id = OBJECT_ID('dbo.Actions') AND fk.name = 'FK_Actions_CreatedBy')
    BEGIN
        ALTER TABLE dbo.Actions ADD CONSTRAINT FK_Actions_CreatedBy FOREIGN KEY (CreatedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Actions ADD CONSTRAINT FK_Actions_ModifiedBy FOREIGN KEY (ModifiedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Actions ADD CONSTRAINT FK_Actions_DeletedBy FOREIGN KEY (DeletedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Actions ADD CONSTRAINT FK_Actions_CreatedOnBehalfBy FOREIGN KEY (CreatedOnBehalfById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Actions ADD CONSTRAINT FK_Actions_ModifiedOnBehalfBy FOREIGN KEY (ModifiedOnBehalfById) REFERENCES dbo.Users(Id);
    END
END

-- Accounts audit FKs
IF EXISTS (SELECT 1 FROM sys.tables t WHERE t.name = 'Accounts')
BEGIN
    IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys fk WHERE fk.parent_object_id = OBJECT_ID('dbo.Accounts') AND fk.name = 'FK_Accounts_CreatedBy')
    BEGIN
        ALTER TABLE dbo.Accounts ADD CONSTRAINT FK_Accounts_CreatedBy FOREIGN KEY (CreatedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Accounts ADD CONSTRAINT FK_Accounts_ModifiedBy FOREIGN KEY (ModifiedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Accounts ADD CONSTRAINT FK_Accounts_DeletedBy FOREIGN KEY (DeletedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Accounts ADD CONSTRAINT FK_Accounts_CreatedOnBehalfBy FOREIGN KEY (CreatedOnBehalfById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Accounts ADD CONSTRAINT FK_Accounts_ModifiedOnBehalfBy FOREIGN KEY (ModifiedOnBehalfById) REFERENCES dbo.Users(Id);
    END
END

-- Contacts audit FKs
IF EXISTS (SELECT 1 FROM sys.tables t WHERE t.name = 'Contacts')
BEGIN
    IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys fk WHERE fk.parent_object_id = OBJECT_ID('dbo.Contacts') AND fk.name = 'FK_Contacts_CreatedBy')
    BEGIN
        ALTER TABLE dbo.Contacts ADD CONSTRAINT FK_Contacts_CreatedBy FOREIGN KEY (CreatedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Contacts ADD CONSTRAINT FK_Contacts_ModifiedBy FOREIGN KEY (ModifiedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Contacts ADD CONSTRAINT FK_Contacts_DeletedBy FOREIGN KEY (DeletedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Contacts ADD CONSTRAINT FK_Contacts_CreatedOnBehalfBy FOREIGN KEY (CreatedOnBehalfById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Contacts ADD CONSTRAINT FK_Contacts_ModifiedOnBehalfBy FOREIGN KEY (ModifiedOnBehalfById) REFERENCES dbo.Users(Id);
    END
END

-- Leads audit FKs
IF EXISTS (SELECT 1 FROM sys.tables t WHERE t.name = 'Leads')
BEGIN
    IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys fk WHERE fk.parent_object_id = OBJECT_ID('dbo.Leads') AND fk.name = 'FK_Leads_CreatedBy')
    BEGIN
        ALTER TABLE dbo.Leads ADD CONSTRAINT FK_Leads_CreatedBy FOREIGN KEY (CreatedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Leads ADD CONSTRAINT FK_Leads_ModifiedBy FOREIGN KEY (ModifiedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Leads ADD CONSTRAINT FK_Leads_DeletedBy FOREIGN KEY (DeletedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Leads ADD CONSTRAINT FK_Leads_CreatedOnBehalfBy FOREIGN KEY (CreatedOnBehalfById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Leads ADD CONSTRAINT FK_Leads_ModifiedOnBehalfBy FOREIGN KEY (ModifiedOnBehalfById) REFERENCES dbo.Users(Id);
    END
END

-- PhoneCalls audit FKs
IF EXISTS (SELECT 1 FROM sys.tables t WHERE t.name = 'PhoneCalls')
BEGIN
    IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys fk WHERE fk.parent_object_id = OBJECT_ID('dbo.PhoneCalls') AND fk.name = 'FK_PhoneCalls_CreatedBy')
    BEGIN
        ALTER TABLE dbo.PhoneCalls ADD CONSTRAINT FK_PhoneCalls_CreatedBy FOREIGN KEY (CreatedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.PhoneCalls ADD CONSTRAINT FK_PhoneCalls_ModifiedBy FOREIGN KEY (ModifiedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.PhoneCalls ADD CONSTRAINT FK_PhoneCalls_DeletedBy FOREIGN KEY (DeletedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.PhoneCalls ADD CONSTRAINT FK_PhoneCalls_CreatedOnBehalfBy FOREIGN KEY (CreatedOnBehalfById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.PhoneCalls ADD CONSTRAINT FK_PhoneCalls_ModifiedOnBehalfBy FOREIGN KEY (ModifiedOnBehalfById) REFERENCES dbo.Users(Id);
    END
END

-- Emails audit FKs
IF EXISTS (SELECT 1 FROM sys.tables t WHERE t.name = 'Emails')
BEGIN
    IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys fk WHERE fk.parent_object_id = OBJECT_ID('dbo.Emails') AND fk.name = 'FK_Emails_CreatedBy')
    BEGIN
        ALTER TABLE dbo.Emails ADD CONSTRAINT FK_Emails_CreatedBy FOREIGN KEY (CreatedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Emails ADD CONSTRAINT FK_Emails_ModifiedBy FOREIGN KEY (ModifiedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Emails ADD CONSTRAINT FK_Emails_DeletedBy FOREIGN KEY (DeletedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Emails ADD CONSTRAINT FK_Emails_CreatedOnBehalfBy FOREIGN KEY (CreatedOnBehalfById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Emails ADD CONSTRAINT FK_Emails_ModifiedOnBehalfBy FOREIGN KEY (ModifiedOnBehalfById) REFERENCES dbo.Users(Id);
    END
END

-- Chats audit FKs
IF EXISTS (SELECT 1 FROM sys.tables t WHERE t.name = 'Chats')
BEGIN
    IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys fk WHERE fk.parent_object_id = OBJECT_ID('dbo.Chats') AND fk.name = 'FK_Chats_CreatedBy')
    BEGIN
        ALTER TABLE dbo.Chats ADD CONSTRAINT FK_Chats_CreatedBy FOREIGN KEY (CreatedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Chats ADD CONSTRAINT FK_Chats_ModifiedBy FOREIGN KEY (ModifiedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Chats ADD CONSTRAINT FK_Chats_DeletedBy FOREIGN KEY (DeletedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Chats ADD CONSTRAINT FK_Chats_CreatedOnBehalfBy FOREIGN KEY (CreatedOnBehalfById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Chats ADD CONSTRAINT FK_Chats_ModifiedOnBehalfBy FOREIGN KEY (ModifiedOnBehalfById) REFERENCES dbo.Users(Id);
    END
END

-- Calendars audit FKs
IF EXISTS (SELECT 1 FROM sys.tables t WHERE t.name = 'Calendars')
BEGIN
    IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys fk WHERE fk.parent_object_id = OBJECT_ID('dbo.Calendars') AND fk.name = 'FK_Calendars_CreatedBy')
    BEGIN
        ALTER TABLE dbo.Calendars ADD CONSTRAINT FK_Calendars_CreatedBy FOREIGN KEY (CreatedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Calendars ADD CONSTRAINT FK_Calendars_ModifiedBy FOREIGN KEY (ModifiedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Calendars ADD CONSTRAINT FK_Calendars_DeletedBy FOREIGN KEY (DeletedById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Calendars ADD CONSTRAINT FK_Calendars_CreatedOnBehalfBy FOREIGN KEY (CreatedOnBehalfById) REFERENCES dbo.Users(Id);
        ALTER TABLE dbo.Calendars ADD CONSTRAINT FK_Calendars_ModifiedOnBehalfBy FOREIGN KEY (ModifiedOnBehalfById) REFERENCES dbo.Users(Id);
    END
END

-- NOTE: FKs are configured to reference Users/Actions/Accounts/Contacts/Leads. Soft-delete is implemented by setting DeletedAt (and optionally DeletedById) instead of deleting rows.

-- WorkflowTickets (durable queue for workflow engine)
IF NOT EXISTS (SELECT 1 FROM sys.tables t JOIN sys.schemas s ON t.schema_id = s.schema_id WHERE s.name = 'dbo' AND t.name = 'WorkflowTickets')
BEGIN
CREATE TABLE dbo.WorkflowTickets (
    Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
    InteractionId UNIQUEIDENTIFIER NOT NULL,
    CurrentState NVARCHAR(100) NOT NULL DEFAULT 'Pending',
    Priority INT NOT NULL DEFAULT 0,
    RouteAttributesJson NVARCHAR(MAX) NULL,
    NextProcessor NVARCHAR(200) NULL,
    Attempts INT NOT NULL DEFAULT 0,
    LockedBy NVARCHAR(200) NULL,
    LockedAt DATETIME2 NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    DueAt DATETIME2 NULL,
    CompletedAt DATETIME2 NULL,
    ResultJson NVARCHAR(MAX) NULL
);

ALTER TABLE dbo.WorkflowTickets ADD CONSTRAINT FK_WorkflowTickets_Interaction FOREIGN KEY (InteractionId) REFERENCES dbo.Actions(Id);
END

PRINT 'CreateTables.sql completed.';
