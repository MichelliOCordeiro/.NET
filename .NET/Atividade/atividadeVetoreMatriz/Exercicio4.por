programa {
	funcao inicio() {
		// Exercicio4: O array apresentado � [3, 5, 7, 1, 6]. Encontre qual � o menor numero?.
		
		inteiro array[5] = {3, 5, 7, 1, 6}
		inteiro menor = array[0]
		
		para (inteiro x = 0; x < 5; x++) {
		    
		    se(array[x] < menor)
		    {
		        menor = array[x]
		    }
        }
        
        escreva("O menor valor �: ", menor)
	}
}
