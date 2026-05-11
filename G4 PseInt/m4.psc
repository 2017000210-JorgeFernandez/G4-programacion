Algoritmo M4
	
    Definir num1, num2, menor, mayor, i Como Entero
	
    Escribir "Nombre: Jorge Fernandez"
	
    Escribir "Ingrese el primer numero:"
    Leer num1
	
    Escribir "Ingrese el segundo numero:"
    Leer num2
	
    Si num1 < num2 Entonces
		
        menor <- num1
        mayor <- num2
		
    SiNo
		
        menor <- num2
        mayor <- num1
		
    FinSi
	
    Para i <- menor Hasta mayor Hacer
		
        Si i MOD 4 = 0 Entonces
			
            Escribir i
			
        FinSi
		
    FinPara
	
FinAlgoritmo