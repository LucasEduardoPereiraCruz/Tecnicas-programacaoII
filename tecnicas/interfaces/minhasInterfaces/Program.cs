// Cria um objeto Cachorro usando a interface IAnimal
// Só será possível acessar métodos da interface
IAnimal animal1 = new Cachorro();


// Cria um objeto Gato usando a interface IAnimal
IAnimal animal2 = new Gato();


// Executa o método FazerSom do Cachorro
animal1.FazerSom();


// Executa o método FazerSom do Gato
animal2.FazerSom();


// Cria objeto diretamente do tipo Cachorro
// Agora é possível acessar métodos próprios da classe
Cachorro animal3 = new Cachorro();


// Executa método exclusivo da classe Cachorro
animal3.QuantidadePatas();




// Interface IAnimal
// Interface define regras que as classes devem seguir
public interface IAnimal
{
    // Método obrigatório para quem implementar a interface
    public void FazerSom();
}




// Classe Cachorro implementando a interface IAnimal
public class Cachorro : IAnimal
{
    // Implementação obrigatória do método FazerSom
    public void FazerSom()
    {
        Console.WriteLine("Auaauauau");
    }

    // Método exclusivo da classe Cachorro
    public void QuantidadePatas()
    {
        Console.WriteLine("Tem 4 patas");
    }
}




// Classe Gato implementando a interface IAnimal
public class Gato : IAnimal
{
    // Implementação obrigatória do método FazerSom
    public void FazerSom()
    {
        Console.WriteLine("Miauuuuuuu");
    }
}