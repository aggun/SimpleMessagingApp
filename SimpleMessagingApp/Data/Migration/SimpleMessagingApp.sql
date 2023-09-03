CREATE DATABASE SimpleMessagingApp;

USE SimpleMessagingApp;

CREATE TABLE Users (
    Nickname VARCHAR(255) PRIMARY KEY
);

CREATE TABLE Servers (
    Nickname VARCHAR(255) PRIMARY KEY
);

CREATE TABLE Messages (
    MessageId INT IDENTITY(1,1) PRIMARY KEY,
    Content NVARCHAR(MAX) NOT NULL,
    SenderUserName VARCHAR(255) NOT NULL,
    RecipientUserName VARCHAR(255) NOT NULL,
    InsertDateTime DATETIME NOT NULL,

    FOREIGN KEY (SenderUserName) REFERENCES Users (Nickname),
    FOREIGN KEY (RecipientUserName) REFERENCES Servers (Nickname)
);
