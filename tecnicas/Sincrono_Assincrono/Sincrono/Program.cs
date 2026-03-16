Console.WriteLine("Café da manhã");
cafeDaManha();
Console.WriteLine("Fim do café da manhã");

static void cafeDaManha()
{
    Console.WriteLine("Preparar Café");
    var cafe = PrepararCafe();
    Console.WriteLine("\nPreparar o pão");
    var pao = PrepararPao();
    ServirCafe(cafe, pao);
}

static void ServirCafe(Cafe cafe, Pao pao)
{
    Console.WriteLine("\nServindo café da manhã");
    Thread.Sleep(2000);
    Console.WriteLine("\nCafé da manhã servido");
}
static Pao PrepararPao()
{
    Console.WriteLine("\n Partir o pão");
    Thread.Sleep(2000);
    Console.WriteLine("\n Passar manteiga");
    Thread.Sleep(2000);
    return new Pao();
}

static Cafe PrepararCafe()
{
    Console.WriteLine("\n Ferver água");
    Thread.Sleep(2000);
    Console.WriteLine("\n Coar o café");
    Thread.Sleep(2000);
    return new Cafe();
}

internal class Cafe
{

}

internal class Pao
{

}