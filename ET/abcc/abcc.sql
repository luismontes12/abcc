-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 21-12-2023 a las 15:00:23
-- Versión del servidor: 8.0.17
-- Versión de PHP: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `abcc`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `alta_com` (IN `sk` INT, IN `arti` VARCHAR(15), IN `mar` VARCHAR(20), IN `model` VARCHAR(20), IN `dep` INT(1), IN `clas` INT(2), IN `fam` INT(3), IN `falt` DATE, IN `sto` INT(9), IN `cant` INT(9), IN `descont` INT(1), IN `fbaj` DATE)  BEGIN
    DECLARE exis_regi INT;

    SELECT COUNT(*) INTO exis_regi
    FROM articulos
    WHERE articulos.Sku = sk;


    IF exis_regi = 0 THEN
        INSERT INTO articulos(Sku,Articulos,Modelo,Marca,Depart,Clase,Familia,Fech_alt,Stock,Cant, Descon,Fech_baj)
        VALUES (sk,arti,mar,model,dep,clas,fam,falt,sto,cant,descont,fbaj);
        SELECT 'Articulo agregado.' AS mensaje;
    ELSE
        SELECT 'Ya existe un registro con este SKU.' AS mensaje;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `baja` (`sk` INT)  DELETE FROM articulos WHERE articulos.Sku=sk$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `cambio` (`sk` INT(6), `art` VARCHAR(15), `mar` VARCHAR(15), `model` VARCHAR(20), `dep` INT(1), `clas` INT(1), `fam` INT(1), `falt` DATE, `sto` INT(9), `cant` INT(9), `des` INT(1), `fbaj` DATE)  UPDATE articulos SET articulos.Articulo=art, articulos.Marca=mar, articulos.Modelo=model, articulos.Departamento=dep, articulos.Clase=clas, articulos.Familia=fam,articulos.Fecha_alta=falt, articulos.Stock=sto, articulos.Cantidad=cant, articulos.Descontinuado=des, articulos.Fecha_baja=fbaj WHERE articulos.Sku=sk$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrar` (`sk` INT)  SELECT * FROM articulos WHERE sk=articulos.Sku$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `seleclas` ()  SELECT * FROM clase$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `seledep` ()  SELECT * FROM departamento$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `selefam` ()  SELECT * FROM familia$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `validacion_dep` (IN `id` INT)  SELECT departamento.id_dep,clase.id_dep,familia.id_clas FROM departamento,clase, familia WHERE departamento.id_dep=id AND departamento.id_dep=clase.id_dep AND clase.id_clas=familia.id_clas$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `articulos`
--

CREATE TABLE `articulos` (
  `Sku` int(6) NOT NULL,
  `Articulo` varchar(15) NOT NULL,
  `Marca` varchar(15) NOT NULL,
  `Modelo` varchar(20) NOT NULL,
  `Depart` int(1) NOT NULL,
  `Clase` int(2) NOT NULL,
  `Familia` int(3) NOT NULL,
  `Fech_alt` date NOT NULL,
  `Stock` int(9) NOT NULL,
  `Cant` int(9) NOT NULL,
  `Descon` int(1) NOT NULL,
  `Fech_baj` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `articulos`
--

INSERT INTO `articulos` (`Sku`, `Articulo`, `Marca`, `Modelo`, `Depart`, `Clase`, `Familia`, `Fech_alt`, `Stock`, `Cant`, `Descon`, `Fech_baj`) VALUES
(1, 'CHOCOLATE', 'KITKAT', 'BLANCO', 1, 1, 1, '2023-12-21', 2, 2, 0, '1990-01-01');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clase`
--

CREATE TABLE `clase` (
  `id_clas` int(11) NOT NULL,
  `id_dep` int(11) NOT NULL,
  `Num_cla` int(1) NOT NULL,
  `Nom_cla` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `clase`
--

INSERT INTO `clase` (`id_clas`, `id_dep`, `Num_cla`, `Nom_cla`) VALUES
(1, 1, 1, 'COMESTIBLE'),
(2, 1, 2, 'LICUADORAS'),
(3, 1, 3, 'BATIDORAS'),
(4, 1, 4, 'CAFETERAS'),
(5, 2, 1, 'AMPLIFICADORES CAR/AUDIO'),
(6, 2, 2, 'AUTO STEREOS'),
(7, 3, 1, 'COLCHON'),
(8, 3, 2, 'JUEGO BOX'),
(9, 4, 0, 'SALAS'),
(10, 4, 2, 'COMPLEMENTOS PARA SALA'),
(11, 4, 3, 'SOFAS CAMA');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamento`
--

CREATE TABLE `departamento` (
  `id_dep` int(11) NOT NULL,
  `Num_dep` int(1) NOT NULL,
  `Nom_dep` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `departamento`
--

INSERT INTO `departamento` (`id_dep`, `Num_dep`, `Nom_dep`) VALUES
(1, 1, 'DOMESTICOS'),
(2, 2, 'ELECTRONICA'),
(3, 3, 'MUEBLE SUELTO'),
(4, 4, 'SALAS, RECAMARAS, COMEDORES');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `familia`
--

CREATE TABLE `familia` (
  `id_fam` int(11) NOT NULL,
  `id_clas` int(11) NOT NULL,
  `Num_fam` int(2) NOT NULL,
  `Nom_fam` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `familia`
--

INSERT INTO `familia` (`id_fam`, `id_clas`, `Num_fam`, `Nom_fam`) VALUES
(1, 1, 0, 'SIN NOMBRE'),
(2, 2, 1, 'LICUADORAS'),
(3, 2, 2, 'EXCLUSIVO COPPEL.COM'),
(4, 3, 1, 'BATIDORA MANUAL'),
(5, 3, 2, 'PROCESADOR'),
(6, 3, 3, 'PICADORA'),
(7, 3, 4, 'BATIDORA PEDESTAL'),
(8, 3, 5, 'BATIDORA FUENTE DE SODAS'),
(9, 3, 6, 'MULTIPRACTICOS'),
(10, 3, 7, 'EXCLUSIVOS COPPEL.COM'),
(11, 4, 1, 'CAFETERAS'),
(12, 4, 2, 'PERCOLADORAS'),
(13, 5, 1, 'AMPLIFICADOR/RECEPTOR'),
(14, 5, 2, 'AUTO ESTEREO C/BOCINA'),
(15, 5, 3, 'AMPLIFICADOR'),
(16, 6, 4, 'ALARMA AUTO/CASA/OFICINA'),
(17, 6, 5, 'SIN MECANISMO'),
(18, 6, 6, 'CON CD'),
(19, 6, 7, 'MULTIMEDIA'),
(20, 6, 8, 'PAQUETE SIN MECANISMO'),
(21, 6, 9, 'PAQUETE CON CD'),
(22, 7, 1, 'PILLOW TOP KS'),
(23, 7, 2, 'PILLOW TOP DOBLE KS'),
(24, 7, 3, 'HULE ESPUMA KS'),
(25, 8, 1, 'ESTANDAR INDIVIDUAL'),
(26, 8, 2, 'PILLOW TOP INDIVIDUAL'),
(27, 8, 3, 'PILLOW TOP DOBLE INDIVIDUAL'),
(28, 9, 1, 'ESQUINERAS SUPERIORES'),
(29, 9, 2, 'TIPO L SECCIONAL'),
(30, 10, 1, 'SILLON OCASIONAL'),
(31, 10, 2, 'PUFF'),
(32, 10, 3, 'BAUL'),
(33, 10, 4, 'TABURETE'),
(34, 11, 1, 'SOFA CAMA TAPIZADO'),
(35, 11, 2, 'SOFA CAMA CLASICO'),
(36, 11, 3, 'ESTUDIO');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `articulos`
--
ALTER TABLE `articulos`
  ADD PRIMARY KEY (`Sku`),
  ADD KEY `departa` (`Depart`),
  ADD KEY `class` (`Clase`),
  ADD KEY `fami` (`Familia`);

--
-- Indices de la tabla `clase`
--
ALTER TABLE `clase`
  ADD PRIMARY KEY (`id_clas`),
  ADD KEY `depa` (`id_dep`);

--
-- Indices de la tabla `departamento`
--
ALTER TABLE `departamento`
  ADD PRIMARY KEY (`id_dep`);

--
-- Indices de la tabla `familia`
--
ALTER TABLE `familia`
  ADD PRIMARY KEY (`id_fam`),
  ADD KEY `clas` (`id_clas`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `articulos`
--
ALTER TABLE `articulos`
  MODIFY `Sku` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `clase`
--
ALTER TABLE `clase`
  MODIFY `id_clas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT de la tabla `departamento`
--
ALTER TABLE `departamento`
  MODIFY `id_dep` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `familia`
--
ALTER TABLE `familia`
  MODIFY `id_fam` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `articulos`
--
ALTER TABLE `articulos`
  ADD CONSTRAINT `class` FOREIGN KEY (`Clase`) REFERENCES `clase` (`id_clas`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `departa` FOREIGN KEY (`Depart`) REFERENCES `departamento` (`id_dep`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `fami` FOREIGN KEY (`Familia`) REFERENCES `familia` (`id_fam`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Filtros para la tabla `clase`
--
ALTER TABLE `clase`
  ADD CONSTRAINT `depa` FOREIGN KEY (`id_dep`) REFERENCES `departamento` (`id_dep`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `familia`
--
ALTER TABLE `familia`
  ADD CONSTRAINT `clas` FOREIGN KEY (`id_clas`) REFERENCES `clase` (`id_clas`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
