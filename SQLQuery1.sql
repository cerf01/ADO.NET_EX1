CREATE DATABASE Journal
GO

USE Journal
GO


CREATE TABLE Students (
    Id  INT IDENTITY (1, 1) NOT NULL,
    Fullname NVARCHAR (MAX) NOT NULL,  
    GroupName NVARCHAR (MAX) NOT NULL,  
    SunbjMinAward   NVARCHAR (MAX) NOT NULL,
    SunbjMaxAward   NVARCHAR (MAX) NOT NULL,
    AwerageAward INT NOT NULL
);
GO

INSERT INTO Students VALUES
('Firstname1 Midname1 Lastname1', 'F14', 'Chemistry','Philosophy',10);

INSERT INTO Students VALUES
('Firstname2 Midname2 Lastname2', 'F14', 'Physic','Math',7);

INSERT INTO Students VALUES
('Firstname3 Midname3 Lastname3', 'F14', 'Math','PE',6);

INSERT INTO Students VALUES
('Firstname4 Midname4 Lastname4', 'F14', 'Classical literature','World history',9);