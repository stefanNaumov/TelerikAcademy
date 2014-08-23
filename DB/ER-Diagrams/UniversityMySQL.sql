SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema University
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `University` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `University` ;

-- -----------------------------------------------------
-- Table `University`.`Professor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`Professor` (
  `ProfessorID` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NULL,
  PRIMARY KEY (`ProfessorID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`Department`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`Department` (
  `DepartmentID` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NULL,
  `ProfessorsID` INT NULL,
  `CoursesID` INT NULL,
  `Professor_ProfessorID` INT NOT NULL,
  PRIMARY KEY (`DepartmentID`),
  INDEX `fk_Department_Professor1_idx` (`Professor_ProfessorID` ASC),
  CONSTRAINT `fk_Department_Professor1`
    FOREIGN KEY (`Professor_ProfessorID`)
    REFERENCES `University`.`Professor` (`ProfessorID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`Faculty`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`Faculty` (
  `FacultyID` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NULL,
  `DepartmentsID` INT NULL,
  `Department_DepartmentID` INT NOT NULL,
  PRIMARY KEY (`FacultyID`),
  INDEX `fk_Faculty_Department1_idx` (`Department_DepartmentID` ASC),
  CONSTRAINT `fk_Faculty_Department1`
    FOREIGN KEY (`Department_DepartmentID`)
    REFERENCES `University`.`Department` (`DepartmentID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`Student`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`Student` (
  `StudentsID` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NULL,
  `FacultyID` INT NULL,
  `Faculty_FacultyID` INT NOT NULL,
  PRIMARY KEY (`StudentsID`),
  INDEX `fk_Student_Faculty1_idx` (`Faculty_FacultyID` ASC),
  CONSTRAINT `fk_Student_Faculty1`
    FOREIGN KEY (`Faculty_FacultyID`)
    REFERENCES `University`.`Faculty` (`FacultyID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`Title`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`Title` (
  `TitleID` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NULL,
  PRIMARY KEY (`TitleID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`Course`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`Course` (
  `CourseID` INT NOT NULL,
  `Name` VARCHAR(45) NULL,
  `Department_DepartmentID` INT NOT NULL,
  PRIMARY KEY (`CourseID`),
  INDEX `fk_Course_Department1_idx` (`Department_DepartmentID` ASC),
  CONSTRAINT `fk_Course_Department1`
    FOREIGN KEY (`Department_DepartmentID`)
    REFERENCES `University`.`Department` (`DepartmentID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`ProfessorTitles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`ProfessorTitles` (
  `ProfessorsTitlesID` INT NOT NULL,
  `Title_TitleID` INT NOT NULL,
  `Professor_ProfessorID` INT NOT NULL,
  PRIMARY KEY (`ProfessorsTitlesID`),
  INDEX `fk_ProfessorTitles_Title1_idx` (`Title_TitleID` ASC),
  INDEX `fk_ProfessorTitles_Professor1_idx` (`Professor_ProfessorID` ASC),
  CONSTRAINT `fk_ProfessorTitles_Title1`
    FOREIGN KEY (`Title_TitleID`)
    REFERENCES `University`.`Title` (`TitleID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ProfessorTitles_Professor1`
    FOREIGN KEY (`Professor_ProfessorID`)
    REFERENCES `University`.`Professor` (`ProfessorID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`StudentsCourses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`StudentsCourses` (
  `StudentsCoursesID` INT NOT NULL,
  `Course_CourseID` INT NOT NULL,
  `Student_StudentsID` INT NOT NULL,
  PRIMARY KEY (`StudentsCoursesID`),
  INDEX `fk_StudentsCourses_Course1_idx` (`Course_CourseID` ASC),
  INDEX `fk_StudentsCourses_Student1_idx` (`Student_StudentsID` ASC),
  CONSTRAINT `fk_StudentsCourses_Course1`
    FOREIGN KEY (`Course_CourseID`)
    REFERENCES `University`.`Course` (`CourseID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_StudentsCourses_Student1`
    FOREIGN KEY (`Student_StudentsID`)
    REFERENCES `University`.`Student` (`StudentsID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
