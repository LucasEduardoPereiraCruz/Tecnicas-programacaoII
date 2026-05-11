// Tenta executar o método da classe A
try
{
    A.executandoA();
}

// Captura qualquer exceção gerada
catch (Exception ex)
{
    Console.WriteLine($"A exceção foi tratada na chamada de A: {ex.Message}");
}




// Classe A
class A
{
    public static void executandoA()
    {
        //try
        //{

        // Chama método da classe B
        B.executandoB();

        //}
        //catch (Exception ex)
        //{

        // Trataria exceção aqui caso estivesse descomentado
        //Console.WriteLine($"A exceção foi tratada em A: {ex.Message}");

        // }
    }
}




// Classe B
class B
{
    public static void executandoB()
    {
        //try
        //{

        // Chama método da classe C
        C.executandoC();

        // }

        // catch (Exception ex)
        //{

        // Trataria exceção aqui caso estivesse descomentado
        //Console.WriteLine($"A exceção foi tratada em B: {ex.Message}");

        //}
    }
}




// Classe C
class C
{
    public static void executandoC()
    {
        // Lança manualmente uma exceção
        // NotImplementedException = método ainda não implementado
        throw new NotImplementedException(
            "O método não foi implementado em C"
        );
    }
}