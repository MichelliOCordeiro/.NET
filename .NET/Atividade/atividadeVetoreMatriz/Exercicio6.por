programa {
	funcao inicio() {
	    // Exercicio6: O array apresentado é {{34,56},{87,90},{25,58}}. Encontre o menor numero?.
	    
		inteiro l, c, array[3][2] = {{34,56},{87,90},{25,58}}
		inteiro menor = array[0][0]

        para(l = 0; l < 3; l++)
        {
          para(c = 0; c < 2; c++)
          {
              se(array[l][c] < menor)
              {
                  menor = array[l][c]
              }
          }
        }
        
        escreva("O menor valor é: ", menor)
	}
}
