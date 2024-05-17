# CSharpTrainings

For Mssql

CREATE TABLE [tbl_student] (
  [id] INT NOT NULL IDENTITY(1,1),
  [FirstName] NVARCHAR(45) NULL,
  [LastName] NVARCHAR(45) NULL,
  [Gender] NVARCHAR(45) NULL,
  [DateOfBirth] DATE NULL,
  [isActive] BIT NULL,
  PRIMARY KEY ([id])
);

INSERT INTO tbl_student (FirstName, LastName, Gender, DateOfBirth, isActive)VALUES ('John', 'Doe', 'Male', '1990-05-25', 1), ('Jane', 'Smith', 'Female', '1985-11-12', 1), ('Michael', 'Johnson', 'Male', '1978-08-18', 1), ('Emily', 'Brown', 'Female', '1995-03-30', 1), ('Daniel', 'Wilson', 'Male', '1983-09-08', 1), ('Emma', 'Taylor', 'Female', '1992-06-15', 1), ('David', 'Martinez', 'Male', '1989-12-05', 1), ('Olivia', 'Garcia', 'Female', '1976-04-22', 1), ('James', 'Lopez', 'Male', '1998-07-10', 1), ('Sophia', 'Lee', 'Female', '1980-10-28', 1);



For MySQL

CREATE TABLE `db_training`.`tbl_student` (
  `idTBL_Student` INT NOT NULL AUTO_INCREMENT,
  `FirstName` VARCHAR(45) NULL,
  `LastName` VARCHAR(45) NULL,
  `Gender` VARCHAR(45) NULL,
  `DateOfBirth` DATE NULL,
  `isActive` TINYINT NULL,
  PRIMARY KEY (`idTBL_Student`));

INSERT INTO `tbl_student` (`FirstName`, `LastName`, `Gender`, `DateOfBirth`, `isActive`)VALUES ('John', 'Doe', 'Male', '1990-05-25', 1), ('Jane', 'Smith', 'Female', '1985-11-12', 1), ('Michael', 'Johnson', 'Male', '1978-08-18', 1), ('Emily', 'Brown', 'Female', '1995-03-30', 1), ('Daniel', 'Wilson', 'Male', '1983-09-08', 1), ('Emma', 'Taylor', 'Female', '1992-06-15', 1), ('David', 'Martinez', 'Male', '1989-12-05', 1), ('Olivia', 'Garcia', 'Female', '1976-04-22', 1), ('James', 'Lopez', 'Male', '1998-07-10', 1), ('Sophia', 'Lee', 'Female', '1980-10-28', 1);
