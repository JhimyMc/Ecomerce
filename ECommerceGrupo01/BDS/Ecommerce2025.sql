-- =============================================
-- Script: Inserts de productos (Zapatillas)
-- Base de datos: ECommerceDb
-- =============================================

INSERT INTO Products (Name, Price, Stock, Description, ImagePath)
VALUES ('Nike Air Max 90', 459.90, 25, 'El icónico Air Max 90 con amortiguación visible Air-Sole. Diseño atemporal que combina estilo y comodidad para el día a día.', '/images/airmax90.jpg');

INSERT INTO Products (Name, Price, Stock, Description, ImagePath)
VALUES ('Adidas Ultraboost 22', 699.90, 18, 'Zapatillas de running con tecnología BOOST para máxima energía y retorno. Malla Primeknit transpirable y suela Continental.', '/images/ultraboost22.jpg');

INSERT INTO Products (Name, Price, Stock, Description, ImagePath)
VALUES ('Nike Dunk Low Retro', 389.90, 30, 'El clásico Dunk renacido. Diseño retro de baloncesto con cuero premium y colorways que no pasan de moda.', '/images/dunklow.jpg');

INSERT INTO Products (Name, Price, Stock, Description, ImagePath)
VALUES ('New Balance 550 White Green', 429.90, 22, 'Retro running estilo vintage con cuero blanco y detalles en verde. Silueta cómoda y versátil para cualquier outfit.', '/images/nb550.jpg');

INSERT INTO Products (Name, Price, Stock, Description, ImagePath)
VALUES ('Jordan 1 Mid SE', 549.90, 15, 'La silueta más icónica de Jordan Brand en versión Mid. Cuero de alta calidad con el logo Wings y suela de goma.', '/images/jordan1mid.jpg');

INSERT INTO Products (Name, Price, Stock, Description, ImagePath)
VALUES ('Puma Suede Classic XXI', 329.90, 35, 'Un clásico atemporal del streetwear. Cuero gamuza premium con la franja lateral icónica y suela de goma duradera.', '/images/pumasuede.jpg');

INSERT INTO Products (Name, Price, Stock, Description, ImagePath)
VALUES ('Converse Chuck 70 High', 349.90, 40, 'La versátil Chuck Taylor renovada con tecnología OrthoLite y canvas de mayor durabilidad. Estilo que nunca falla.', '/images/chuck70.jpg');

INSERT INTO Products (Name, Price, Stock, Description, ImagePath)
VALUES ('Asics Gel-Kayano 30', 729.90, 12, 'Máxima estabilidad y amortiguación con tecnología GEL y FF BLAST+. Ideal para corredores que necesitan soporte.', '/images/kayano30.jpg');


INSERT INTO Products (Name, Price, Stock, Description, ImagePath)
VALUES ('Under Armour HOVR Phantom 3', 649.90, 16, 'Zapatillas de running con tecnología UA HOVR que devuelve la energía en cada zancada. Malla de soporte y suela de goma duradera.', '/images/hovrphantom3.jpg');

INSERT INTO Products (Name, Price, Stock, Description, ImagePath)
VALUES ('Fila Disruptor 2 Premium', 399.90, 28, 'El clásico chunky de los 90s regresado con fuerza. Suela platform extra alta con el logo Fila bordado y acolchado cómodo.', '/images/disruptor2.jpg');

INSERT INTO Products (Name, Price, Stock, Description, ImagePath)
VALUES ('Reebok Club C 85 Vintage', 379.90, 32, 'Minimalismo y elegancia en cuero blanco premium. Plantilla OrthoLite y suela de goma con detalles vintage que enamoran.', '/images/clubc85.jpg');

INSERT INTO Products (Name, Price, Stock, Description, ImagePath)
VALUES ('Vans Old Skool Classic', 299.90, 45, 'La silueta Vans original con la icónica franja lateral jazz stripe. Canvas y gamuza con suela waffle para máximo grip.', '/images/oldskool.jpg');

INSERT INTO Products (Name, Price, Stock, Description, ImagePath)
VALUES ('Adidas Superstar Foundation', 459.90, 20, 'El ícono del calzado urbano desde 1969. Coraza de concha protectora, cuero liso y las 3 franjas clásicas que nunca fallan.', '/images/superstar.jpg');

INSERT INTO Products (Name, Price, Stock, Description, ImagePath)
VALUES ('Salomon XT-6 Advanced', 849.90, 10, 'Trail running de alta gama con tecnología Advanced Chassis y suela Contagrip MA. Diseño futurista resistente al agua.', '/images/xt6.jpg');


SELECT * FROM Products;

SELECT * FROM Orders;
