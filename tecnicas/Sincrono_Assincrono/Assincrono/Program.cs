Console.WriteLine("Café da manhã Assincrono");
await cafeDaManhaAsync();
Console.WriteLine("Fim do café da manhã");

static async Task cafeDaManhaAsync()
{
    Console.WriteLine("Preparar Café");
    var TarefaCafe = PrepararCafeAsync();
    Console.WriteLine("\nPreparar o pão");
    var TarefaPao = PrepararPaoAsync();
    var cafe = await (TarefaCafe);
    var pao = await (TarefaPao);
    ServirCafeAsync(cafe, pao);
}

static void ServirCafeAsync(Cafe cafe, Pao pao)
{
    Console.WriteLine("\nServindo café da manhã");
    Thread.Sleep(2000);
    Console.WriteLine("\nCafé da manhã servido");
}
static async Task<Pao> PrepararPaoAsync()
{
    Console.WriteLine("\n Partir o pão");
    await Task.Delay(2000);
    Console.WriteLine("\n Passar manteiga");
    await Task.Delay(2000);
    return new Pao();
}

static async Task<Cafe> PrepararCafeAsync()
{
    Console.WriteLine("\n Ferver água");
    await Task.Delay(2000);
    Console.WriteLine("\n Coar o café");
    await Task.Delay(2000);
    return new Cafe();
}

internal class Cafe
{

}

internal class Pao
{

}
