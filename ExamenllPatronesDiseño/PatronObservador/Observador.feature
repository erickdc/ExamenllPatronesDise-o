Feature: EjecutadorComandos
	Para poder realizar operaciones utilizando patron Observador


Scenario:Agregar Observador
	Given se debe agregar Observador
	When presione la opcion Registrar Observador
	Then El resultado debe ser:
		| Observador | 
	    | Suma       |
	    | Resta      |
	    | Multiplicacion	|

Scenario: Remover Observador
	Given se debe eliminar un observador
	When  presione la opcion Remover
	Then el resultado de la accion debe ser
		 | Observador | 
	     | Suma       |
	     | Resta      |


 Scenario: El sujeto ejecuta la accion
	Given el sujeto ejecuta la ccion de notificar las actualizaciones en las clases de cada observador
	| Operacion        | Operando1    | Operando2 |
	| Suma             |    1         | 3         |
	
	When el operador recolecta la informacion de las clases
	
	Then este resultado debe ser el siguiente
	| Operacion        | Operando1    | Operando2 |
	| Suma             |    1         | 3         |


	 Scenario: El sujeto notifica los cambios que ocurridos en las clases de los observadores
	Given las clases tienen los siguiente resultados
	| Operacion      | Operando1 | Operando2 | Resultado |
	| Suma           | 1         | 3         | 4         |
	| Resta          | 5         | 6         | 1         |
	| Multiplicacion | 4         | 3         | 12        |
	And Total  Promedio
	| Promedio |
	| 5.66     |	
	When Los observadores notifican los cambios que re hisieron en las clases
	| Operacion      | Operando1 | Operando2 | Resultado |
	| Suma           | 2         | 3         | 5         |
	Then el sujeto notifica los cambios de los observadores y la informacion del promedio se actualiza automaticamente
	| Promedio |
	| 6        |







