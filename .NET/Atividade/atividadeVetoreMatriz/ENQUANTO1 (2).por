programa {
	funcao inicio() {
		
		real soma = 0.0, numero
		inteiro quantidade = 0

		escreva("Digite um numero positivo: ")
		leia(numero)
		
		enquanto(numero >= 0){
			soma += numero
			quantidade++
			escreva("Digite um numero positivo: ")
			leia(numero)	
		}

		escreva("A soma total: ", soma,	" a média é ", soma / quantidade, " e a quantidade", " de número digitados foi ", quantidade, ".")	
	}
}
