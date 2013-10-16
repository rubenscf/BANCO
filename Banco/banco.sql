--------------------------------------------------------
-- Archivo creado  - miércoles-octubre-16-2013   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence SEQ_IDCLIENTE
--------------------------------------------------------

   CREATE SEQUENCE  "BANCO"."SEQ_IDCLIENTE"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 3 NOCACHE  ORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_IDCUENTA
--------------------------------------------------------

   CREATE SEQUENCE  "BANCO"."SEQ_IDCUENTA"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 3 NOCACHE  ORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_IDDEPTO
--------------------------------------------------------

   CREATE SEQUENCE  "BANCO"."SEQ_IDDEPTO"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  ORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_IDEMPLEADO
--------------------------------------------------------

   CREATE SEQUENCE  "BANCO"."SEQ_IDEMPLEADO"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 2 NOCACHE  ORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_IDPUESTO
--------------------------------------------------------

   CREATE SEQUENCE  "BANCO"."SEQ_IDPUESTO"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  ORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_IDTARJETA
--------------------------------------------------------

   CREATE SEQUENCE  "BANCO"."SEQ_IDTARJETA"  MINVALUE 2000 MAXVALUE 5000 INCREMENT BY 1 START WITH 2001 NOCACHE  ORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_IDTIPOCUENTA
--------------------------------------------------------

   CREATE SEQUENCE  "BANCO"."SEQ_IDTIPOCUENTA"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  ORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_IDTRANS
--------------------------------------------------------

   CREATE SEQUENCE  "BANCO"."SEQ_IDTRANS"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 2 NOCACHE  ORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_IDUSER
--------------------------------------------------------

   CREATE SEQUENCE  "BANCO"."SEQ_IDUSER"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  ORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Table CLIENTE
--------------------------------------------------------

  CREATE TABLE "BANCO"."CLIENTE" 
   (	"IDCLIENTE" NUMBER(38,0), 
	"NOMBRE" VARCHAR2(200 BYTE), 
	"APELLIDO" VARCHAR2(200 BYTE), 
	"DIRECCION" VARCHAR2(200 BYTE), 
	"TELEFONO" VARCHAR2(200 BYTE), 
	"DPI" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table CUENTA
--------------------------------------------------------

  CREATE TABLE "BANCO"."CUENTA" 
   (	"IDCLIENTE" NUMBER(38,0), 
	"IDCUENTA" NUMBER(38,0), 
	"IDTIPOCUENTA" NUMBER(38,0), 
	"SALDO" NUMBER(38,2), 
	"ESTADO" VARCHAR2(5 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table DEPARTAMENTO
--------------------------------------------------------

  CREATE TABLE "BANCO"."DEPARTAMENTO" 
   (	"IDDEPTO" NUMBER(38,0), 
	"DESCRIPCION" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table EMPLEADO
--------------------------------------------------------

  CREATE TABLE "BANCO"."EMPLEADO" 
   (	"IDEMPLEADO" NUMBER(38,0), 
	"IDPUESTO" NUMBER(38,0), 
	"IDEPTOP" NUMBER(38,0), 
	"NOMBRE" VARCHAR2(50 BYTE), 
	"APELLIDO" VARCHAR2(50 BYTE), 
	"DPI" VARCHAR2(50 BYTE), 
	"USUARIO" VARCHAR2(50 BYTE), 
	"CONTRASENA" VARCHAR2(500 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table PUESTO
--------------------------------------------------------

  CREATE TABLE "BANCO"."PUESTO" 
   (	"IDDEPTO" NUMBER(38,0), 
	"IDPUESTO" NUMBER(38,0), 
	"DESCRIPCION" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table TARJETA
--------------------------------------------------------

  CREATE TABLE "BANCO"."TARJETA" 
   (	"IDCLIENTE" NUMBER(38,0), 
	"IDCUENTA" NUMBER(38,0), 
	"IDTARJETA" NUMBER(38,0), 
	"IDTIPO" NUMBER(38,0), 
	"LIMITE" NUMBER(38,0), 
	"ESTADO" VARCHAR2(5 BYTE), 
	"PIN" NUMBER(38,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table TIPOCUENTA
--------------------------------------------------------

  CREATE TABLE "BANCO"."TIPOCUENTA" 
   (	"IDTIPOCUENTA" NUMBER(38,0), 
	"TIPOCUENTA" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table TRANSACION
--------------------------------------------------------

  CREATE TABLE "BANCO"."TRANSACION" 
   (	"IDCLIENTE" NUMBER(38,0), 
	"IDCUENTA" NUMBER(38,0), 
	"IDTRANSACCION" NUMBER(38,0), 
	"TIPO" VARCHAR2(50 BYTE), 
	"FECHA" DATE, 
	"VALOR" NUMBER(38,2), 
	"DETALLE" VARCHAR2(200 BYTE), 
	"IDEMPLEADO" NUMBER(38,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table USUARIO
--------------------------------------------------------

  CREATE TABLE "BANCO"."USUARIO" 
   (	"IDUSER" NUMBER(38,0), 
	"USUARIO" VARCHAR2(50 BYTE), 
	"CONTRASENA" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
REM INSERTING into BANCO.CLIENTE
SET DEFINE OFF;
Insert into BANCO.CLIENTE (IDCLIENTE,NOMBRE,APELLIDO,DIRECCION,TELEFONO,DPI) values ('2','Rubens','Castillo','Mazatenango','51238111','987456321');
REM INSERTING into BANCO.CUENTA
SET DEFINE OFF;
REM INSERTING into BANCO.DEPARTAMENTO
SET DEFINE OFF;
Insert into BANCO.DEPARTAMENTO (IDDEPTO,DESCRIPCION) values ('1','Gerencia');
Insert into BANCO.DEPARTAMENTO (IDDEPTO,DESCRIPCION) values ('2','Administracio');
Insert into BANCO.DEPARTAMENTO (IDDEPTO,DESCRIPCION) values ('3','Servicio Al Cliente');
REM INSERTING into BANCO.EMPLEADO
SET DEFINE OFF;
Insert into BANCO.EMPLEADO (IDEMPLEADO,IDPUESTO,IDEPTOP,NOMBRE,APELLIDO,DPI,USUARIO,CONTRASENA) values ('1',null,null,null,null,null,null,null);
REM INSERTING into BANCO.PUESTO
SET DEFINE OFF;
Insert into BANCO.PUESTO (IDDEPTO,IDPUESTO,DESCRIPCION) values ('1','1','Jefe');
Insert into BANCO.PUESTO (IDDEPTO,IDPUESTO,DESCRIPCION) values ('1','2','Secretario');
Insert into BANCO.PUESTO (IDDEPTO,IDPUESTO,DESCRIPCION) values ('2','3','Gerente');
Insert into BANCO.PUESTO (IDDEPTO,IDPUESTO,DESCRIPCION) values ('2','4','Secretaria');
Insert into BANCO.PUESTO (IDDEPTO,IDPUESTO,DESCRIPCION) values ('3','5','Secretaria');
Insert into BANCO.PUESTO (IDDEPTO,IDPUESTO,DESCRIPCION) values ('3','6','Cajero');
REM INSERTING into BANCO.TARJETA
SET DEFINE OFF;
REM INSERTING into BANCO.TIPOCUENTA
SET DEFINE OFF;
Insert into BANCO.TIPOCUENTA (IDTIPOCUENTA,TIPOCUENTA) values ('1','AHORRO');
Insert into BANCO.TIPOCUENTA (IDTIPOCUENTA,TIPOCUENTA) values ('2','MONETARIO');
REM INSERTING into BANCO.TRANSACION
SET DEFINE OFF;
REM INSERTING into BANCO.USUARIO
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index SYS_C008196
--------------------------------------------------------

  CREATE UNIQUE INDEX "BANCO"."SYS_C008196" ON "BANCO"."TARJETA" ("IDCLIENTE", "IDCUENTA", "IDTARJETA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  Constraints for Table CLIENTE
--------------------------------------------------------

  ALTER TABLE "BANCO"."CLIENTE" ADD PRIMARY KEY ("IDCLIENTE")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table DEPARTAMENTO
--------------------------------------------------------

  ALTER TABLE "BANCO"."DEPARTAMENTO" ADD PRIMARY KEY ("IDDEPTO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table USUARIO
--------------------------------------------------------

  ALTER TABLE "BANCO"."USUARIO" ADD PRIMARY KEY ("IDUSER")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table TARJETA
--------------------------------------------------------

  ALTER TABLE "BANCO"."TARJETA" ADD CONSTRAINT "SYS_C008196" PRIMARY KEY ("IDCLIENTE", "IDCUENTA", "IDTARJETA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table TIPOCUENTA
--------------------------------------------------------

  ALTER TABLE "BANCO"."TIPOCUENTA" ADD PRIMARY KEY ("IDTIPOCUENTA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table EMPLEADO
--------------------------------------------------------

  ALTER TABLE "BANCO"."EMPLEADO" ADD PRIMARY KEY ("IDEMPLEADO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table TRANSACION
--------------------------------------------------------

  ALTER TABLE "BANCO"."TRANSACION" ADD PRIMARY KEY ("IDCLIENTE", "IDCUENTA", "IDTRANSACCION")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table CUENTA
--------------------------------------------------------

  ALTER TABLE "BANCO"."CUENTA" MODIFY ("IDCLIENTE" NOT NULL ENABLE);
  ALTER TABLE "BANCO"."CUENTA" ADD PRIMARY KEY ("IDCLIENTE", "IDCUENTA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table PUESTO
--------------------------------------------------------

  ALTER TABLE "BANCO"."PUESTO" ADD PRIMARY KEY ("IDPUESTO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table EMPLEADO
--------------------------------------------------------

  ALTER TABLE "BANCO"."EMPLEADO" ADD CONSTRAINT "FK_EMPLEADOS_PUESTO_1" FOREIGN KEY ("IDPUESTO")
	  REFERENCES "BANCO"."PUESTO" ("IDPUESTO") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table TARJETA
--------------------------------------------------------

  ALTER TABLE "BANCO"."TARJETA" ADD CONSTRAINT "FK_TARJETA_CUENTA_1" FOREIGN KEY ("IDCLIENTE", "IDCUENTA")
	  REFERENCES "BANCO"."CUENTA" ("IDCLIENTE", "IDCUENTA") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table TRANSACION
--------------------------------------------------------

  ALTER TABLE "BANCO"."TRANSACION" ADD CONSTRAINT "FK_TRANSACIONES_EMPLEADOS_1" FOREIGN KEY ("IDEMPLEADO")
	  REFERENCES "BANCO"."EMPLEADO" ("IDEMPLEADO") ENABLE;
--------------------------------------------------------
--  DDL for Procedure SP_ADD_CLIENTE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "BANCO"."SP_ADD_CLIENTE" ( 
                                  vnombre in cliente.nombre%type, 
                                  vapellido in varchar2, 
                                  vdire in varchar2,
                                  vtel in varchar2,
                                  vdpi in varchar2
                                 ) AS
                                 
                              
BEGIN
   insert into banco.cliente(idcliente, nombre, apellido, direccion, telefono, dpi) 
   values (seq_idcliente.nextval, vnombre, vapellido, vdire, vtel, vdpi);
  commit;
end;

/
--------------------------------------------------------
--  DDL for Procedure SP_ADD_CUENTA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "BANCO"."SP_ADD_CUENTA" ( 
                                  vcliente in cuenta.idcliente%type, 
                                  vtipocuenta in cuenta.idtipocuenta%type, 
                                  vsaldo   in cuenta.saldo%type,
                                  vestado in cuenta.estado%type
                                 ) AS
                                 
                              
BEGIN
   insert into banco.cuenta(idcliente, idcuenta, idtipocuenta,saldo,estado) 
   values (vcliente, seq_idcuenta.nextval, vtipocuenta, vsaldo, vestado);
  commit;
end;

/
--------------------------------------------------------
--  DDL for Procedure SP_ADD_EMPLEADO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "BANCO"."SP_ADD_EMPLEADO" ( 
                                  vidpuesto in int,
                                  vidptop in int,
                                  vnombre in varchar2, 
                                  vapellido in varchar2,
                                  vdpi in varchar2,
                                  vusuario in varchar2,
                                  vcontrasena in varchar2
                                 ) AS
                                 
                              
BEGIN
   insert into banco.empleado(idempleado,idpuesto,ideptop,nombre,apellido,dpi,usuario,contrasena) 
   values (seq_idempleado.nextval,vidpuesto, vidptop, vnombre,vapellido,vdpi,vusuario,vcontrasena);
   commit;
end;

/
--------------------------------------------------------
--  DDL for Procedure SP_ADD_TARJETA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "BANCO"."SP_ADD_TARJETA" ( 
                                  vidcliente in int,
                                  vidcuenta in int,
                                  vidtipo in int,
                                  vlimite in varchar2, 
                                  vestado in varchar2,
                                  vpin in varchar2
                                 ) AS                   
BEGIN
   insert into banco.tarjeta(idcliente,idcuenta,idtarjeta,idtipo,limite,estado,pin) 
   values (vidcliente,vidcuenta,seq_idtarjeta.nextval, vidtipo, vlimite,vestado,vpin);
   commit;
end;

/
--------------------------------------------------------
--  DDL for Procedure SP_ADD_TRANSACCION
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "BANCO"."SP_ADD_TRANSACCION" (vcliente in transacion.idcliente%type
                            , vcuenta in transacion.idcuenta%type
                            , vtipo in transacion.tipo%type
                            , vvalor in transacion.valor%type
                            , vdetalle in transacion.detalle%type
                            , vempleado in transacion.idempleado%type
                           ) AS
BEGIN
   insert into transacion(idtransaccion, idcliente, idcuenta, tipo, fecha, valor, detalle, idempleado ) 
   values (seq_idtrans.nextval, vcliente,vcuenta, vtipo, sysdate, vvalor,vdetalle,vempleado);
  commit;
end;

/
