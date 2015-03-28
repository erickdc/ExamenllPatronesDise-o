Feature: EjecutadorComandos
	Para poder realizar operaciones aritmeticas
	Como estudiante quiero ver
	la suma ,resta y multiplicacion de dos operandos


Scenario: Sumar dos numeros
	Given 1 y 3 para la "Suma" en la calculadora
	When presione sumar
	Then el resultado de la suma debe ser 4

Scenario: Restar dos numeros
	Given 5 y 6 para la "Resta" en la calculadora
	When presione restar
	Then el resultado de la resta debe ser -1

Scenario: Mutiplicar dos numeros
	Given 3 y 4 para la "Multiplicacion" en la calculadora
	When presione multiplicar
	Then el resultado de la multiplicacion debe ser 12

Scenario: Ejecutar Lista de operaciones Aritmeticas
	Given  la lista de operaciones aritmeticas
	| Operando1 | Operando2 |	  Operacion    |
	| 1         | 3         |	   Suma	       |
	| 5         | 6         |	   Resta	   |
	| 3         | 4         |  Multiplicacion  |

	When Se ejecutan todas las operaciones
	
	Then este resultado debe aparecer
	| Resultado | 
	|    4	    |
	|   -1      |
	|    12		|
	