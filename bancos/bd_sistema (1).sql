-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 19/02/2025 às 12:28
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bd_sistema`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_carros`
--

CREATE TABLE `tb_carros` (
  `Id_carros` int(11) NOT NULL,
  `Proprietario` varchar(150) NOT NULL,
  `Telefone` varchar(14) NOT NULL,
  `Cpf` varchar(14) NOT NULL,
  `Placa` varchar(20) NOT NULL,
  `Ano` varchar(10) NOT NULL,
  `Chassi` varchar(17) NOT NULL,
  `Cor` varchar(50) NOT NULL,
  `Marca` varchar(20) NOT NULL,
  `Modelo` varchar(10) NOT NULL,
  `Acessorio` varchar(200) NOT NULL,
  `Valor` varchar(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_clientes`
--

CREATE TABLE `tb_clientes` (
  `Id_Cliente` int(11) NOT NULL,
  `NomeCompleto` varchar(150) NOT NULL,
  `Cpf` varchar(14) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Cep` varchar(9) NOT NULL,
  `Numero` varchar(5) NOT NULL,
  `Telefone` varchar(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_clientes`
--

INSERT INTO `tb_clientes` (`Id_Cliente`, `NomeCompleto`, `Cpf`, `Email`, `Cep`, `Numero`, `Telefone`) VALUES
(1, 'Vagner Lourenço', '1813458926', 'ilsdhfjklsfhd@klshdfklshdf', '654645', '6546', '65464'),
(2, 'System.Windows.Forms.TextBox, Text: asdasdasd', 'System.Windows', 'System.Windows.Forms.TextBox, Text: asdasd', 'System.Wi', 'Syste', 'System.Windows'),
(3, 'zfdsdfsdf', '279.151.838-00', 'sdfsdf', '64654-654', '64654', '(65) 46546-644'),
(4, 'sdasd', '279.151.838-00', '1wsadd', '23131-231', '12312', '(12) 31231-231');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `tb_carros`
--
ALTER TABLE `tb_carros`
  ADD PRIMARY KEY (`Id_carros`);

--
-- Índices de tabela `tb_clientes`
--
ALTER TABLE `tb_clientes`
  ADD PRIMARY KEY (`Id_Cliente`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_carros`
--
ALTER TABLE `tb_carros`
  MODIFY `Id_carros` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `tb_clientes`
--
ALTER TABLE `tb_clientes`
  MODIFY `Id_Cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
