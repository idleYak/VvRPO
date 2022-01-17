
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/06/2022 19:28:26
-- Generated from EDMX file: D:\study_21-22_semestr7\subd\Oformlenie_biletov\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Oformlenie_biletov];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TrainSet'
CREATE TABLE [dbo].[TrainSet] (
    [Id_train] int IDENTITY(1,1) NOT NULL,
    [Train_number] int  NOT NULL,
    [Train_type] nvarchar(max)  NOT NULL,
    [Passenger_seats] int  NOT NULL,
    [Point_departure] nvarchar(max)  NOT NULL,
    [Point_destination] nvarchar(max)  NOT NULL,
    [Time_departure] datetime  NOT NULL,
    [Time_destination] datetime  NOT NULL
);
GO

-- Creating table 'TicketSet'
CREATE TABLE [dbo].[TicketSet] (
    [Id_ticket] int IDENTITY(1,1) NOT NULL,
    [Ticket_number] bigint  NOT NULL,
    [Carrige_type] nvarchar(max)  NOT NULL,
    [Carrige_number] int  NOT NULL,
    [Place_number] int  NOT NULL,
    [PassengerId_passenger] int  NOT NULL,
    [Train_Id_train] int  NOT NULL,
    [Ticket_cost_Id_ticket_cost] int  NOT NULL
);
GO

-- Creating table 'Ticket_costSet'
CREATE TABLE [dbo].[Ticket_costSet] (
    [Id_ticket_cost] int IDENTITY(1,1) NOT NULL,
    [Cost] int  NOT NULL,
    [Status] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PaymentSet'
CREATE TABLE [dbo].[PaymentSet] (
    [Id_payment] int IDENTITY(1,1) NOT NULL,
    [Card_number] bigint  NOT NULL,
    [Time_payment] datetime  NOT NULL,
    [Ticket_cost_Id_ticket_cost] int  NOT NULL
);
GO

-- Creating table 'PassengerSet'
CREATE TABLE [dbo].[PassengerSet] (
    [Id_passenger] int IDENTITY(1,1) NOT NULL,
    [FIO] nvarchar(max)  NOT NULL,
    [Document_data] bigint  NOT NULL,
    [Document_type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StationSet'
CREATE TABLE [dbo].[StationSet] (
    [Id_station] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Station_Train'
CREATE TABLE [dbo].[Station_Train] (
    [Station_Id_station] int  NOT NULL,
    [Train_Id_train] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_train] in table 'TrainSet'
ALTER TABLE [dbo].[TrainSet]
ADD CONSTRAINT [PK_TrainSet]
    PRIMARY KEY CLUSTERED ([Id_train] ASC);
GO

-- Creating primary key on [Id_ticket] in table 'TicketSet'
ALTER TABLE [dbo].[TicketSet]
ADD CONSTRAINT [PK_TicketSet]
    PRIMARY KEY CLUSTERED ([Id_ticket] ASC);
GO

-- Creating primary key on [Id_ticket_cost] in table 'Ticket_costSet'
ALTER TABLE [dbo].[Ticket_costSet]
ADD CONSTRAINT [PK_Ticket_costSet]
    PRIMARY KEY CLUSTERED ([Id_ticket_cost] ASC);
GO

-- Creating primary key on [Id_payment] in table 'PaymentSet'
ALTER TABLE [dbo].[PaymentSet]
ADD CONSTRAINT [PK_PaymentSet]
    PRIMARY KEY CLUSTERED ([Id_payment] ASC);
GO

-- Creating primary key on [Id_passenger] in table 'PassengerSet'
ALTER TABLE [dbo].[PassengerSet]
ADD CONSTRAINT [PK_PassengerSet]
    PRIMARY KEY CLUSTERED ([Id_passenger] ASC);
GO

-- Creating primary key on [Id_station] in table 'StationSet'
ALTER TABLE [dbo].[StationSet]
ADD CONSTRAINT [PK_StationSet]
    PRIMARY KEY CLUSTERED ([Id_station] ASC);
GO

-- Creating primary key on [Station_Id_station], [Train_Id_train] in table 'Station_Train'
ALTER TABLE [dbo].[Station_Train]
ADD CONSTRAINT [PK_Station_Train]
    PRIMARY KEY CLUSTERED ([Station_Id_station], [Train_Id_train] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Train_Id_train] in table 'TicketSet'
ALTER TABLE [dbo].[TicketSet]
ADD CONSTRAINT [FK_Ticket_Train]
    FOREIGN KEY ([Train_Id_train])
    REFERENCES [dbo].[TrainSet]
        ([Id_train])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ticket_Train'
CREATE INDEX [IX_FK_Ticket_Train]
ON [dbo].[TicketSet]
    ([Train_Id_train]);
GO

-- Creating foreign key on [Station_Id_station] in table 'Station_Train'
ALTER TABLE [dbo].[Station_Train]
ADD CONSTRAINT [FK_Station_Train_Station]
    FOREIGN KEY ([Station_Id_station])
    REFERENCES [dbo].[StationSet]
        ([Id_station])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Train_Id_train] in table 'Station_Train'
ALTER TABLE [dbo].[Station_Train]
ADD CONSTRAINT [FK_Station_Train_Train]
    FOREIGN KEY ([Train_Id_train])
    REFERENCES [dbo].[TrainSet]
        ([Id_train])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Station_Train_Train'
CREATE INDEX [IX_FK_Station_Train_Train]
ON [dbo].[Station_Train]
    ([Train_Id_train]);
GO

-- Creating foreign key on [Ticket_cost_Id_ticket_cost] in table 'TicketSet'
ALTER TABLE [dbo].[TicketSet]
ADD CONSTRAINT [FK_Ticket_Ticket_cost]
    FOREIGN KEY ([Ticket_cost_Id_ticket_cost])
    REFERENCES [dbo].[Ticket_costSet]
        ([Id_ticket_cost])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ticket_Ticket_cost'
CREATE INDEX [IX_FK_Ticket_Ticket_cost]
ON [dbo].[TicketSet]
    ([Ticket_cost_Id_ticket_cost]);
GO

-- Creating foreign key on [PassengerId_passenger] in table 'TicketSet'
ALTER TABLE [dbo].[TicketSet]
ADD CONSTRAINT [FK_Passenger_Ticket]
    FOREIGN KEY ([PassengerId_passenger])
    REFERENCES [dbo].[PassengerSet]
        ([Id_passenger])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Passenger_Ticket'
CREATE INDEX [IX_FK_Passenger_Ticket]
ON [dbo].[TicketSet]
    ([PassengerId_passenger]);
GO

-- Creating foreign key on [Ticket_cost_Id_ticket_cost] in table 'PaymentSet'
ALTER TABLE [dbo].[PaymentSet]
ADD CONSTRAINT [FK_Payment_Ticket_cost]
    FOREIGN KEY ([Ticket_cost_Id_ticket_cost])
    REFERENCES [dbo].[Ticket_costSet]
        ([Id_ticket_cost])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Payment_Ticket_cost'
CREATE INDEX [IX_FK_Payment_Ticket_cost]
ON [dbo].[PaymentSet]
    ([Ticket_cost_Id_ticket_cost]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------