Algoritmo MD7
	
    Definir i, multiplo, suma, pares Como Entero
	
    suma <- 0
    pares <- 0
	
    Escribir "Nombre: Jorge Fernadez"
	
    Para i <- 1 Hasta 20 Hacer
		
        multiplo <- i * 7
		
        Escribir multiplo
		
        suma <- suma + multiplo
		
        Si multiplo MOD 2 = 0 Entonces
			
            pares <- pares + 1
			
        FinSi
		
    FinPara
	
    Escribir "La suma de los multiplos es: ", suma
    Escribir "Cantidad de multiplos pares: ", pares
	
FinAlgoritmo