using System;

// Classe principal do ar condicionado
class ArCondicionado
{
    // Temperatura atual
    // private set = só pode alterar dentro da classe
    public double Temperatura { get; private set; }

    // Limite máximo permitido
    public double LimiteSuperior { get; set; }

    // Limite mínimo permitido
    public double LimiteInferior { get; set; }


    // Delegate do evento
    // Métodos inscritos precisam receber um double
    public delegate void AlarmeTemperaturaHandler(double temperatura);


    // Evento baseado no delegate
    public event AlarmeTemperaturaHandler AlarmeTemperatura;


    // Método para alterar temperatura
    public void AjustarTemperatura(double novaTemp)
    {
        // Atualiza temperatura atual
        Temperatura = novaTemp;


        // Verifica se temperatura saiu dos limites
        if (Temperatura > LimiteSuperior || Temperatura < LimiteInferior)
        {
            // Dispara o evento
            // ?.Invoke verifica se existe alguém inscrito
            AlarmeTemperatura?.Invoke(Temperatura);
        }
    }

} // Fim da classe ArCondicionado 




// Classe responsável por mostrar alerta
class Monitor
{
    // Método executado quando o evento ocorrer
    public void ExibirAlerta(double temperatura)
    {
        Console.WriteLine(
            "ALERTA! Temperatura fora do limite: " + temperatura
        );
    }

} // Fim da classe Monitor 




class Program
{
    // Main inicia o programa
    static void Main()
    {
        // Cria objeto ArCondicionado
        ArCondicionado ar = new ArCondicionado();

        // Cria objeto Monitor
        Monitor monitor = new Monitor();


        // Define limite máximo
        ar.LimiteSuperior = 25;

        // Define limite mínimo
        ar.LimiteInferior = 18;


        // Inscreve método no evento
        ar.AlarmeTemperatura += monitor.ExibirAlerta;


        // Temperatura normal
        // Não dispara alerta
        ar.AjustarTemperatura(20);

        // Temperatura acima do limite
        // Dispara evento
        ar.AjustarTemperatura(30);

        // Temperatura abaixo do limite
        // Dispara evento
        ar.AjustarTemperatura(15);


        // Aguarda tecla
        Console.ReadKey();
    }
}