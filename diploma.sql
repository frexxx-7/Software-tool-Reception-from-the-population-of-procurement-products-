-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Июн 08 2023 г., 18:56
-- Версия сервера: 10.3.22-MariaDB
-- Версия PHP: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `diploma`
--

-- --------------------------------------------------------

--
-- Структура таблицы `acceptancereceipt`
--

CREATE TABLE `acceptancereceipt` (
  `id` int(11) NOT NULL,
  `idDelivery` int(11) NOT NULL,
  `idClicker` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `acceptancereceipt`
--

INSERT INTO `acceptancereceipt` (`id`, `idDelivery`, `idClicker`) VALUES
(1, 4, 6),
(2, 4, 6),
(3, 4, 6);

-- --------------------------------------------------------

--
-- Структура таблицы `areas`
--

CREATE TABLE `areas` (
  `id` int(11) NOT NULL,
  `name` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `areas`
--

INSERT INTO `areas` (`id`, `name`) VALUES
(1, 'Минская'),
(2, 'Брестская'),
(3, 'Витебская'),
(4, 'Гомельская'),
(5, 'Гродненская'),
(6, 'Могилёвская');

-- --------------------------------------------------------

--
-- Структура таблицы `clicker`
--

CREATE TABLE `clicker` (
  `id` int(11) NOT NULL,
  `name` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `surname` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `patronymic` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idRaysouyz` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `clicker`
--

INSERT INTO `clicker` (`id`, `name`, `surname`, `patronymic`, `idRaysouyz`) VALUES
(5, 'Иванова', 'выа', 'вфыва', 5),
(6, 'Арбузов', 'вы', 'фыв', 6);

-- --------------------------------------------------------

--
-- Структура таблицы `delivery`
--

CREATE TABLE `delivery` (
  `id` int(11) NOT NULL,
  `name` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `surname` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `patronymic` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `phone` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `numberPassport` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idLocality` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `delivery`
--

INSERT INTO `delivery` (`id`, `name`, `surname`, `patronymic`, `phone`, `numberPassport`, `idLocality`) VALUES
(4, 'Ивана', 'Иванова', 'Ивановича', '37529764534а', 'ьваываыва', 4),
(5, 'Арбак', '', '', '', '', 5),
(6, 'йке', 'укен', 'уекн', '+999999', '23525', 1),
(7, 'qweqweqweq', 'qweqew', 'qweqe', '=7896', '3575', 2),
(8, 'йцу', 'цук', 'уке', '6745', '7457', 3);

-- --------------------------------------------------------

--
-- Структура таблицы `locality`
--

CREATE TABLE `locality` (
  `id` int(11) NOT NULL,
  `name` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `region` int(11) DEFAULT NULL,
  `area` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `locality`
--

INSERT INTO `locality` (`id`, `name`, `region`, `area`) VALUES
(1, 'qweqwe', 1, 2),
(2, 'qweqwe', 2, 1),
(3, 'йцуйцу', 1, 2);

-- --------------------------------------------------------

--
-- Структура таблицы `raw`
--

CREATE TABLE `raw` (
  `id` int(11) NOT NULL,
  `name` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `unit` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `price` double DEFAULT NULL,
  `quantity` double DEFAULT NULL,
  `discount` double DEFAULT NULL,
  `idTypeOfRaw` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `raw`
--

INSERT INTO `raw` (`id`, `name`, `unit`, `price`, `quantity`, `discount`, `idTypeOfRaw`) VALUES
(11, 'Лососьа', '123', 1233, 123, 10, 12),
(12, 'Арбуз', '123', 0.64, 123, 3, 12),
(13, 'rety', 'rty', 567, 546, 45, 8);

-- --------------------------------------------------------

--
-- Структура таблицы `rawinacceptancereceipt`
--

CREATE TABLE `rawinacceptancereceipt` (
  `id` int(11) NOT NULL,
  `idRaw` int(11) DEFAULT NULL,
  `idAcceptancereceipt` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `rawinacceptancereceipt`
--

INSERT INTO `rawinacceptancereceipt` (`id`, `idRaw`, `idAcceptancereceipt`) VALUES
(1, 11, 1),
(2, 12, 1),
(3, 13, 1),
(4, 11, 3),
(5, 12, 3);

-- --------------------------------------------------------

--
-- Структура таблицы `raysoyuz`
--

CREATE TABLE `raysoyuz` (
  `id` int(11) NOT NULL,
  `name` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idRegion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `raysoyuz`
--

INSERT INTO `raysoyuz` (`id`, `name`, `idRegion`) VALUES
(5, 'вфыа', 5),
(6, 'вфы', 6);

-- --------------------------------------------------------

--
-- Структура таблицы `region`
--

CREATE TABLE `region` (
  `id` int(11) NOT NULL,
  `name` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `region`
--

INSERT INTO `region` (`id`, `name`) VALUES
(5, 'выа'),
(6, 'вы');

-- --------------------------------------------------------

--
-- Структура таблицы `regions`
--

CREATE TABLE `regions` (
  `id` int(11) NOT NULL,
  `name` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `regions`
--

INSERT INTO `regions` (`id`, `name`) VALUES
(1, 'Барановичи'),
(2, 'Молодечно');

-- --------------------------------------------------------

--
-- Структура таблицы `typeofraw`
--

CREATE TABLE `typeofraw` (
  `id` int(11) NOT NULL,
  `name` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `typeofraw`
--

INSERT INTO `typeofraw` (`id`, `name`) VALUES
(8, 'Море продукт'),
(12, '123'),
(13, 'dgfg');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `acceptancereceipt`
--
ALTER TABLE `acceptancereceipt`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idDelivery` (`idDelivery`),
  ADD KEY `idClicker` (`idClicker`);

--
-- Индексы таблицы `areas`
--
ALTER TABLE `areas`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `clicker`
--
ALTER TABLE `clicker`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idRaysouyz` (`idRaysouyz`);

--
-- Индексы таблицы `delivery`
--
ALTER TABLE `delivery`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idLocality` (`idLocality`);

--
-- Индексы таблицы `locality`
--
ALTER TABLE `locality`
  ADD PRIMARY KEY (`id`),
  ADD KEY `area` (`area`),
  ADD KEY `region` (`region`);

--
-- Индексы таблицы `raw`
--
ALTER TABLE `raw`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idTypeOfRaw` (`idTypeOfRaw`);

--
-- Индексы таблицы `rawinacceptancereceipt`
--
ALTER TABLE `rawinacceptancereceipt`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idRaw` (`idRaw`),
  ADD KEY `idAcceptancereceipt` (`idAcceptancereceipt`);

--
-- Индексы таблицы `raysoyuz`
--
ALTER TABLE `raysoyuz`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idRegion` (`idRegion`);

--
-- Индексы таблицы `region`
--
ALTER TABLE `region`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `regions`
--
ALTER TABLE `regions`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `typeofraw`
--
ALTER TABLE `typeofraw`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `acceptancereceipt`
--
ALTER TABLE `acceptancereceipt`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `areas`
--
ALTER TABLE `areas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `clicker`
--
ALTER TABLE `clicker`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `delivery`
--
ALTER TABLE `delivery`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT для таблицы `locality`
--
ALTER TABLE `locality`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `raw`
--
ALTER TABLE `raw`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT для таблицы `rawinacceptancereceipt`
--
ALTER TABLE `rawinacceptancereceipt`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `raysoyuz`
--
ALTER TABLE `raysoyuz`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `region`
--
ALTER TABLE `region`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `regions`
--
ALTER TABLE `regions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `typeofraw`
--
ALTER TABLE `typeofraw`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `acceptancereceipt`
--
ALTER TABLE `acceptancereceipt`
  ADD CONSTRAINT `acceptancereceipt_ibfk_1` FOREIGN KEY (`idDelivery`) REFERENCES `delivery` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `acceptancereceipt_ibfk_2` FOREIGN KEY (`idClicker`) REFERENCES `clicker` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `clicker`
--
ALTER TABLE `clicker`
  ADD CONSTRAINT `clicker_ibfk_1` FOREIGN KEY (`idRaysouyz`) REFERENCES `raysoyuz` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `delivery`
--
ALTER TABLE `delivery`
  ADD CONSTRAINT `delivery_ibfk_1` FOREIGN KEY (`idLocality`) REFERENCES `locality` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `locality`
--
ALTER TABLE `locality`
  ADD CONSTRAINT `locality_ibfk_1` FOREIGN KEY (`area`) REFERENCES `areas` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `locality_ibfk_2` FOREIGN KEY (`area`) REFERENCES `areas` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `locality_ibfk_3` FOREIGN KEY (`region`) REFERENCES `regions` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `raw`
--
ALTER TABLE `raw`
  ADD CONSTRAINT `raw_ibfk_1` FOREIGN KEY (`idTypeOfRaw`) REFERENCES `typeofraw` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `rawinacceptancereceipt`
--
ALTER TABLE `rawinacceptancereceipt`
  ADD CONSTRAINT `rawinacceptancereceipt_ibfk_1` FOREIGN KEY (`idRaw`) REFERENCES `raw` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `rawinacceptancereceipt_ibfk_2` FOREIGN KEY (`idAcceptancereceipt`) REFERENCES `acceptancereceipt` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `raysoyuz`
--
ALTER TABLE `raysoyuz`
  ADD CONSTRAINT `raysoyuz_ibfk_1` FOREIGN KEY (`idRegion`) REFERENCES `region` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
