/*
   Швиденко Дмитро Юрійович (ІШІ-501)

   task:
   Створіть базу даних з ім’ям «DreamHomeDB».
   У створеній БД DreamHomeDB створіть 5 таблиць:
   Staff, Property_for_Rent, Renter, Qwner, Viewing.

*/

CREATE TABLE Staff (
    Bno INT PRIMARY KEY,
    FName VARCHAR(255),
    LName VARCHAR(255),
    Street VARCHAR(255),
    Area VARCHAR(255),
    City VARCHAR(255),
    Pcode VARCHAR(10),
    Tel_No VARCHAR(15),
    Fax_No VARCHAR(15)
);
CREATE TABLE Property_for_Rent (
    Sno INT PRIMARY KEY,
    FName VARCHAR(255),
    LName VARCHAR(255),
    Address VARCHAR(255),
    Tel_No VARCHAR(15),
    Position VARCHAR(255),
    Sex VARCHAR(1),
    DOB DATE,
    Salary DECIMAL(10, 2),
    NIN VARCHAR(15),
    Bno INT,
    FOREIGN KEY (Bno) REFERENCES Staff(Bno)
);
CREATE TABLE Renter (
    Rno INT PRIMARY KEY,
    FName VARCHAR(255),
    LName VARCHAR(255),
    Address VARCHAR(255),
    Tel_No VARCHAR(15),
    Pref_Type VARCHAR(255),
    Max_Rent DECIMAL(10, 2),
    Bno INT,
    FOREIGN KEY (Bno) REFERENCES Staff(Bno)
);
CREATE TABLE Qwner (
    FName VARCHAR(255),
    LName VARCHAR(255),
    Address VARCHAR(255),
    Tel_No VARCHAR(15),
    PRIMARY KEY (FName, LName)
);
CREATE TABLE Viewing (
    Rno INT,
    Pno INT,
    Date DATE,
    Comment VARCHAR(255),
    PRIMARY KEY (Rno, Pno),
    FOREIGN KEY (Rno) REFERENCES Renter(Rno),
    FOREIGN KEY (Pno) REFERENCES Property_for_Rent(Sno)
);