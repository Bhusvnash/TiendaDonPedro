-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 06-10-2020 a las 16:58:10
-- Versión del servidor: 10.3.16-MariaDB
-- Versión de PHP: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_tiendadonpedro`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_categoria`
--

CREATE TABLE `tbl_categoria` (
  `id_categoria` bigint(20) NOT NULL,
  `des_categoria` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_cliente`
--

CREATE TABLE `tbl_cliente` (
  `id_cliente` bigint(20) NOT NULL,
  `nombre_cliente` varchar(200) DEFAULT NULL,
  `direccion_cliente` varchar(200) DEFAULT NULL,
  `email_cliente` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detallefactura`
--

CREATE TABLE `tbl_detallefactura` (
  `id_detalle` bigint(20) NOT NULL,
  `id_factura` bigint(20) DEFAULT NULL,
  `id_prodcuto` bigint(20) DEFAULT NULL,
  `cantidad` bigint(20) DEFAULT NULL,
  `preciounit` bigint(20) DEFAULT NULL,
  `valoriva` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_facturaventa`
--

CREATE TABLE `tbl_facturaventa` (
  `id_factura` bigint(20) NOT NULL,
  `fecha_factura` datetime DEFAULT NULL,
  `id_cliente` bigint(20) DEFAULT NULL,
  `total_factura` bigint(20) DEFAULT NULL,
  `estado_factura` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_producto`
--

CREATE TABLE `tbl_producto` (
  `id_producto` bigint(20) NOT NULL,
  `nombre_producto` varchar(200) DEFAULT NULL,
  `precio_producto` bigint(20) DEFAULT NULL,
  `stock_producto` bigint(20) DEFAULT NULL,
  `iva_producto` double DEFAULT NULL,
  `id_categoria` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario`
--

CREATE TABLE `tbl_usuario` (
  `id_usuario` bigint(20) NOT NULL,
  `alias_usuario` varchar(200) DEFAULT NULL,
  `nombre_usuario` varchar(200) DEFAULT NULL,
  `apellido_usuario` varchar(200) DEFAULT NULL,
  `password_usuario` varchar(200) DEFAULT NULL,
  `rol_usuario` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbl_categoria`
--
ALTER TABLE `tbl_categoria`
  ADD PRIMARY KEY (`id_categoria`);

--
-- Indices de la tabla `tbl_cliente`
--
ALTER TABLE `tbl_cliente`
  ADD PRIMARY KEY (`id_cliente`);

--
-- Indices de la tabla `tbl_detallefactura`
--
ALTER TABLE `tbl_detallefactura`
  ADD PRIMARY KEY (`id_detalle`),
  ADD KEY `FK_detfact_prod` (`id_prodcuto`),
  ADD KEY `KF_detfact_fact` (`id_factura`);

--
-- Indices de la tabla `tbl_facturaventa`
--
ALTER TABLE `tbl_facturaventa`
  ADD PRIMARY KEY (`id_factura`),
  ADD KEY `FK_fact_cliente` (`id_cliente`);

--
-- Indices de la tabla `tbl_producto`
--
ALTER TABLE `tbl_producto`
  ADD PRIMARY KEY (`id_producto`),
  ADD KEY `FK_prod_cat` (`id_categoria`);

--
-- Indices de la tabla `tbl_usuario`
--
ALTER TABLE `tbl_usuario`
  ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tbl_categoria`
--
ALTER TABLE `tbl_categoria`
  MODIFY `id_categoria` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_cliente`
--
ALTER TABLE `tbl_cliente`
  MODIFY `id_cliente` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_detallefactura`
--
ALTER TABLE `tbl_detallefactura`
  MODIFY `id_detalle` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_facturaventa`
--
ALTER TABLE `tbl_facturaventa`
  MODIFY `id_factura` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_producto`
--
ALTER TABLE `tbl_producto`
  MODIFY `id_producto` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_usuario`
--
ALTER TABLE `tbl_usuario`
  MODIFY `id_usuario` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tbl_detallefactura`
--
ALTER TABLE `tbl_detallefactura`
  ADD CONSTRAINT `FK_detfact_prod` FOREIGN KEY (`id_prodcuto`) REFERENCES `tbl_producto` (`id_producto`),
  ADD CONSTRAINT `KF_detfact_fact` FOREIGN KEY (`id_factura`) REFERENCES `tbl_facturaventa` (`id_factura`);

--
-- Filtros para la tabla `tbl_facturaventa`
--
ALTER TABLE `tbl_facturaventa`
  ADD CONSTRAINT `FK_fact_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `tbl_cliente` (`id_cliente`);

--
-- Filtros para la tabla `tbl_producto`
--
ALTER TABLE `tbl_producto`
  ADD CONSTRAINT `FK_prod_cat` FOREIGN KEY (`id_categoria`) REFERENCES `tbl_categoria` (`id_categoria`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
