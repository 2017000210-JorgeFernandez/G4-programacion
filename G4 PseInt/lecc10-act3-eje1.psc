Algoritmo SumaNumerosPrimos
	
    Definir num, i, contador, suma Como Entero
    suma <- 0
	
    Escribir "Nombre: Jorge Fernandez"
	
    Para num <- 1 Hasta 22 Hacer
		
        contador <- 0
		
        Para i <- 1 Hasta num Hacer
			
            Si num MOD i = 0 Entonces
                contador <- contador + 1
            FinSi
			
        FinPara
		
        Si contador = 2 Entonces
			
            Escribir "Numero primo: ", num
			
            suma <- suma + num
			
        FinSi
		
    FinPara
	
    Escribir "La suma de los numeros primos es: ", suma
	
FinAlgoritmo