programa {
	funcao inicio() {
	    
		inteiro numero, quantidade = 0, soma = 0

		escreva("Digite um número: ")
		leia(numero)

		faca{
			para(inteiro x = 1; x <= numero; x++){
				soma += x
				quantidade++			
			}			
		}
		enquanto(numero != quantidade)

		escreva("Soma total: ", soma)
	}
}
