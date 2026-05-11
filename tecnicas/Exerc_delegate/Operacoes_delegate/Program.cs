using System;


class Program
{
    // Delegate
    // Métodos precisam:
    // retornar double
    // receber dois doubles
    public delegate double Operacao(double a, double b);


    static void Main()
    {
        // Variável do tipo delegate
        Operacao op;


        // Valores para operações
        double x = 10;
        double y = 2;


        // Delegate aponta para método Somar
        op = Somar;

        // Executa soma
        Console.WriteLine("Soma: " + op(x, y));


        // Delegate aponta para método Subtrair
        op = Subtrair;

        // Executa subtração
        Console.WriteLine("Subtração: " + op(x, y));


        // Delegate aponta para método Multiplicar
        op = Multiplicar;

        // Executa multiplicação
        Console.WriteLine("Multiplicação: " + op(x, y));


        // Delegate aponta para método Dividir
        op = Dividir;

        // Executa divisão
        Console.WriteLine("Divisão: " + op(x, y));
    }



    // Método de soma
    static double Somar(double a, double b)
    {
        return a + b;
    }


    // Método de subtração
    static double Subtrair(double a, double b)
    {
        return a - b;
    }


    // Método de multiplicação
    static double Multiplicar(double a, double b)
    {
        return a * b;
    }


    // Método de divisão
    static double Dividir(double a, double b)
    {
        return a / b;
    }
}