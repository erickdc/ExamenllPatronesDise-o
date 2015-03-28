Feature: LogDecoratorPattern
	Al realizar operaciones aritmeticas
	la calculadora debera crear
	un log con todas las operaciones ejecutadas

@mytag
Scenario: Ejecutamos una serie de operaciones aritmeticas
	Given  que se hayan ejecutado las siguientes operaciones con los siguientes resultados
	| Operacion		| Resultado |
	| Suma			| 4         |
	| Resta         | -1        |
	| Multiplicacion| 12        |	
	Then el log debera contener
	| Operacion		| Resultado |
	| Suma			| 4         |
	| Resta         | -1        |
	| Multiplicacion| 12        |