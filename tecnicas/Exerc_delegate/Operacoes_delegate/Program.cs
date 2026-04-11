using System;

class Program
{
    // Primeira etapa
    public delegate double Operacao(double a, double b);

    static void Main()
    {
        Operacao op;

        double x = 10;
        double y = 2;

        op = Somar;
        Console.WriteLine("Soma: " + op(x, y));

        op = Subtrair;
        Console.WriteLine("Subtração: " + op(x, y));

        op = Multiplicar;
        Console.WriteLine("Multiplicação: " + op(x, y));

        op = Dividir;
        Console.WriteLine("Divisão: " + op(x, y));
    }

    static double Somar(double a, double b)
    {
        return a + b;
    }

    static double Subtrair(double a, double b)
    {
        return a - b;
    }

    static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    static double Dividir(double a, double b)
    {
        return a / b;
    }
}
