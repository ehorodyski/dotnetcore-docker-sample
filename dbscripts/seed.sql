\connect blogdb
CREATE TABLE blog (id serial PRIMARY KEY,
                                     title VARCHAR(50) NOT NULL,
                                                       description VARCHAR(100) NOT NULL)
ALTER TABLE "blog" OWNER to bloguser;


INSERT INTO blog(title,description)
VALUES ('Title 1',
        'Description 1');


INSERT INTO blog(title,description)
VALUES ('Title 2',
        'Description 2');


INSERT INTO blog(title,description)
VALUES ('Title 3',
        'Description 3');


INSERT INTO blog(title,description)
VALUES ('Title 4',
        'Description 4');

