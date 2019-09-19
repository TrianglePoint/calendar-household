CREATE TABLE `userInfo` (
  `userCD` int PRIMARY KEY,
  `userId` varchar(255),
  `userPass` varchar(255),
  `userName` varchar(255),
  `userMail` varchar(255),
  `signDay` timestamp,
  `delFlg` char
);

CREATE TABLE `monthInfo` (
  `No` int PRIMARY KEY,
  `userCD` int PRIMARY KEY,
  `toDay` varchar(255),
  `currentMonth` varchar(255),
  `startMonth` varchar(255)
);

CREATE TABLE `mainMonthInfo` (
  `No` int PRIMARY KEY,
  `userCD` int PRIMARY KEY,
  `toDay` varchar(255),
  `spendMonth` bigint,
  `incomeMonth` bigint,
  `budgetMonth` bigint,
  `useBudget` bigint,
  `spendByDay` bigint,
  `incomeByDay` bigint
);

CREATE TABLE `dayInfo` (
  `todaySEQ` int PRIMARY KEY,
  `userCD` int PRIMARY KEY,
  `spendToday` bigint,
  `incomeToday` bigint,
  `historyToday` bigint,
  `spendByDay` bigint,
  `incomeByDay` bigint,
  `budgetByDay` bigint,
  `delFlg` char
);

CREATE TABLE `variTable` (
  `No` int PRIMARY KEY,
  `cordSection` char,
  `cordNo` char,
  `cordName` varchar(255)
);

ALTER TABLE `monthInfo` ADD FOREIGN KEY (`userCD`) REFERENCES `userInfo` (`userCD`);

ALTER TABLE `mainMonthInfo` ADD FOREIGN KEY (`userCD`) REFERENCES `monthInfo` (`userCD`);

ALTER TABLE `dayInfo` ADD FOREIGN KEY (`userCD`) REFERENCES `mainMonthInfo` (`userCD`);
