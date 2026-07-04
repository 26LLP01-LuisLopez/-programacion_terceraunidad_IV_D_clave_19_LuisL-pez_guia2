Algoritmo lecc17_act1_inc1
	definir donas como cadena 
	Dimension donas[2,4]
	donas[1,1] = "chocolate"
	donas[1,2] = "fresa"
	donas[1,3] = "vainilla"
	donas[1,4] = "galseado"
	donas[2,1] = "caramelo"
	donas[2,2] = "cafe"
	donas[2,3] = "limon"
	donas[2,4] = "canela"
	Para fila<-1 Hasta 2  Hacer
		Para columna<-1 Hasta 4  Hacer
			Escribir Sin Saltar donas[fila,columna]," | "
		Fin Para
		Escribir ""
	Fin Para
FinAlgoritmo
