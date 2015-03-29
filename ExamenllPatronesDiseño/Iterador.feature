Feature: Iterador
	Para poder recorrer operaciones aritmeticas
	Como estudiante quiero llenar las listas de 
	las sumas ,restas y multiplicaciones de dos operandos

@mytag
Scenario: Llenar las listas de las operaciones
	Given Una lista de operaciones:
		| Operacion        | Operando1    | Operando2 |
		| Suma             |    1         | 3         |
		| Resta            |    5         | 6         |
		| Resta            |    8         | 6         |
		| Suma             |    3         | 3         |
		| Resta            |    6         | 3         |  
		| Multiplicacion   |    3         | 4         | 
		 
	When Se llenan todas las listas de las operaciones
	Then La cantidad de operaciones en la Suma deberian ser 2 , en la Resta 3 y en la Multiplicacion 1

Scenario: Teniendo una lista llena de operaciones obtener la operacion actual de la suma
	Given Una lista de operaciones:
		| Operacion        | Operando1    | Operando2 |
		| Suma             |    1         | 3         |
		| Resta            |    5         | 6         |
		| Resta            |    8         | 6         |
		| Suma             |    3         | 3         |
		| Resta            |    6         | 3         |  
		| Multiplicacion   |    3         | 4         | 
	When Se llenan todas las listas de las operaciones
	And se crea el iterador 
	And  Se obtiene la primera operacion de la suma
	Then La operacion deberia ser "Suma" con 1 y 3


Scenario: Teniendo una lista llena de operaciones obtener la segunda operacion Resta
	Given Una lista de operaciones:
		| Operacion        | Operando1    | Operando2 |
		| Suma             |    1         | 3         |
		| Resta            |    5         | 6         |
		| Resta            |    8         | 6         |
		| Suma             |    3         | 3         |
		| Resta            |    6         | 3         |  
		| Multiplicacion   |    3         | 4         | 
	When Se llenan todas las listas de las operaciones
	And se crea el iterador 
	And  Se llama la siguiente operacion de la resta
	Then La operacion deberia ser "Resta" con 5 y 6


Scenario: Nos encontramos al final de las operaciones de la resta y agarramos la siguiente operacion y deberia de terminar
	Given Una lista de operaciones:
		| Operacion        | Operando1    | Operando2 |
		| Resta            |    6         | 3         |  
		 
	When Se llenan todas las listas de las operaciones
	And se crea el iterador 
	And Se llama la siguiente operacion de la resta
	Then Deberia de haber terminado 
