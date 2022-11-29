programa {
	funcao inicio() {
		// Exercicio1: Considerando um array [1, 2, 4, 5]. O output deve ser [2, 4, 8, 10]
		
		inteiro array[4] = {1, 2, 4, 5}
		
		//Alterando
		para (inteiro x = 0; x < 4; x++) {
            array[x] = array[x] * 2
        }
        
        //Imprimindo lista
        para (inteiro x = 0; x < 4; x++) {
            escreva(array[x], "\n")
        }
	}
}
