﻿CREATE TABLE [dbo].[CustomerData] (
    [Id]                          INT           IDENTITY (1, 1) NOT NULL,
    [Applicant]                   NVARCHAR (50) NULL,
    [Surname]                     NVARCHAR (50) NULL,
    [Other Name]                  NVARCHAR (50) NULL,
    [VillageTown]                 NVARCHAR (50) NULL,
    [Address Of supply]           NVARCHAR (50) NULL,
    [LGA]                         NVARCHAR (50) NULL,
    [State]                       NVARCHAR (50) NULL,
    [TelNo]                       NVARCHAR (50) NULL,
    [Alternate No]                NVARCHAR (50) NULL,
    [Type Of Premises]            NVARCHAR (50) NULL,
    [No Of Floors]                NVARCHAR (50) NULL,
    [No Of Flats]                 NVARCHAR (50) NULL,
    [Use Of Premises]             NVARCHAR (50) NULL,
    [Name On The Bill]            NVARCHAR (50) NULL,
    [Account Number]              NVARCHAR (50) NULL,
    [Old Meter Number]            NVARCHAR (50) NULL,
    [Tariff Class]                NVARCHAR (50) NULL,
    [Existing Connection Details] NVARCHAR (50) NULL,
    [Current Billing Information] NVARCHAR (50) NULL,
    [Meter Type]                  NVARCHAR (50) NULL,
    [Type Of Connection]          NVARCHAR (50) NULL,
    [Total Watts]                 INT           NULL,
    [Owner Name]                  NVARCHAR (50) NULL,
    [Owner Address]               NVARCHAR (50) NULL,
    [Owner Town]                  NVARCHAR (50) NULL,
    [Owner LGA]                   NVARCHAR (50) NULL,
    [Owner State]                 NVARCHAR (50) NULL,
    [Owner Tel No]                NVARCHAR (50) NULL,
    [Owner Alt No]                NVARCHAR (50) NULL,
    [Owner Email]                 NVARCHAR (50) NULL,
    [Owner Previous Occupant]     NVARCHAR (50) NULL,
    [Owner Account Number]        NVARCHAR (50) NULL,
    [Owner Meter Number]          NVARCHAR (50) NULL,
    [Office Account Number] NVARCHAR(50) NULL, 
    [Office Meter No] NVARCHAR(50) NULL, 
    [Office Meter Make] NVARCHAR(50) NULL, 
    [Office Last Bill Amount] NVARCHAR(50) NULL, 
    [Office Total Outstanding] NVARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

