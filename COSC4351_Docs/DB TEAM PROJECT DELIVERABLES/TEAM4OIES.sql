-- fn: TEAM4OIES.sql 

-- SQL COMMENTED SQL COMMANDS


/* Creating new table Audit, every changes to database must be logged into Audit. Audit table is never to be dropped or cleared*/
/*
CREATE TABLE Audit
(
  audit_id INT NOT NULL IDENTITY(1,1),
  UserID INT NOT NULL,
  username VARCHAR(45) NOT NULL,
  date DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  table_ VARCHAR(45) NOT NULL,
  attribute VARCHAR(45) NOT NULL,
  access VARCHAR(45) NOT NULL,
)
*/

/*Dropping tables, except the Audit table */
if (OBJECT_ID('Testimonial') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Testimonial', 'All', 'Dropped');
if (OBJECT_ID('Testimonial') >0 )
Drop table Testimonial;

if (OBJECT_ID('Slice') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Slice', 'All', 'Dropped');
if (OBJECT_ID('Slice') >0 )
Drop table Slice;

if (OBJECT_ID('Series') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Series', 'All', 'Dropped');
if (OBJECT_ID('Series') >0 )
Drop table Series;

if (OBJECT_ID('Study') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Study', 'All', 'Dropped');
if (OBJECT_ID('Study') >0 )
Drop table Study;

if (OBJECT_ID('Patient') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Patient', 'All', 'Dropped');
if (OBJECT_ID('Patient') >0 )
Drop table Patient;

if (OBJECT_ID('Surgeon') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Surgeon', 'All', 'Dropped');
if (OBJECT_ID('Surgeon') >0 )
Drop table Surgeon;

if (OBJECT_ID('Institution') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Institution', 'All', 'Dropped');
if (OBJECT_ID('Institution') >0 )
Drop table Institution;


if (OBJECT_ID('Endograft') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Endograft', 'All', 'Dropped');
if (OBJECT_ID('Endograft') >0 )
Drop table Endograft;


if (OBJECT_ID('Brand') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Brand', 'All', 'Dropped');
if (OBJECT_ID('Brand') >0 )
Drop table Brand;

if (OBJECT_ID('CFD') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'CFD', 'All', 'Dropped');
if (OBJECT_ID('CFD') >0 )
Drop table CFD;

/*Dropping tables, except the Audit table */
if (OBJECT_ID('CFD') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'CFD', 'All', 'Dropped');
if (OBJECT_ID('CFD') >0 )
Drop table CFD;

if (OBJECT_ID('Testimonial') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Testimonial', 'All', 'Dropped');
if (OBJECT_ID('Testimonial') >0 )
Drop table Testimonial;

if (OBJECT_ID('Slice') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Slice', 'All', 'Dropped');
if (OBJECT_ID('Slice') >0 )
Drop table Slice;

if (OBJECT_ID('Series') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Series', 'All', 'Dropped');
if (OBJECT_ID('Series') >0 )
Drop table Series;

if (OBJECT_ID('Study') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Study', 'All', 'Dropped');
if (OBJECT_ID('Study') >0 )
Drop table Study;


if (OBJECT_ID('Patient') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Patient', 'All', 'Dropped');
if (OBJECT_ID('Patient') >0 )
Drop table Patient;

if (OBJECT_ID('Surgeon') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Surgeon', 'All', 'Dropped');
if (OBJECT_ID('Surgeon') >0 )
Drop table Surgeon;

if (OBJECT_ID('Institution') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Institution', 'All', 'Dropped');
if (OBJECT_ID('Institution') >0 )
Drop table Institution;


if (OBJECT_ID('Endograft') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Endograft', 'All', 'Dropped');
if (OBJECT_ID('Endograft') >0 )
Drop table Endograft;


if (OBJECT_ID('Brand') >0 )
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Brand', 'All', 'Dropped');
if (OBJECT_ID('Brand') >0 )
Drop table Brand;




/* Creating new table Institution*/
CREATE TABLE Institution
(
 institution_id INT NOT NULL IDENTITY(1,1) Primary Key,
 institution VARCHAR(45) NOT NULL,
)
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Institution', 'All', 'Created');

/* Creating new table Surgeon*/
CREATE TABLE Surgeon
(
  userType INT NOT NULL,
  surgeonID INT NOT NULL IDENTITY(1,1) Primary Key,
  firstName VARCHAR(45) NOT NULl,
  lastName VARCHAR(45) NOT NULL,
  username VARCHAR(45) NOT NULL,
  password VARCHAR(45) NOT NULL,
  email VARCHAR(150) NOT NULL,
  institution_id INT FOREIGN KEY REFERENCES Institution(institution_id),
  online BIT NOT NULL,
  active BIT NOT NULL, 
)
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Surgeon', 'All', 'Created');

/* Creating new table Brand*/
CREATE TABLE Brand
(
   brand_id INT NOT NULL IDENTITY(1,1) Primary Key,
   brand VARCHAR(100) NOT NULL
)
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Brand', 'All', 'Created');



/* Creating new table Endograft*/
CREATE TABLE Endograft
(
  endograft_id INT NOT NULL IDENTITY(1,1) Primary Key,
  dateOfSurgery DATETIME NOT NULL,
  diameter FLOAT NOT NULL,
  length FLOAT NOT NULL,
  unilateralLegDiameter FLOAT NOT NULL,
  unilateralLegLength FLOAT NOT NULL,
  controlaterLegDiameter FLOAT NOT NULL,
  controlaterLegLength FLOAT NOT NULL,
  entryPoint FLOAT NOT NULL,
  brand_id INT NOT NULL FOREIGN KEY REFERENCES Brand(brand_id)
)
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Endograft', 'All', 'Created');

/*Creating new table Patient*/
/*Removed::  FOREIGN KEY REFERENCES Endograft(endograft_id)*/
CREATE TABLE Patient
(
patient_id INT NOT NULL IDENTITY(1,1) Primary Key,
originalID INT NOT NULL,
sex nvarchar(50) NOT NULL,
age INT NOT NULL,
entryDate DATETIME NOT NULL,
surgeonID INT FOREIGN KEY REFERENCES Surgeon(surgeonID),
endograft_id INT
)
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Patient', 'All', 'Created');


/* Creating new table Study*/
CREATE TABLE Study
(
  study_id INT NOT NULL IDENTITY(1,1) Primary Key,
  originalID INT NOT NULL,
  description VARCHAR(100) NOT NULL,
  modality VARCHAR(45) NOT NULL,
  date DATETIME NOT NULL,
  time INT NOT NULL,
  referringPhysician VARCHAR(45) NOT NULL,
  additionalPatientHistory VARCHAR(45) NOT NULL,
  patient_id INT NOT NULL FOREIGN KEY REFERENCES Patient(patient_id)
)
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Study', 'All', 'Created');



/* Creating new table Series*/
CREATE TABLE Series
(
  series_id INT NOT NULL IDENTITY(1,1) Primary Key,
  originalSeriesID INT NOT NULL,
  description VARCHAR(100) NOT NULL,
  entryDate DATETIME NOT NULL,
  study_id INT NOT NULL FOREIGN KEY REFERENCES Study(study_id)
)
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Series', 'All', 'Created');


/* Creating new table Slice*/
CREATE TABLE Slice
(
  slice_id INT NOT NULL IDENTITY(1,1) Primary Key,
  inOrder INT NOT NULL,
  filename VARCHAR(45) NOT NULL,
  title VARCHAR(45) NOT NULL,
  width FLOAT NOT NULL,
  height FLOAT NOT NULL,
  resolution FLOAT NOT NULL,
  thickness FLOAT NOT NULL,
  coordinateOrigin INT NOT NULL,
  bitsPerPixel FLOAT NOT NULL,
  displayRange FLOAT NOT NULL,
  fullMetaData VARCHAR(45) NOT NULL,
  entryDate DATETIME NOT NULL,
  series_id INT NOT NULL FOREIGN KEY REFERENCES Series(series_id),
)
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Slice', 'All', 'Created');


/* Creating new table Testimonial*/
CREATE TABLE Testimonial
(
  TestimonialID INT NOT NULL IDENTITY(1,1) Primary Key,
  content VARCHAR(120) NOT NULL,
  tDate DATETIME NOT NULL,
  surgeonID INT NOT NULL FOREIGN KEY REFERENCES Surgeon(surgeonID)
)
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Testimonial', 'All', 'Created');

/* Creating new table CFD*/
CREATE TABLE CFD
(
  CFD_id INT NOT NULL IDENTITY(1,1) Primary Key,
  CurrentDate DATETIME NOT NULL,
  Done BIT NOT NULL,
  patientID INT NOT NULL FOREIGN KEY REFERENCES Patient(patient_id)  
)
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'CFD', 'All', 'Created');

/*Pre-Loaded Values*/
/*Institutions*/
INSERT INTO Institution(institution) VALUES('Methodist');
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Surgeon', 'All', 'Institution');
INSERT INTO Institution(institution) VALUES('Strassbourg');
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Surgeon', 'All', 'Institution');
INSERT INTO Institution(institution) VALUES('London');
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Surgeon', 'All', 'Institution');
INSERT INTO Institution(institution) VALUES('Gainsville');
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Surgeon', 'All', 'Institution');
/*Users*/
INSERT INTO Surgeon(userType,firstName,lastName,username,password,email,institution_id,online,active)
	VALUES(1,'First','Surgeon','Surgeon1','Surgeon1#','TEAM4OIESSurgeon1@gmail.com',1,0,0);
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Surgeon', 'All', 'Insert');
INSERT INTO Surgeon(userType,firstName,lastName,username,password,email,online,active)
	VALUES(2,'First','Auditor','OIESA','OIESA#','TEAM4OIESSurgeon1@gmail.com',0,0);
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Surgeon', 'All', 'Insert');
INSERT INTO Surgeon(userType,firstName,lastName,username,password,email,online,active)
	VALUES(3,'Customer','Service','OIESCS','OIESCS#','TEAM4OIESSurgeon1@gmail.com',0,0);
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Surgeon', 'All', 'Insert');
/*Testimonial*/
INSERT INTO Testimonial(content,tDate,SurgeonID)
	VALUES('I really like TEAM4OIES Online Anonymized EVAR System!','2015-04-28 00:00:00',1);
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Testimonial', 'All', 'Insert');
INSERT INTO Testimonial(content,tDate,SurgeonID)
	VALUES('I believe that the future Users will like TEAM4OIES.','2015-04-28 00:00:00',1);
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Testimonial', 'All', 'Insert');
/*Brand*/
INSERT INTO Brand(brand) VALUES('Cook');
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Brand', 'All', 'Insert');
INSERT INTO Brand(brand) VALUES('Boston Scientific');
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Brand', 'All', 'Insert');
INSERT INTO Brand(brand) VALUES('Medtronic');
INSERT INTO Audit(UserID, username, table_, attribute, access) VALUES(4, 'TEAM4OIES', 'Brand', 'All', 'Insert');
GO
---DROP TRIGGER cfdEmailTrigger
CREATE TRIGGER cfdEmailTrigger
ON CFD 
FOR INSERT 
AS
EXEC msdb.dbo.sp_send_dbmail @profile_name='smtps',
@recipients='TEAM4OIESSurgeon1@gmail.com',
@subject='Test message TEAM4OIES',
@body='Data for your patient has been added to the database.'
/*
Maintenence Documentation: What,Why,By whom, When

Started to add tables
April 09 2015
DBA: Jainesh Mehta: .


added all the tables
DBA: Jainesh Mehta
April 10 2015

Remove DROP TABLE audit command, and TEAM? to TEAM4.
DBA Logan Stark
April 10, 2015

Fixed errors as SQAs suggested.
DBA: Jainesh Mehta
April 15 2015


Added reference in Patient for Endograft using endograft_id. 
Endograft table wasn't connected to Patient table
DBA: Logan Stark
April 22 2015

Added auto incrementation to IDs.
DBA: Jainesh Mehta
April 25, 2015

Added 'thickness' to 'Slices' table & pre-loaded data
DBA Logan Stark
April 28, 2015

Made more additions for Acceptance Testing
DBA Logan Stark
April 29, 2015
*/

