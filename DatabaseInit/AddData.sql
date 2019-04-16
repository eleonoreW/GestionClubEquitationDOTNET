INSERT INTO Type (Nom, Descriptif) VALUES ('Randonnée', 'Rando en forêt avec les fées');
INSERT INTO Type (Nom, Descriptif) VALUES ('Promenade au bord de l''eau', 'Attention ça glisse');
INSERT INTO Type (Nom, Descriptif) VALUES ('AquaPoney', 'Eh salut les filles, bienvenue au cours d''aquaponey !');
INSERT INTO Type (Nom, Descriptif) VALUES ('Cours galop', 'Cours pour passer les galops');
INSERT INTO Race (Nom) VALUES ('Appaloosa');
INSERT INTO Race (Nom) VALUES ('Shetland');
INSERT INTO Race (Nom) VALUES ('Curly');
INSERT INTO Race (Nom) VALUES ('Akhal-Teke');
INSERT INTO Race (Nom) VALUES ('Andalou');
INSERT INTO Race (Nom) VALUES ('Camarguais');
INSERT INTO Race (Nom) VALUES ('Anglo-Arabe');
INSERT INTO Race (Nom) VALUES ('Hackney');
INSERT INTO Race (Nom) VALUES ('Hanovrien');
INSERT INTO Race (Nom) VALUES ('Furioso');
INSERT INTO Race (Nom) VALUES ('Hunter');
INSERT INTO Race (Nom) VALUES ('Morgan');
INSERT INTO Race (Nom) VALUES ('Mustang');
INSERT INTO Race (Nom) VALUES ('Trotteur');


INSERT INTO Lieu(Nom, Capacite, Descriptif) VALUES ('Pré Nord', 2, null);
INSERT INTO Lieu(Nom, Capacite, Descriptif) VALUES ('Pré-Jean', 4, null);
INSERT INTO Lieu(Nom, Capacite, Descriptif) VALUES ('Manège A', 8, null);
INSERT INTO Lieu(Nom, Capacite, Descriptif) VALUES ('Manège B', 6, 'Priorité aux poneys');
INSERT INTO Lieu(Nom, Capacite, Descriptif) VALUES ('Forêt Secteur Ouest', 5, null);
INSERT INTO Lieu(Nom, Capacite, Descriptif) VALUES ('Forêt Secteur Nord', 7, null);
INSERT INTO Lieu(Nom, Capacite, Descriptif) VALUES ('Rivière', 6, null);
INSERT INTO Lieu(Nom, Capacite, Descriptif) VALUES ('Pré Ouest', 4, null);

INSERT INTO Cheval(ProprietaireID, RaceID, Nom, DateNaissance, Descriptif, Commentaire, NbHeureMaxSemaine, Taille) VALUES ( '0277aaa9-d512-4555-bfc9-96eb2d993d0e', 2, 'Crêpe', '2014-06-08', 'Aime le sucre', 'Boiteux', 6, 160);
INSERT INTO Cheval(ProprietaireID, RaceID, Nom, DateNaissance, Descriptif, Commentaire, NbHeureMaxSemaine, Taille) VALUES ( '5bc4f71a-f6d6-4d5a-8166-75510ed7cf2a', 1, 'Brownie', '2001-09-05', 'Aime les carottes', 'Aimable', 5, 170);
INSERT INTO Cheval(ProprietaireID, RaceID, Nom, DateNaissance, Descriptif, Commentaire, NbHeureMaxSemaine, Taille) VALUES ( '0277aaa9-d512-4555-bfc9-96eb2d993d0e', 3, 'Cookie', '2016-11-03', 'Aime les graines', 'Pas sympa :(', 15, 175);
INSERT INTO Cheval(ProprietaireID, RaceID, Nom, DateNaissance, Descriptif, Commentaire, NbHeureMaxSemaine, Taille) VALUES ( '0277aaa9-d512-4555-bfc9-96eb2d993d0e', 4, 'Pepito', '2018-10-15', 'Aime la viande', 'Sale', 15, 165);



INSERT INTO Activite(LieuID, ProfesseurID, TypeID, Nom, Commentaire, Details, Date, Duree, Capacite, EstActive) VALUES (8, '0277aaa9-d512-4555-bfc9-96eb2d993d0e', 2, 'Promenade au bord de l''eau', 'Tout c''est bien passé', 'RDV au centre equestre', '2019-01-05', 5, 4, 1);
INSERT INTO Activite(LieuID, ProfesseurID, TypeID, Nom, Commentaire, Details, Date, Duree, Capacite, EstActive) VALUES (6, '0277aaa9-d512-4555-bfc9-96eb2d993d0e', 1, 'Randonnée en forêt', '', 'Prévoir un K-Way', '2019-05-10', 4, 3, 1);
INSERT INTO Activite(LieuID, ProfesseurID, TypeID, Nom, Commentaire, Details, Date, Duree, Capacite, EstActive) VALUES (4, '0277aaa9-d512-4555-bfc9-96eb2d993d0e', 4, 'Cours pour galop 5', '', 'Prevoir le matériel necessaire', '2019-04-04', 6, 10, 1);

INSERT INTO Reservation(Date, NbPersonne, EstActive, UtilisateurID, ActiviteID) VALUES ('2019-03-10', 2, 1, '0277aaa9-d512-4555-bfc9-96eb2d993d0e', 2);
INSERT INTO Reservation(Date, NbPersonne, EstActive, UtilisateurID, ActiviteID) VALUES ('2019-02-15', 1, 1, '0277aaa9-d512-4555-bfc9-96eb2d993d0e', 2);
INSERT INTO Reservation(Date, NbPersonne, EstActive, UtilisateurID, ActiviteID) VALUES ('2019-04-12', 2, 1, '0277aaa9-d512-4555-bfc9-96eb2d993d0e', 1);
INSERT INTO Reservation(Date, NbPersonne, EstActive, UtilisateurID, ActiviteID) VALUES ('2019-05-01', 1, 1, '0277aaa9-d512-4555-bfc9-96eb2d993d0e', 3);



INSERT INTO Cheval_Activite(ChevalID, ActiviteID) VALUES (1, 1);
INSERT INTO Cheval_Activite(ChevalID, ActiviteID) VALUES (2, 1);
INSERT INTO Cheval_Activite(ChevalID, ActiviteID) VALUES (3, 1);
