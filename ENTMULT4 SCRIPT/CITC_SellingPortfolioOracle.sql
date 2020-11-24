--  ====================================================================================================================
--  Ejecutar Script: Despues de iniciar la aplicación
--  ====================================================================================================================
--  ====================================================================================================================
--  Proyecto:		Enterprise
--  Motor:			Oracle
--  Author:			Kevin Sebastian Pineda Jaramillo	
--  Email:			kevin.pineda@finac.com
--  Fecha:			11/24/2020
--  Versión:		
--  Descripción:	Modificación de la tabla "ComEx_CurrencyIntTradeCapture".
--  Objetivo:		Se actualizan los datos de la columna "SellingPortfolio" a "RecordingPortfolio", 
--					por último se elimina la columna "SellingPortfolio". 				
--  ====================================================================================================================
DECLARE
    l_name_FK VARCHAR2(1000 CHAR);
    l_name_idx VARCHAR2(1000 CHAR);
    l_rows	NUMBER;
    e_schema_not_update	EXCEPTION;
BEGIN
    SELECT COUNT(1) INTO l_rows FROM ALL_TAB_COLUMNS WHERE OWNER = SYS_CONTEXT ('USERENV', 'CURRENT_SCHEMA') 
    AND TABLE_NAME = 'ComEx_CurrencyIntTradeCapture' AND COLUMN_NAME = 'RecordingPortfolio';
    IF l_rows = 1 THEN
		SELECT COUNT(1) INTO l_rows FROM ALL_TAB_COLUMNS WHERE OWNER = SYS_CONTEXT ('USERENV', 'CURRENT_SCHEMA') 
		AND TABLE_NAME = 'ComEx_CurrencyIntTradeCapture' AND COLUMN_NAME = 'SellingPortfolio';
		IF l_rows = 1 THEN
            SELECT CONSTRAINT_NAME INTO l_name_FK
            FROM ALL_CONS_COLUMNS WHERE OWNER = SYS_CONTEXT ('USERENV', 'CURRENT_SCHEMA') 
            AND TABLE_NAME = 'ComEx_CurrencyIntTradeCapture' AND COLUMN_NAME = 'SellingPortfolio';
                
            SELECT INDEX_NAME INTO l_name_idx
            FROM ALL_IND_COLUMNS WHERE TABLE_OWNER = SYS_CONTEXT ('USERENV', 'CURRENT_SCHEMA') 
            AND TABLE_NAME = 'ComEx_CurrencyIntTradeCapture' AND COLUMN_NAME = 'SellingPortfolio';
        
            EXECUTE IMMEDIATE 'UPDATE "ComEx_CurrencyIntTradeCapture" SET "RecordingPortfolio" = "SellingPortfolio"';
            EXECUTE IMMEDIATE 'ALTER TABLE "ComEx_CurrencyIntTradeCapture" DROP CONSTRAINT "' || l_name_FK || '"';
            EXECUTE IMMEDIATE 'DROP INDEX "' || l_name_idx || '"';
			EXECUTE IMMEDIATE 'ALTER TABLE "ComEx_CurrencyIntTradeCapture" DROP COLUMN "SellingPortfolio"';
		END IF;
	ELSE
		RAISE e_schema_not_update;
	END IF;	
EXCEPTION
	WHEN e_schema_not_update THEN
		raise_application_error(-20001, 'Debe iniciar la aplicación Enterprise Cliente antes de ejecutar este script.');
	WHEN OTHERS THEN
		ROLLBACK;
		raise_application_error(-20001, 'Ha ocurrido un error al ejecutar script. ' || substr(SQLERRM, 1, 200));	
END;