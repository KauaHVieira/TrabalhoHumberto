-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Máquina: localhost
-- Data de Criação: 26-Out-2025 às 16:39
-- Versão do servidor: 5.6.13
-- versão do PHP: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de Dados: `cad_clientes_adsma2`
--
CREATE DATABASE IF NOT EXISTS `cad_clientes_adsma2` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `cad_clientes_adsma2`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_clientes`
--

CREATE TABLE IF NOT EXISTS `tb_clientes` (
  `id_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `cpf` varchar(14) NOT NULL,
  `nome` varchar(70) NOT NULL,
  `data_nasc` varchar(10) NOT NULL,
  `fone` varchar(20) NOT NULL,
  `email` varchar(70) NOT NULL,
  `foto` varchar(255) NOT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Extraindo dados da tabela `tb_clientes`
--

INSERT INTO `tb_clientes` (`id_cliente`, `cpf`, `nome`, `data_nasc`, `fone`, `email`, `foto`) VALUES
(1, '999.999.999-33', 'YURRA BARRA', '11/09/2025', '+55 (11)99999-3333', 'YURRABARRA@FATEC', 'D:/HUMBERTOSYSTEMINF/PROJETO/PRJ_CADASTRO/BIN/DEBUG/FOTOS/GATO.JPG');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
