DECLARE
	l_name_FK VARCHAR2(1000 CHAR);
	l_name_idx VARCHAR2(1000 CHAR);
	l_rows Number;
	e_inconsistent_date EXCEPTION;
	e_schema_not_update EXCEPTION;
BEGIN
	SELECT COUNT(1) INTO l_rows FROM ALL_TAB_COLUMNS WHERE OWNER = SYS_CONTEXT ('USERENV', 'CURRENT_SCHEMA') 
	AND TABLE_NAME = 'ComEx_CurrencyIntTradeCapture'  AND COLUMN_NAME = 'AgreedTerm';
	IF l_rows = 1 THEN
		SELECT COUNT(1) INTO l_rows FROM ALL_TAB_COLUMNS WHERE OWNER = SYS_CONTEXT ('USERENV', 'CURRENT_SCHEMA') 
		AND TABLE_NAME = 'ComEx_CurrencyIntTradeCapture' AND COLUMN_NAME = 'Term';
		IF l_rows = 1 THEN
			SELECT COUNT(1) INTO l_rows FROM "ComEx_CurrencyIntTradeCapture" 
			WHERE "Term" != (SELECT "Oid" FROM "ComEx_Term" WHERE "MinimumDays" = 0 AND "MaximumDays" = 0);
			IF l_rows = 0 THEN
				UPDATE "ComEx_CurrencyIntTradeCapture" SET "AgreedTerm" = 
				(SELECT "Oid" FROM "ComEx_AgreedTermTypes" WHERE "days" =0);

				SELECT INDEX_NAME INTO l_name_idx
				FROM ALL_IND_COLUMNS WHERE TABLE_OWNER = SYS_CONTEXT ('USERENV', 'CURRENT_SCHEMA')
				AND TABLE_NAME = 'ComEx_CurrencyIntTradeCapture' AND COLUMN_NAME = 'Term';
				
				EXECUTE IMMEDIATE 'DROP INDEX "' || l_name_idx || '"';

				SELECT CONSTRAINT_NAME INTO l_name_FK
				FROM ALL_CONS_COLUMNS WHERE OWNER = SYS_CONTEXT ('USERENV', 'CURRENT_SCHEMA') 
				AND TABLE_NAME = 'ComEx_CurrencyIntTradeCapture' AND COLUMN_NAME = 'Term';
									
				EXECUTE IMMEDIATE 'ALTER TABLE "ComEx_CurrencyIntTradeCapture" DROP CONSTRAINT "' || l_name_FK || '"';
				EXECUTE IMMEDIATE 'ALTER TABLE "ComEx_CurrencyIntTradeCapture" DROP COLUMN "Term"';
			ELSE
				RAISE e_inconsistent_date;
			END IF;
		END IF;
	ELSE
		RAISE e_schema_not_update;
	END IF;
EXCEPTION
	WHEN e_schema_not_update THEN
		raise_application_error(-20001, 'Debe iniciar la aplicación Enterprise Cliente antes de ejecutar este script.');
	WHEN e_inconsistent_date THEN
		raise_application_error(-20001, 'Se han encontrado inconsistencias en la base de datos.');
	WHEN OTHERS THEN
		ROLLBACK;
		raise_application_error(-20001, 'Ha ocurrido un error al ejecutar script. ' || substr(SQLERRM, 1, 200));	
END;