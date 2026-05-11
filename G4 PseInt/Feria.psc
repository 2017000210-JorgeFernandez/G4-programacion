Algoritmo Feria
	
    Definir opcion, boletosAdulto, boletosNino, totalBoletos Como Entero
    Definir totalDinero Como Real
	
    boletosAdulto <- 0
    boletosNino <- 0
    totalBoletos <- 0
    totalDinero <- 0
	
    Escribir "Nombre: Jorge Fernandez"
	
    Repetir
		
        Escribir "1. Boleto adulto"
        Escribir "2. Boleto niño"
        Escribir "3. Salir"
        Leer opcion
		
        Segun opcion Hacer
			
            1:
                boletosAdulto <- boletosAdulto + 1
                totalBoletos <- totalBoletos + 1
                totalDinero <- totalDinero + 15
				
            2:
                boletosNino <- boletosNino + 1
                totalBoletos <- totalBoletos + 1
                totalDinero <- totalDinero + 10
				
            3:
                Escribir "Fin de ventas"
				
            De Otro Modo:
                Escribir "Opcion no valida"
				
        FinSegun
		
    Hasta Que opcion = 3
	
    Escribir "Boletos de adulto vendidos: ", boletosAdulto
    Escribir "Boletos de niño vendidos: ", boletosNino
    Escribir "Total de boletos vendidos: ", totalBoletos
    Escribir "Total de dinero cobrado: $", totalDinero
	
FinAlgoritmo