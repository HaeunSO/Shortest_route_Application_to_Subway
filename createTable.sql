﻿CREATE TABLE m_node
 ( 
  gid integer,
  id varchar(10),
  statnnm varchar(50),
  linenum varchar(2),
  transfer varchar(2),
  stationid varchar(10)
  );

CREATE TABLE m_network
 ( 
  gid integer,
  id varchar(15),
  source integer,
  target integer,
  cost float,
  linenum varchar(2)
  );

 CREATE TABLE m_linenm
 ( 
  id varchar(2),
  linenm varchar(20)
  );

 INSERT INTO m_linenm VALUES
 (1, '1호선'),  (2, '2호선'),  (3, '3호선'),  (4, '4호선'),  (5, '5호선'),
 (6, '6호선'),  (7, '7호선'),  (8, '8호선'),  (9, '9호선'),  (10, '경의중앙선'),
 (11, '분당선'),  (12, '신분당선'),  (13, '공항철도'),  (14, '인천 1호선'),  (15, '인천 2호선'),
 (16, '경춘선'),  (17, '우이신설선'),  (18, '수인선'),  (19, '경강선'),  (20, '서해선'),
 (21, '의정부경전철'),  (22, '용인경전철'),  (23, '인천공항자기부상철도');

SELECT * FROM m_node;
SELECT * FROM m_network;
SELECT * FROM m_linenm;
