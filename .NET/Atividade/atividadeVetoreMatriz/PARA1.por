programa {
	funcao inicio() {
		real mediaSalario = 0.0, mediaFilho = 0.0, maiorSalario = 0.0,	percentual = 0.0

		para(inteiro x = 1; x <= 4; x++){
			escreva("#", x, " Pessoa - Qual � seu sal�rio: ")
			real salario
			leia(salario)
			
			escreva("Quantos filhos voc� possui: ")
			inteiro filho
			leia(filho)

			mediaSalario += salario
			mediaFilho += filho
			
			se(salario > maiorSalario){
				maiorSalario = salario			
			}
			se(salario <= 100){
				percentual++
			}
			escreva("\n")
		}

		escreva("A m�dia do sal�rio da popula��o � ", mediaSalario / 4)
		escreva("\nA m�dia de filhos � ", mediaFilho / 4)
		escreva("\nO maior sal�rio � ", maiorSalario)
		escreva("\nO percentual de pessoas com sal�rio at� ", "R$100,00 � ", percentual / 4 * 100, "%\n")
	}
}
