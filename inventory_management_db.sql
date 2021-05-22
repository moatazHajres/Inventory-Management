CREATE TABLE users (
    id int unsigned NOT NULL AUTO_INCREMENT,
    name varchar(255) NOT NULL UNIQUE,
    email varchar(255) NOT NULL,
    password varchar(255) NOT NULL,

    PRIMARY KEY (id)
) ENGINE=InnoDB;

CREATE TABLE products (
    id int unsigned NOT NULL AUTO_INCREMENT,
    name varchar(255) NOT NULL,
    barcode varchar(255) NOT NULL,
    price double NOT NULL DEFAULT 0,
    
    PRIMARY KEY (id)
) ENGINE=InnoDB;

CREATE TABLE stock (
    id int unsigned NOT NULL AUTO_INCREMENT,
    quantity int NOT NULL,
    product_id int unsigned NOT NULL,

    PRIMARY KEY (id),
    FOREIGN KEY (product_id) REFERENCES products(id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
) ENGINE=InnoDB;

-- seed some data --
INSERT INTO `users`(`name`, `email`, `password`) VALUES ('admin', 'admin@admin.com', '1156371652');

INSERT INTO `products` (`name`, `barcode`, `price`) VALUES
('Head & Shoulders Shampoo', '037000012146', 12),
('Pepsi', '024131028795', 1.5),
('Coca Cola', '049000028904', 1.5),
('Lifebuoy Soap', '6221048051623', 3),
('Oreo', '884912268396', 5),
('Al Naseem Yoghurt', '710535729672', 1),
('Spaghetti', '076808280098', 2),
('Pringles Chips', '038000138416', 9),
('La Vache Qui Rit Cheese', '3073781086652', 6),
('Snickers Chocolate', '040000501671', 2.75),
('Kinder Bueno Chocolate', '8000500073698', 4),
('Kit Kat Chocolate', '034000002290', 3);
