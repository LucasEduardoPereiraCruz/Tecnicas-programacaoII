// Exibe mensagem inicial
Console.WriteLine("Café da manhã Assincrono");


// Executa método assíncrono
// await espera a tarefa terminar
await cafeDaManhaAsync();


// Exibe mensagem final
Console.WriteLine("Fim do café da manhã");




// Método assíncrono
// async = permite usar await
// Task = representa tarefa assíncrona
static async Task cafeDaManhaAsync()
{
    Console.WriteLine("Preparar Café");

    // Inicia preparação do café SEM esperar terminar
    var TarefaCafe = PrepararCafeAsync();


    Console.WriteLine("\nPreparar o pão");

    // Inicia preparação do pão SEM esperar terminar
    var TarefaPao = PrepararPaoAsync();


    // await espera a tarefa do café finalizar
    var cafe = await (TarefaCafe);

    // await espera a tarefa do pão finalizar
    var pao = await (TarefaPao);


    // Serve café da manhã
    ServirCafeAsync(cafe, pao);
}




// Método para servir café
static void ServirCafeAsync(Cafe cafe, Pao pao)
{
    Console.WriteLine("\nServindo café da manhã");

    // Pausa a thread por 2 segundos
    Thread.Sleep(2000);

    Console.WriteLine("\nCafé da manhã servido");
}




// Método assíncrono que prepara pão
static async Task<Pao> PrepararPaoAsync()
{
    Console.WriteLine("\n Partir o pão");

    // Espera 2 segundos sem bloquear a thread
    await Task.Delay(2000);


    Console.WriteLine("\n Passar manteiga");

    // Espera mais 2 segundos
    await Task.Delay(2000);


    // Retorna objeto pão
    return new Pao();
}




// Método assíncrono que prepara café
static async Task<Cafe> PrepararCafeAsync()
{
    Console.WriteLine("\n Ferver água");

    // Espera 2 segundos
    await Task.Delay(2000);


    Console.WriteLine("\n Coar o café");

    // Espera mais 2 segundos
    await Task.Delay(2000);


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