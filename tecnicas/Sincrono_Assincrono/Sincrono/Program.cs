// Exibe mensagem inicial
Console.WriteLine("Café da manhã");


// Executa método síncrono
cafeDaManha();


// Exibe mensagem final
Console.WriteLine("Fim do café da manhã");




// Método principal do café da manhã
static void cafeDaManha()
{
    Console.WriteLine("Preparar Café");

    // Prepara café
    // O programa espera terminar
    var cafe = PrepararCafe();


    Console.WriteLine("\nPreparar o pão");

    // Prepara pão
    // Só executa após terminar o café
    var pao = PrepararPao();


    // Serve café da manhã
    ServirCafe(cafe, pao);
}




// Método para servir café
static void ServirCafe(Cafe cafe, Pao pao)
{
    Console.WriteLine("\nServindo café da manhã");

    // Pausa a thread por 2 segundos
    // Bloqueia execução
    Thread.Sleep(2000);

    Console.WriteLine("\nCafé da manhã servido");
}




// Método para preparar pão
static Pao PrepararPao()
{
    Console.WriteLine("\n Partir o pão");

    // Espera 2 segundos
    Thread.Sleep(2000);


    Console.WriteLine("\n Passar manteiga");

    // Espera mais 2 segundos
    Thread.Sleep(2000);


    // Retorna objeto pão
    return new Pao();
}




// Método para preparar café
static Cafe PrepararCafe()
{
    Console.WriteLine("\n Ferver água");

    // Espera 2 segundos
    Thread.Sleep(2000);


    Console.WriteLine("\n Coar o café");

    // Espera mais 2 segundos
    Thread.Sleep(2000);


    // Retorna objeto café
    return new Cafe();
}




// Classe Cafe
internal class Cafe
{

}




// Classe Pao
internal class Pao
{

}