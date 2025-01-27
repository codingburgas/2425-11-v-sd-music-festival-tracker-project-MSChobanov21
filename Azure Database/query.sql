CREATE TABLE SignUps (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Password VARCHAR(100) NOT NULL, 
    ConfirmPassword VARCHAR(100) NOT NULL,
    CONSTRAINT CK_Password_Match CHECK (Password = ConfirmPassword) 
);
CREATE TABLE Artists (
    ArtistId INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Description TEXT
);
CREATE TABLE Events (
    EventId INT IDENTITY(1,1) PRIMARY KEY,
    ArtistId INT,
    EventName VARCHAR(255) NOT NULL,
    EventDate DATETIME2,
    Venue VARCHAR(255),
    FOREIGN KEY (ArtistId) REFERENCES Artists(ArtistId)
);
CREATE TABLE Tickets (
    TicketId INT IDENTITY(1,1) PRIMARY KEY,
    EventId INT,
    Price DECIMAL(10,2),
    AvailableTickets INT,
    FOREIGN KEY (EventId) REFERENCES Events(EventId)
);