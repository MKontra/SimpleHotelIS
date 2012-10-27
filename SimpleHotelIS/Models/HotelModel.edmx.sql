



-- -----------------------------------------------------------
-- Entity Designer DDL Script for MySQL Server 4.1 and higher
-- -----------------------------------------------------------
-- Date Created: 10/27/2012 23:40:18
-- Generated from EDMX file: C:\Users\Administrator.WIN-JUDDD2BQEDG\Documents\Visual Studio 2010\Projects\SimpleHotelIS\SimpleHotelIS\Models\HotelModel.edmx
-- Target version: 2.0.0.0
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------

--    ALTER TABLE `Rezervacias` DROP CONSTRAINT `FK_ZakaznikRezervacia`;
--    ALTER TABLE `Platbas` DROP CONSTRAINT `FK_ZakaznikPlatba`;
--    ALTER TABLE `Izbas` DROP CONSTRAINT `FK_RezervaciaIzba`;
--    ALTER TABLE `Izbas` DROP CONSTRAINT `FK_PobytIzba`;
--    ALTER TABLE `Sluzbies` DROP CONSTRAINT `FK_PobytSluzby`;
--    ALTER TABLE `Pobyts` DROP CONSTRAINT `FK_ZakaznikPobyt`;

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------
SET foreign_key_checks = 0;
    DROP TABLE IF EXISTS `Zakazniks`;
    DROP TABLE IF EXISTS `Rezervacias`;
    DROP TABLE IF EXISTS `Pobyts`;
    DROP TABLE IF EXISTS `Izbas`;
    DROP TABLE IF EXISTS `Platbas`;
    DROP TABLE IF EXISTS `Sluzbies`;
SET foreign_key_checks = 1;

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Zakazniks'

CREATE TABLE `Zakazniks` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `meno` longtext  NOT NULL,
    `priezvisko` longtext  NOT NULL,
    `kontakt` longtext  NOT NULL
);

-- Creating table 'Rezervacias'

CREATE TABLE `Rezervacias` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `Zakaznik_Id` int  NOT NULL
);

-- Creating table 'Pobyts'

CREATE TABLE `Pobyts` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `Zakaznik_Id` int  NOT NULL
);

-- Creating table 'Izbas'

CREATE TABLE `Izbas` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `Rezervacia_Id` int  NOT NULL,
    `Pobyt_Id` int  NOT NULL
);

-- Creating table 'Platbas'

CREATE TABLE `Platbas` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `Zakaznik_Id` int  NOT NULL
);

-- Creating table 'Sluzbies'

CREATE TABLE `Sluzbies` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `Description` longtext  NOT NULL,
    `Pobyt_Id` int  NOT NULL
);



-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------



-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on `Zakaznik_Id` in table 'Rezervacias'

ALTER TABLE `Rezervacias`
ADD CONSTRAINT `FK_ZakaznikRezervacia`
    FOREIGN KEY (`Zakaznik_Id`)
    REFERENCES `Zakazniks`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ZakaznikRezervacia'

CREATE INDEX `IX_FK_ZakaznikRezervacia` 
    ON `Rezervacias`
    (`Zakaznik_Id`);

-- Creating foreign key on `Zakaznik_Id` in table 'Platbas'

ALTER TABLE `Platbas`
ADD CONSTRAINT `FK_ZakaznikPlatba`
    FOREIGN KEY (`Zakaznik_Id`)
    REFERENCES `Zakazniks`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ZakaznikPlatba'

CREATE INDEX `IX_FK_ZakaznikPlatba` 
    ON `Platbas`
    (`Zakaznik_Id`);

-- Creating foreign key on `Rezervacia_Id` in table 'Izbas'

ALTER TABLE `Izbas`
ADD CONSTRAINT `FK_RezervaciaIzba`
    FOREIGN KEY (`Rezervacia_Id`)
    REFERENCES `Rezervacias`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RezervaciaIzba'

CREATE INDEX `IX_FK_RezervaciaIzba` 
    ON `Izbas`
    (`Rezervacia_Id`);

-- Creating foreign key on `Pobyt_Id` in table 'Izbas'

ALTER TABLE `Izbas`
ADD CONSTRAINT `FK_PobytIzba`
    FOREIGN KEY (`Pobyt_Id`)
    REFERENCES `Pobyts`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PobytIzba'

CREATE INDEX `IX_FK_PobytIzba` 
    ON `Izbas`
    (`Pobyt_Id`);

-- Creating foreign key on `Pobyt_Id` in table 'Sluzbies'

ALTER TABLE `Sluzbies`
ADD CONSTRAINT `FK_PobytSluzby`
    FOREIGN KEY (`Pobyt_Id`)
    REFERENCES `Pobyts`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PobytSluzby'

CREATE INDEX `IX_FK_PobytSluzby` 
    ON `Sluzbies`
    (`Pobyt_Id`);

-- Creating foreign key on `Zakaznik_Id` in table 'Pobyts'

ALTER TABLE `Pobyts`
ADD CONSTRAINT `FK_ZakaznikPobyt`
    FOREIGN KEY (`Zakaznik_Id`)
    REFERENCES `Zakazniks`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ZakaznikPobyt'

CREATE INDEX `IX_FK_ZakaznikPobyt` 
    ON `Pobyts`
    (`Zakaznik_Id`);

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
