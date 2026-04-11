using System; 

// Classe Principal
class ArCondicionado
{
    public double Temperatura {  get; private set; } 
    public double LimiteSuperior { get; set; }
    public double LimiteInferior { get; set; }

    // Delegate do evento 
    public delegate void AlarmeTemperaturaHandler(double temperatura);

    // Evento 
    public event AlarmeTemperaturaHandler AlarmeTemperatura;

    // Método para alterar a temperatura 
    public void AjustarTemperatura (double novaTemp)
    {
        Temperatura = novaTemp;

        if(Temperatura > LimiteSuperior || Temperatura < LimiteInferior)
        {
            //Dispara o alarme 
            AlarmeTemperatura?.Invoke(Temperatura);
        }
    }
} // Fim da classe ArCondicionado 

class Monitor
{
    public void ExibirAlerta(double temperatura)
    {
        Console.WriteLine("ALERTA! Temperatura fora do limite: " + temperatura);
    }
} // Fim da classe Monitor 

class Program
{
    // O main inicia o programa, conecta as classes e faz elas trabalharem juntas
    static void Main()
    {
        ArCondicionado ar = new ArCondicionado();
        Monitor monitor = new Monitor();

        ar.LimiteSuperior = 25;
        ar.LimiteInferior = 18;

        // Se inscreve no evento 
        ar.AlarmeTemperatura += monitor.ExibirAlerta;

        ar.AjustarTemperatura(20);
        ar.AjustarTemperatura(30);
        ar.AjustarTemperatura(15);

        Console.ReadKey();
    }       
}
