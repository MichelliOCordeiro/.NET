programa {
	funcao inicio() {
		// Exercicio2: Considerando um array [1, 2, 3, 4] A soma é 10. O produto é 24.
		
		inteiro array[4] = {1, 2, 3, 4}
		inteiro soma = 0, produto = 1
		
		//Alterando
		para (inteiro x = 0; x < 4; x++) {
            soma = soma + array[x]
            produto = produto * array[x]
        }
        
        escreva("A soma é ", soma,". O produto é ", produto)
	}
}
