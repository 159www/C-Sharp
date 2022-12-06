/*
 Navicat Premium Data Transfer

 Source Server         : localhost_3306
 Source Server Type    : MySQL
 Source Server Version : 80021
 Source Host           : localhost:3306
 Source Schema         : onenet

 Target Server Type    : MySQL
 Target Server Version : 80021
 File Encoding         : 65001

 Date: 01/07/2022 18:28:07
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for cmd
-- ----------------------------
DROP TABLE IF EXISTS `cmd`;
CREATE TABLE `cmd`  (
  `devicename` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `cmdname` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `cmd` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`devicename`, `cmdname`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of cmd
-- ----------------------------
INSERT INTO `cmd` VALUES ('stm32f103zet6', '上锁', 'RELAY_ON');
INSERT INTO `cmd` VALUES ('stm32f103zet6', '关灯', 'LED_OFF');
INSERT INTO `cmd` VALUES ('stm32f103zet6', '开灯', 'LED_ON');
INSERT INTO `cmd` VALUES ('stm32f103zet6', '解锁', 'RELAY_OFF');

-- ----------------------------
-- Table structure for datahistory
-- ----------------------------
DROP TABLE IF EXISTS `datahistory`;
CREATE TABLE `datahistory`  (
  `datastream` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `value` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `time` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`time`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of datahistory
-- ----------------------------
INSERT INTO `datahistory` VALUES ('humidity', '64\r\n', '2022-06-01 15:43:27.980');
INSERT INTO `datahistory` VALUES ('humidity', '64\r\n', '2022-06-01 15:43:29.110');
INSERT INTO `datahistory` VALUES ('humidity', '64\r\n', '2022-06-01 15:43:30.243');
INSERT INTO `datahistory` VALUES ('humidity', '64\r\n', '2022-06-01 15:43:31.380');
INSERT INTO `datahistory` VALUES ('humidity', '64\r\n', '2022-06-01 15:43:32.535');
INSERT INTO `datahistory` VALUES ('humidity', '64\r\n', '2022-06-01 15:43:33.640');
INSERT INTO `datahistory` VALUES ('humidity', '64\r\n', '2022-06-01 15:43:34.780');
INSERT INTO `datahistory` VALUES ('humidity', '64\r\n', '2022-06-01 15:43:35.920');
INSERT INTO `datahistory` VALUES ('humidity', '64\r\n', '2022-06-01 15:43:37.060');
INSERT INTO `datahistory` VALUES ('humidity', '64\r\n', '2022-06-01 15:43:38.220');

-- ----------------------------
-- Table structure for datastream
-- ----------------------------
DROP TABLE IF EXISTS `datastream`;
CREATE TABLE `datastream`  (
  `deviceid` int NOT NULL,
  `datastreamid` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `unit` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `unitsymbol` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`deviceid`, `datastreamid`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of datastream
-- ----------------------------
INSERT INTO `datastream` VALUES (951993945, 'humidity', '百分之', '%');
INSERT INTO `datastream` VALUES (951993945, 'tempterture', '摄氏度', '℃');

-- ----------------------------
-- Table structure for device
-- ----------------------------
DROP TABLE IF EXISTS `device`;
CREATE TABLE `device`  (
  `deviceid` int NOT NULL,
  `devicename` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `devicestatus` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `deviceprotocol` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `devicecreattime` datetime(0) NOT NULL,
  PRIMARY KEY (`deviceid`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of device
-- ----------------------------
INSERT INTO `device` VALUES (951993945, 'stm32f103zet6', 'False', 'DTU', '2022-05-31 10:48:20');

-- ----------------------------
-- Table structure for loginhistory
-- ----------------------------
DROP TABLE IF EXISTS `loginhistory`;
CREATE TABLE `loginhistory`  (
  `deviceid` int NOT NULL,
  `logintime` datetime(0) NOT NULL,
  PRIMARY KEY (`deviceid`, `logintime`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of loginhistory
-- ----------------------------
INSERT INTO `loginhistory` VALUES (951993945, '2022-06-04 17:57:31');

SET FOREIGN_KEY_CHECKS = 1;
