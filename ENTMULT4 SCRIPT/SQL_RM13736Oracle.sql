DECLARE
	l_rows number;
	e_schema_not_update EXCEPTION;
BEGIN
	SELECT COUNT(1) INTO l_rows FROM ALL_TAB_COLUMNS WHERE OWNER = SYS_CONTEXT('USERENV','CURRENT_SCHEMA')
	AND TABLE_NAME = 'ComEx_ForeignExOpParameter' AND COLUMN_NAME = 'GenerateInternalTrade';
	IF l_rows = 1 THEN
		EXECUTE IMMEDIATE 'UPDATE "ComEx_ForeignExOpParameter" SET "GenerateInternalTrade" = 1 WHERE "GenerateInte;rnalTrade" IS NULL';
	ELSE
		RAISE e_schema_not_update;
	END IF;
EXCEPTION
	WHEN e_schema_not_update THEN
		raise_application_error(-20001, 'Debe iniciar la aplicación Enterprise Cliente antes de ejecutar este script.');
	WHEN OTHERS THEN
		ROLLBACK;
		raise_application_error(-20002, 'Ha ocurrido un error al ejecutar script. ' || substr(SQLERRM, 1, 200));		
END;