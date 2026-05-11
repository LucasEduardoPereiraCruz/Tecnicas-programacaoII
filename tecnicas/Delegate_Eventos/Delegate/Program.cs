

// SEGUNDA ETAPA
// Cria um delegate apontando para o método MeuMetodo
MeuDelegate del1 = new MeuDelegate(MeuMetodo);

// Forma resumida de fazer a mesma coisa acima
MeuDelegate del2 = MeuMetodo;

// Cria um delegate usando expressão lambda
// msg => parâmetro recebido
// Console.WriteLine(msg) => ação executada
MeuDelegate del3 = (msg) => Console.WriteLine(msg);





// TERCEIRA ETAPA
// Executa o método associado ao delegate usando Invoke
del1.Invoke("Minha mensagem 1");

// Outra forma de executar o delegate
del2("Minha mensagem 2");

// Executa o lambda associado ao delegate
del3("Minha mensagem 3");




// QUARTA ETAPA
// Método que será executado pelos delegates
static void MeuMetodo(string mensagem)
{
    // Exibe a mensagem recebida
    Console.WriteLine(mensagem);
}

// Aguarda uma tecla ser pressionada
Console.ReadKey();



// Primeira etapa
// Cria um delegate chamado MeuDelegate
// Ele só pode apontar para métodos que:
// - retornem void
// - recebam um parâmetro string
public delegate void MeuDelegate(string msg);