// Função que altera os dados do ecrã dependendo do botão clicado
function ativarTecnologia(tipo) {
    // Seleciona os elementos do HTML
    const textoStatus = document.getElementById('status-texto');
    const textoAgua = document.getElementById('status-agua');
    const painelBox = document.getElementById('painel');

    // Estrutura Condicional (If / Else If) para decidir o resultado
    if (tipo === 'manual') {
        textoStatus.innerText = "Crítico (Baixo Equilíbrio)";
        textoStatus.style.color = "red";
        textoAgua.innerText = "0% (Desperdício Alto)";
        painelBox.style.borderColor = "red";
    } 
    else if (tipo === 'sensor') {
        textoStatus.innerText = "Bom (Equilíbrio Moderado)";
        textoStatus.style.color = "orange";
        textoAgua.innerText = "35% de Economia";
        painelBox.style.borderColor = "orange";
    } 
    else if (tipo === 'drone') {
        textoStatus.innerText = "Excelente (Futuro Sustentável)";
        textoStatus.style.color = "green";
        textoAgua.innerText = "60% de Economia";
        painelBox.style.borderColor = "green";
    }
}
