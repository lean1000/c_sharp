-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 19/02/2025 às 12:27
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
-- Banco de dados: `db_dreamggame`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_game`
--

CREATE TABLE `tb_game` (
  `id` int(11) NOT NULL,
  `titulo` varchar(100) NOT NULL,
  `avaliacao` int(1) NOT NULL,
  `tamanho` varchar(100) NOT NULL,
  `descricao` varchar(250) NOT NULL,
  `valor` varchar(250) NOT NULL,
  `desenvolvedor` varchar(250) NOT NULL,
  `genero` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_game`
--

INSERT INTO `tb_game` (`id`, `titulo`, `avaliacao`, `tamanho`, `descricao`, `valor`, `desenvolvedor`, `genero`) VALUES
(1, 'God of War', 5, '1G', 'Jogo de aventura', 'R$0100,00', 'Santa Monica', 'Aventura'),
(2, 'Resident Evil 4', 5, '800M', 'Jogo de terror que você tem que resgatar a filha do presidente.', 'R$0005,00', 'Capcon', 'Terror');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `tb_game`
--
ALTER TABLE `tb_game`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_game`
--
ALTER TABLE `tb_game`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
