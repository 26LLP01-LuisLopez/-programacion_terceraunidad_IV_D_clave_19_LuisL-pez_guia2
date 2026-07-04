Algoritmo lecc17_act3_Inc2
	Definir fila, columna Como Entero
    Definir mayor, filaMayor, columnaMayor Como Entero
    Dimension matriz[4,4]
    Para fila <- 1 Hasta 4 Hacer
        Para columna <- 1 Hasta 4 Hacer
            Leer matriz[fila,columna]
            Si fila = 1 Y columna = 1 Entonces
                mayor <- matriz[fila,columna]
                filaMayor <- fila
                columnaMayor <- columna
            SiNo
                Si matriz[fila,columna] > mayor Entonces
                    mayor <- matriz[fila,columna]
                    filaMayor <- fila
                    columnaMayor <- columna
                FinSi
            FinSi
        FinPara
    FinPara
    Escribir "Mayor: ", mayor
    Escribir "Fila: ", filaMayor
    Escribir "Columna: ", columnaMayor
FinAlgoritmo
