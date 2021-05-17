CREATE TABLE users (
    id int unsigned NOT NULL AUTO_INCREMENT,
    name varchar(255) NOT NULL,
    email varchar(255) NOT NULL,
    password varchar(255) NOT NULL,

    PRIMARY KEY (id)
);

CREATE TABLE products (
    id int unsigned NOT NULL AUTO_INCREMENT,
    name varchar(255) NOT NULL,
    barcode varchar(255) NOT NULL,
    price double NOT NULL DEFAULT 0,
    
    PRIMARY KEY (id)
);

CREATE TABLE stock (
    id int unsigned NOT NULL AUTO_INCREMENT,
    quantity int NOT NULL,
    product_id int unsigned NOT NULL,

    PRIMARY KEY (id),
    FOREIGN KEY (product_id) REFERENCES products(id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);