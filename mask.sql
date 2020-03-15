/*
Navicat MySQL Data Transfer

Source Server         : localhost_3307
Source Server Version : 50716
Source Host           : localhost:3307
Source Database       : mask

Target Server Type    : MYSQL
Target Server Version : 50716
File Encoding         : 65001

Date: 2020-03-15 11:12:02
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `appiontment`
-- ----------------------------
DROP TABLE IF EXISTS `appiontment`;
CREATE TABLE `appiontment` (
  `listNumber` int(1) NOT NULL,
  `mask` int(3) NOT NULL,
  `opentime` varchar(10) NOT NULL,
  `closetime` varchar(10) NOT NULL,
  PRIMARY KEY (`listNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of appiontment
-- ----------------------------

-- ----------------------------
-- Table structure for `list`
-- ----------------------------
DROP TABLE IF EXISTS `list`;
CREATE TABLE `list` (
  `listNumber` int(2) NOT NULL,
  `name` varchar(8) NOT NULL,
  `ID` char(18) NOT NULL,
  `phone` char(11) NOT NULL,
  `maskNumber` int(1) NOT NULL,
  `registerID` char(9) NOT NULL,
  PRIMARY KEY (`registerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of list
-- ----------------------------

-- ----------------------------
-- Table structure for `register`
-- ----------------------------
DROP TABLE IF EXISTS `register`;
CREATE TABLE `register` (
  `name` varchar(8) NOT NULL,
  `ID` char(18) NOT NULL,
  `phone` char(11) NOT NULL,
  `maskNumber` int(1) NOT NULL,
  `registerID` char(9) NOT NULL,
  `listNumber` int(1) NOT NULL,
  PRIMARY KEY (`registerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of register
-- ----------------------------
