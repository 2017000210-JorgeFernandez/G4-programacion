Algoritmo CR
	
    Definir num, i, contador, cantidadPrimos, sumaPares Como Entero
	
    cantidadPrimos <- 0
    sumaPares <- 0
	
    Escribir "Nombre: Jorge Fernandez"
	
    Para num <- 300 Hasta 1 Con Paso -1 Hacer
		
        contador <- 0
		
        Para i <- 1 Hasta num Hacer
			
            Si num MOD i = 0 Entonces
				
                contador <- contador + 1
				
            FinSi
			
        FinPara
		
        Si contador = 2 Entonces
			
            cantidadPrimos <- cantidadPrimos + 1
			
        FinSi
		
        Si num MOD 2 = 0 Entonces
			
            sumaPares <- sumaPares + num
			
        FinSi
		
    FinPara
	
    Escribir "Cantidad de numeros primos: ", cantidadPrimos
    Escribir "La suma de los pares es: ", sumaPares
	
FinAlgoritmo