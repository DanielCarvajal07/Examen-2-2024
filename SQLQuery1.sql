create database examen2024
go

use examen2024
go


CREATE TABLE pruebas(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Edad INT,
    Correo VARCHAR(100),
    Carro VARCHAR(50)
);
go 

alter table pruebas
add FechaNacimiento date;







