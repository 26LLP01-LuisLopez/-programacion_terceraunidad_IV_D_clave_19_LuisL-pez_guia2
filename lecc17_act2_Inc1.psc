Algoritmo lecc17_act2_Inc1
	Definir fila, columna Como Entero
    Dimension tabla[4,4]
    Para fila <- 1 Hasta 4 Hacer
        Para columna <- 1 Hasta 4 Hacer
            Si fila = columna Entonces
                tabla[fila,columna] <- 1
            SiNo
                tabla[fila,columna] <- 0
            FinSi
        FinPara
    FinPara
FinAlgoritmo
