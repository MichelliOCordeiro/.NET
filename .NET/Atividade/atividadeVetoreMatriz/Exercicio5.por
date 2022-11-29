programa {
	funcao inicio() {
	    // Exercicio5: O array apresentado é {{34,56},{87,90},{25,58}}. Encontre o maior numero?.
	    
		inteiro l, c, array[3][2] = {{34,56},{87,90},{25,58}}
		inteiro maior = array[0][0]

        para(l = 0; l < 3; l++)
        {
          para(c = 0; c < 2; c++)
          {
              se(array[l][c] > maior)
              {
                  maior = array[l][c]
              }
          }
        }
        
        escreva("O maior valor é: ", maior)
	}
}
