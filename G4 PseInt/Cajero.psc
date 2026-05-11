Algoritmo Cajero
	
    Definir billete, i, cantidad100, total Como Entero
	
    cantidad100 <- 0
    total <- 0
	
    Escribir "Nombre: Jorge Fernandez"
	
    Para i <- 1 Hasta 1000 Hacer
		
        Escribir "Ingrese el valor del billete:"
        Leer billete
		
        total <- total + billete
		
        Si billete = 100 Entonces
			
            cantidad100 <- cantidad100 + 1
			
        FinSi
		
    FinPara
	
    Escribir "Cantidad de billetes de 100: ", cantidad100
    Escribir "Dinero total: $", total
	
FinAlgoritmo