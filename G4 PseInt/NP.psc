Algoritmo NP
	
    Definir num, i, contador, cantidad, suma Como Entero
	
    cantidad <- 0
    suma <- 0
	
    Escribir "Nombre: Jorge Fernandez"
	
    Para num <- 1 Hasta 100 Hacer
		
        contador <- 0
		
        Para i <- 1 Hasta num Hacer
			
            Si num MOD i = 0 Entonces
				
                contador <- contador + 1
				
            FinSi
			
        FinPara
		
        Si contador = 2 Entonces
			
            cantidad <- cantidad + 1
            suma <- suma + num
			
        FinSi
		
    FinPara
	
    Escribir "Cantidad de numeros primos: ", cantidad
    Escribir "La suma de los numeros primos es: ", suma
	
FinAlgoritmo