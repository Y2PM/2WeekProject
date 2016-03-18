IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Game]') AND type in (N'U'))
DROP TABLE [dbo].[Game]
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Member]') AND type in (N'U'))
DROP TABLE [dbo].[Member]

CREATE TABLE Game
(
game_id INT IDENTITY(1,1) PRIMARY KEY,
name VARCHAR(50),
payout DECIMAL
);

CREATE TABLE Member
(
member_id INT IDENTITY(1,1) PRIMARY KEY,
m_name VARCHAR(50),
m_username VARCHAR(50),
m_password VARCHAR(50),
m_account DECIMAL
);

INSERT INTO Game (name) VALUES ('Decathon');
INSERT INTO Game (payout) VALUES (10);
INSERT INTO Member (m_username) VALUES ('James');
INSERT INTO Member (m_username) VALUES ('ragingbull');
INSERT INTO Member (m_password) VALUES ('password123');
INSERT INTO Member (m_account) VALUES (0.0);
