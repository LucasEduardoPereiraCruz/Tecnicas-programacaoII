try
{
    Console.WriteLine("Digite o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine()); // Readline sempre pega como string 


    Console.WriteLine("Digite o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    var resultado = dividendo / divisor;

    Console.WriteLine($"o resultado de {dividendo}/{divisor} = {resultado}");
}

/*catch(FormatException)
{
    Console.WriteLine("Entre com um valor inteiro");
}*/

catch (Exception ex) when (ex.Message.Contains("format"))  
{
    Console.WriteLine("Entre com um valor inteiro - when: {ex.Message}");
}

catch (DivideByZeroException)
{
    Console.WriteLine("Divisor não pode ser zero");
}

catch (Exception ex)
{
    Console.WriteLine($"Problema na divisão: {ex.Message}");
}

finally 
{
    Console.WriteLine("Acabou a divisão");
}