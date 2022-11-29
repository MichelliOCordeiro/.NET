programa {
	funcao inicio() {
		real mediaSalario = 0.0, mediaFilho = 0.0, maiorSalario = 0.0,	percentual = 0.0

		para(inteiro x = 1; x <= 4; x++){
			escreva("#", x, " Pessoa - Qual é seu salário: ")
			real salario
			leia(salario)
			
			escreva("Quantos filhos você possui: ")
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

		escreva("A média do salário da população é ", mediaSalario / 4)
		escreva("\nA média de filhos é ", mediaFilho / 4)
		escreva("\nO maior salário é ", maiorSalario)
		escreva("\nO percentual de pessoas com salário até ", "R$100,00 é ", percentual / 4 * 100, "%\n")
	}
}
