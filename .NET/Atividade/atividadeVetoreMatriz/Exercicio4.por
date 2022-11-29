programa {
	funcao inicio() {
		// Exercicio4: O array apresentado é [3, 5, 7, 1, 6]. Encontre qual é o menor numero?.
		
		inteiro array[5] = {3, 5, 7, 1, 6}
		inteiro menor = array[0]
		
		para (inteiro x = 0; x < 5; x++) {
		    
		    se(array[x] < menor)
		    {
		        menor = array[x]
		    }
        }
        
        escreva("O menor valor é: ", menor)
	}
}
