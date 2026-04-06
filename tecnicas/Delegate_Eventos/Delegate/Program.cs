

// Segunda etapa
MeuDelegate del1 = new MeuDelegate(MeuMetodo);
MeuDelegate del2 = MeuMetodo;
MeuDelegate del3 = (msg) => Console.WriteLine(msg);

// Terceira etapa
del1.Invoke("Minha mensagem 1");
del2("Minha mensagem 2");
del3("Minha mensagem 3");

// Quarta etapa
static void MeuMetodo(string mensagem)
{
    Console.WriteLine(mensagem);
}
Console.ReadKey();

// Primeira etapa
public delegate void MeuDelegate(string msg);