--GetPosts all
SELECT P.PostID, P.Title, P.ImageURL, P.PostText, P.Creator, P.[Timestamp] 
FROM POST_TABLE AS P
JOIN AspNetUsers AS A ON A.UserName = P.Creator
ORDER BY p.[Timestamp];

--GetPost by page
SELECT * FROM TableName ORDER BY id OFFSET 10 ROWS FETCH NEXT 10 ROWS ONLY;

SELECT P.PostID, P.Title, P.ImageURL, P.PostText, P.Creator, P.[Timestamp] 
FROM POST_TABLE AS P
JOIN AspNetUsers AS A 
	ON A.UserName = P.Creator
ORDER BY p.[Timestamp]
OFFSET 10 ROWS
FETCH NEXT 10 ROWS ONLY;

ALTER TABLE dbo.Post_Table
   ADD PostID IDENTITY

--InsertPost
INSERT INTO Post_Table (Title, ImageURL, PostText, Creator)
VALUES ('Title 1', 'https://testcreative.co.uk/wp-content/uploads/2017/10/Test-Logo-Circle-black-transparent.png', 'Post Text 1', 'Creator1');

CREATE PROCEDURE InsertPost
(
	@Title NVARCHAR(500),
	@ImageURL NVARCHAR(500),
	@PostText NVARCHAR(2500),
	@Creator NVARCHAR(200)
)
AS
BEGIN
	INSERT INTO Post_Table (Title, ImageURL, PostText, Creator) VALUES (@Title, @ImageURL, @PostText, @Creator)
END;

EXEC InsertPost 'Title 2', 'http://24eastmain.com/wp-content/uploads/2017/08/test.jpg', 'Post Text 2', 'Creator1';


CREATE TABLE "Post_Table" (
	"PostID" INT NOT NULL IDENTITY,
	"Title" NVARCHAR(500) NOT NULL,
	"ImageURL" NVARCHAR(500) NULL DEFAULT '',
	"PostText" NVARCHAR(2500) NULL DEFAULT '',
	"Creator" NVARCHAR(200) NULL DEFAULT NULL,
	"Timestamp" DATETIME NOT NULL DEFAULT GETDATE(),
	PRIMARY KEY ("PostID")
)
;
