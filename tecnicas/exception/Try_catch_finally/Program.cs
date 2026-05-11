// Tenta executar o bloco de código
try
{
    // Solicita o dividendo
    Console.WriteLine("Digite o dividendo");

    // Lê valor digitado
    // ReadLine sempre retorna string
    int dividendo = Convert.ToInt32(Console.ReadLine());


    // Solicita divisor
    Console.WriteLine("Digite o divisor");

    // Converte entrada para inteiro
    int divisor = Convert.ToInt32(Console.ReadLine());


    // Realiza divisão
    var resultado = dividendo / divisor;


    // Exibe resultado
    Console.WriteLine($"o resultado de {dividendo}/{divisor} = {resultado}");
}



/*catch(FormatException)
{
    // Trataria erro de formato
    Console.WriteLine("Entre com um valor inteiro");
}*/



// Captura exceções cuja mensagem contém "format"
catch (Exception ex) when (ex.Message.Contains("format"))
{
    Console.WriteLine("Entre com um valor inteiro - when: {ex.Message}");
}



// Captura divisão por zero
catch (DivideByZeroException)
{
    Console.WriteLine("Divisor não pode ser zero");
}



// Captura qualquer outro erro
catch (Exception ex)
{
    Console.WriteLine($"Problema na divisão: {ex.Message}");
}



// Sempre executa
finally
{
    Console.WriteLine("Acabou a divisão");
}