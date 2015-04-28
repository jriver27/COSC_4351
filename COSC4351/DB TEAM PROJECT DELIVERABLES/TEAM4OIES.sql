-- fn: TEAM4OIES.sql 

-- SQL COMMENTED SQL COMMANDS


/* Creating new table Audit, every changes to database must be logged into Audit. Audit table is never to be dropped or cleared*/
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
CREATE TABLE Patient
(
patient_id INT NOT NULL IDENTITY(1,1) Primary Key,
originalID INT NOT NULL,
sex nvarchar(50) NOT NULL,
age DATETIME NOT NULL,
entryDate DATETIME NOT NULL,
surgeonID INT FOREIGN KEY REFERENCES Surgeon(surgeonID),
endograft_id INT FOREIGN KEY REFERENCES Endograft(endograft_id)
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
*/

