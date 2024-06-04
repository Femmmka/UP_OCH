-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3308
-- Время создания: Июн 03 2024 г., 15:47
-- Версия сервера: 5.7.39
-- Версия PHP: 8.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `uchot_oborud`
--

-- --------------------------------------------------------

--
-- Структура таблицы `Auditorium`
--

CREATE TABLE `Auditorium` (
  `id` int(11) NOT NULL,
  `name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `code` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `Equipment`
--

CREATE TABLE `Equipment` (
  `id` int(11) NOT NULL,
  `name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `photo` mediumblob NOT NULL,
  `inventory_number` int(11) NOT NULL,
  `auditorium_id` int(11) DEFAULT NULL,
  `responsible_user_id` int(11) DEFAULT NULL,
  `cost` decimal(10,2) DEFAULT NULL,
  `status_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `EquipmentStatus`
--

CREATE TABLE `EquipmentStatus` (
  `id` int(11) NOT NULL,
  `name` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `User`
--

CREATE TABLE `User` (
  `id` int(11) NOT NULL,
  `login` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `role` enum('администратор','сотрудник') COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `last_name` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `first_name` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `middle_name` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `phone` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `Auditorium`
--
ALTER TABLE `Auditorium`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `Equipment`
--
ALTER TABLE `Equipment`
  ADD PRIMARY KEY (`id`),
  ADD KEY `auditorium_id` (`auditorium_id`),
  ADD KEY `responsible_user_id` (`responsible_user_id`),
  ADD KEY `status_id` (`status_id`);

--
-- Индексы таблицы `EquipmentStatus`
--
ALTER TABLE `EquipmentStatus`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `User`
--
ALTER TABLE `User`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `Auditorium`
--
ALTER TABLE `Auditorium`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `Equipment`
--
ALTER TABLE `Equipment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `EquipmentStatus`
--
ALTER TABLE `EquipmentStatus`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `User`
--
ALTER TABLE `User`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `Equipment`
--
ALTER TABLE `Equipment`
  ADD CONSTRAINT `equipment_ibfk_1` FOREIGN KEY (`auditorium_id`) REFERENCES `Auditorium` (`id`),
  ADD CONSTRAINT `equipment_ibfk_2` FOREIGN KEY (`responsible_user_id`) REFERENCES `User` (`id`),
  ADD CONSTRAINT `equipment_ibfk_3` FOREIGN KEY (`status_id`) REFERENCES `EquipmentStatus` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
