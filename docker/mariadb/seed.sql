CREATE TABLE mydb.mytable (
	id int NULL AUTO_INCREMENT,
	title varchar(100) NULL,
	PRIMARY KEY (id)
)
ENGINE=InnoDB
DEFAULT CHARSET=utf8
COLLATE=utf8_general_ci;

INSERT INTO mydb.mytable (title) VALUES ('test 1');
INSERT INTO mydb.mytable (title) VALUES ('test 2');
INSERT INTO mydb.mytable (title) VALUES ('test 3');