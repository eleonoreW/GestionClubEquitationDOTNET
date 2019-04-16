DROP PROCEDURE IF EXISTS [dbo].[Cheval_UpdateSearchString]
GO
DROP PROCEDURE IF EXISTS [dbo].[Activite_UpdateSearchString]
GO
DROP TRIGGER IF EXISTS [dbo].[Activite_Trigger_Update]
GO
DROP TRIGGER IF EXISTS [dbo].[Cheval_Trigger_Update]
GO
CREATE PROCEDURE [dbo].[Cheval_UpdateSearchString]
    @ID INTEGER
AS
BEGIN
    UPDATE Cheval SET  
	Cheval.SearchString = Cheval.Nom + ' ' + Cheval.Descriptif + ' ' + Cheval.Commentaire + ' ' + Race.Nom + ' ' + AspNetUsers.UserName
	FROM Cheval 
	INNER JOIN Race ON Cheval.RaceID = Race.ID
	INNER JOIN AspNetUsers ON Cheval.ProprietaireID = AspNetUsers.Id
	WHERE Cheval.ID = @ID 
END
GO

CREATE PROCEDURE [dbo].[Activite_UpdateSearchString]
    @ID INTEGER
AS
BEGIN
    UPDATE Activite SET  
	Activite.SearchString = Activite.Nom + ' ' + Activite.Commentaire + ' ' + Lieu.Nom +' ' + Type.Nom + ' ' + AspNetUsers.UserName + ' ' + Activite.Details
	FROM Activite 
	INNER JOIN AspNetUsers ON Activite.ProfesseurID = AspNetUsers.Id
	INNER JOIN Lieu ON Activite.LieuID = Lieu.ID
	INNER JOIN Type ON Activite.TypeID = Type.ID
	WHERE Activite.ID = @ID 
END
GO



CREATE TRIGGER [dbo].[Activite_Trigger_Update]
	ON Activite
	AFTER  INSERT, UPDATE
AS
BEGIN
DECLARE @ID int
	set @ID =(SELECT ID FROM Inserted)
	EXEC [dbo].[Activite_UpdateSearchString] @ID
END
GO

CREATE TRIGGER [dbo].[Cheval_Trigger_Update]
	ON Cheval
	AFTER  INSERT, UPDATE
AS
BEGIN
DECLARE @ID int
	set @ID =(SELECT ID FROM Inserted)
	EXEC [dbo].[Cheval_UpdateSearchString] @ID
END
GO