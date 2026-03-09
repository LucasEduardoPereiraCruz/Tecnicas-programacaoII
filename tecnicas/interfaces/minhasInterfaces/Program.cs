IAnimal animal1 = new Cachorro();

IAnimal animal2 = new Gato();

animal1.FazerSom();
animal2.FazerSom();

Cachorro animal3 = new Cachorro();
animal3.QuantidadePatas();


public interface IAnimal
{
    public void FazerSom();
}


public class Cachorro : IAnimal
{
    public void FazerSom()
    {
        Console.WriteLine("Auaauauau");
    }

    public void QuantidadePatas()
    {
        Console.WriteLine("Tem 4 patas");
    }
}


public class Gato : IAnimal
{
    public void FazerSom()
    {
        Console.WriteLine("Miauuuuuuu");
    }
}