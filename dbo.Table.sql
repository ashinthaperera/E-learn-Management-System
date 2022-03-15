CREATE TABLE [dbo].[Document]
(
	[StudentID] INT NOT NULL , 
    [CourseName] VARCHAR(50) NOT NULL, 
    [Data] VARBINARY(MAX) NOT NULL, 
    [Extension] CHAR(10) NOT NULL, 
    [FileName] VARCHAR(100) NOT NULL, 
    [SubmissionOrderID] INT NOT NULL IDENTITY(1,1), 
    CONSTRAINT [PK_Document] PRIMARY KEY ([SubmissionOrderID])
)
