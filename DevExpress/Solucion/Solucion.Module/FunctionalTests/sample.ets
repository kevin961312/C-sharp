;#DropDB SolucionEasyTest

#Application SolucionWin
#Application SolucionWeb
#IfDef SolucionWin

*Action About...
 
*Action OK

#EndIf

#IfDef SolucionWeb
!Action Navigation(My Details)
#EndIf
