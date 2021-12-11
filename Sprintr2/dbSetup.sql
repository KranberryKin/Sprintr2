CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';


CREATE TABLE IF NOT EXISTS projects(
  id int NOT NULL AUTO_INCREMENT PRIMARY KEY COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name VARCHAR(255),
  description VARCHAR(255),
  creatorId VARCHAR(255) NOT NULL,
  FOREIGN KEY (creatorId) REFERENCES accounts(id)
) default charset utf8 COMMENT '';
DROP TABLE projects;

CREATE TABLE IF NOT EXISTS sprints(
  id int NOT NULL AUTO_INCREMENT PRIMARY KEY COMMENT 'primary key',
  name VARCHAR(255) NOT NULL,
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  startDate DATETIME,
  endDate DATETIME,
  projectId int,
  creatorId VARCHAR(255) NOT NULL,
  isOpen TINYINT NOT NULL DEFAULT 1,
  FOREIGN KEY (projectId) REFERENCES projects(id),
  FOREIGN KEY (creatorId) REFERENCES accounts(id)
) default charset utf8 COMMENT '';
CReATE TABLE IF NOT EXISTS backlogitems(
  id int NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name VARCHAR(255),
  description VARCHAR(255),
  status VARCHAR(255) NOT NULL DEFAULT 'Pending',
  projectId int NOT NULL,
  sprintId int,
  creatorId VARCHAR(255) NOT NULL,
  FOREIGN KEY (projectId) REFERENCES projects(id),
  FOREIGN KEY (sprintId) REFERENCES sprints(id),
  FOREIGN Key (creatorId) REFERENCES accounts(id)
) default charset utf8 COMMENT '';


CREATE TABLE IF NOT EXISTS notes(
  id int NOT NULL AUTO_INCREMENT PRIMARY KEY COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  body VARCHAR(255),
  backlogitemId int,
  projectId int,
  creatorId VARCHAR(255),
  FOREIGN KEY (backlogitemId) REFERENCES backlogitems(id),
  FOREIGN KEY (projectId) REFERENCES projects(id),
  FOREIGN KEY (creatorId) REFERENCES accounts(id)
) default charset utf8 COMMENT '';


CREATE TABLE IF NOT EXISTS tasks(
  id int NOT NULL AUTO_INCREMENT PRIMARY KEY COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name VARCHAR(255),
  weight int,
  projectId int,
  backlogitemId int,
  creatorId VARCHAR(255),
  isComplete TINYINT NOT NULL DEFAULT 0,
  completedOn DATETIME,
  FOREIGN KEY (projectId) REFERENCES projects(id),
  FOREIGN KEY (backlogitemId) REFERENCES backlogitems(id),
  FOREIGN KEY (creatorId) REFERENCES accounts(id)
) default charset utf8 COMMENT '';
DROP TABLE tasks;