ALTER TABLE Cheval DROP CONSTRAINT IF EXISTS Cheval_FK_Race;
ALTER TABLE Cheval DROP CONSTRAINT IF EXISTS Cheval_FK_Proprietaire;
ALTER TABLE Reservation DROP CONSTRAINT IF EXISTS Reservation_FK_Utilisateur;
ALTER TABLE Reservation DROP CONSTRAINT IF EXISTS Reservation_FK_Activite;
ALTER TABLE Activite DROP CONSTRAINT IF EXISTS Activite_FK_Type;
ALTER TABLE Activite DROP CONSTRAINT IF EXISTS Activite_FK_Lieu;
ALTER TABLE Activite DROP CONSTRAINT IF EXISTS Activite_FK_Professeur;
ALTER TABLE Cheval_Activite DROP CONSTRAINT IF EXISTS ChevalActivite_FK_Cheval;
ALTER TABLE Cheval_Activite DROP CONSTRAINT IF EXISTS ChevalActivite_FK_Activite;

DROP TABLE IF EXISTS Type;
DROP TABLE IF EXISTS Race;
DROP TABLE IF EXISTS Lieu;
DROP TABLE IF EXISTS Activite;
DROP TABLE IF EXISTS Reservation;
DROP TABLE IF EXISTS Cheval;
DROP TABLE IF EXISTS Cheval_Activite;


--CREATE TABLE Utilisateur (ID int NOT NULL IDENTITY(1,1), Prenom varchar(255), Nom varchar(255), Mail varchar(255) UNIQUE, MotDePasse varchar(255) NOT NULL, Telephone varchar(255), DateNaissance date NOT NULL, SearchString varchar(255) DEFAULT '', PRIMARY KEY (ID));
CREATE TABLE Type (ID int NOT NULL IDENTITY(1,1), Nom varchar(255) UNIQUE, Descriptif varchar(255), PRIMARY KEY (ID));
CREATE TABLE Race (ID int NOT NULL IDENTITY(1,1), Nom varchar(255) UNIQUE, PRIMARY KEY (ID));
CREATE TABLE Lieu (ID int NOT NULL IDENTITY(1,1), Nom varchar(255) UNIQUE, Capacite int NOT NULL, Descriptif varchar(255), PRIMARY KEY (ID));
CREATE TABLE Activite (ID int NOT NULL IDENTITY(1,1), ProfesseurID nvarchar(450) NOT NULL, LieuID int NOT NULL, TypeID int NOT NULL, Nom varchar(255), Commentaire varchar(255), Details varchar(255), Date date NOT NULL, Duree int NOT NULL, Capacite int NOT NULL, EstActive BIT NOT NULL, SearchString varchar(255) DEFAULT '', PRIMARY KEY (ID));
CREATE TABLE Reservation (ID int NOT NULL IDENTITY(1,1), Date date NOT NULL, NbPersonne int NOT NULL, EstActive BIT NOT NULL, UtilisateurID nvarchar(450) NOT NULL, ActiviteID int NOT NULL, SearchString varchar(255) DEFAULT '', PRIMARY KEY (ID));
CREATE TABLE Cheval (ID int NOT NULL IDENTITY(1,1), ProprietaireID nvarchar(450) NOT NULL, RaceID int NOT NULL, Nom varchar(255) NOT NULL UNIQUE, DateNaissance Date NOT NULL, Descriptif varchar(255), Commentaire varchar(255), NbHeureMaxSemaine int NOT NULL, Taille int NOT NULL, SearchString varchar(255) DEFAULT '', PRIMARY KEY (ID));
CREATE TABLE Cheval_Activite (ChevalID int NOT NULL, ActiviteID int NOT NULL, PRIMARY KEY (ChevalID, ActiviteID));

ALTER TABLE Cheval ADD CONSTRAINT Cheval_FK_Race FOREIGN KEY (RaceID) REFERENCES Race (ID);
ALTER TABLE Cheval ADD CONSTRAINT Cheval_FK_Proprietaire FOREIGN KEY (ProprietaireID) REFERENCES AspNetUsers (ID);
ALTER TABLE Reservation ADD CONSTRAINT Reservation_FK_Utilisateur FOREIGN KEY (UtilisateurID) REFERENCES AspNetUsers (ID);
ALTER TABLE Reservation ADD CONSTRAINT Reservation_FK_Activite FOREIGN KEY (ActiviteID) REFERENCES Activite (ID);
ALTER TABLE Activite ADD CONSTRAINT Activite_FK_Type FOREIGN KEY (TypeID) REFERENCES Type (ID);
ALTER TABLE Activite ADD CONSTRAINT Activite_FK_Lieu FOREIGN KEY (LieuID) REFERENCES Lieu (ID);
ALTER TABLE Activite ADD CONSTRAINT Activite_FK_Professeur FOREIGN KEY (ProfesseurID) REFERENCES AspNetUsers (ID);
ALTER TABLE Cheval_Activite ADD CONSTRAINT ChevalActivite_FK_Cheval FOREIGN KEY (ChevalID) REFERENCES Cheval (ID);
ALTER TABLE Cheval_Activite ADD CONSTRAINT ChevalActivite_FK_Activite FOREIGN KEY (ActiviteID) REFERENCES Activite (ID);

