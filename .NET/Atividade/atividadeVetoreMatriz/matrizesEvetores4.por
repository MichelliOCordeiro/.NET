programa
{
	
	funcao inicio()
	{
		// 4. O array apresentado é [3, 5, 7, 1, 6]. Encontre qual é o menor número?

		// Tamanho maximo do array
		const inteiro MAX = 5
		
		inteiro array[MAX] = {3, 5, 7, 1, 6}

		inteiro menor = 7 // Comecar com 7 (porque e o maior numero do array).
		para (inteiro i = 0; i < MAX; i++){

			// Se o atual menor numero for maior do que o atual indice do array,
			// entao atual indice se torna o novo menor numero
			se (menor > array[i]) {
				menor = array[i] 
			}
		}

		escreva("Menor numero do array: " + menor)
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 168; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */