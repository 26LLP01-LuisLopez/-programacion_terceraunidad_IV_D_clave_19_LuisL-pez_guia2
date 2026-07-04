Algoritmo lecc17_act3_Inc1
	Definir fila, columna, suma Como Entero
    Dimension matriz[4,3]
    Para fila <- 1 Hasta 4 Hacer
        suma <- 0
        Para columna <- 1 Hasta 3 Hacer
            Leer matriz[fila,columna]
            suma <- suma + matriz[fila,columna]
        FinPara
        Escribir "Suma fila ", fila, ": ", suma
    FinPara
FinAlgoritmo
