function validateForm() {
    var password = document.getElementById("password").value;
    var confirmPassword = document.getElementById("confirmPassword").value;
    var errorMessage = document.getElementById("errorMessage");

    if (password !== confirmPassword) {
        errorMessage.innerHTML = "As senhas não coincidem.";
        return false; // Impede o envio do formulário
    } else {
        errorMessage.innerHTML = ""; // Limpa a mensagem de erro, caso exista
        return true; // Permite o envio do formulário
    }
}
