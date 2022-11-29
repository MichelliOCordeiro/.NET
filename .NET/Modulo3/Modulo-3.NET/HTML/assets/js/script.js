/*
por Tag: getElementByName()
por Id: getElementById()
por Nome: getElementByName()
por Classe: getElementByClassName()
por Seletor: querySelector()
*/

let nome = window.document.getElementById("nome")
let email = document.querySelector('#email')
let nomeDaReceita = document.querySelector('#nomeDaReceita')
let ingredientes = document.querySelector('#ingredientes')
let modoDePreparo = document.querySelector('#modoDePreparo')

nome.style.width = '100%'
email.style.width = '100%'
nomeDaReceita.style.width = '100%'

function validaEmail() {
    let txtEmail = document.querySelector('#txtEmail')
    
    if (email.value.indexOf('@') == 1 || email.value.indexOf('.') == -1) {
    txtEmail.innerHTML = "E-mail inválido"
    txtEmail.style.color = 'red'
    } else {
    txtEmail.innerHTML = "E-mail válido"
    txtEmail.style.color = 'green'
    }
}
