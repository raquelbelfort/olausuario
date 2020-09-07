using System;

namespace olausuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Olá, usuário! Por favor, digite seu nome:");
		    string nomeusuario = Console.ReadLine();
		    Console.Write("Seja bem-vindo(a), ");
            Console.WriteLine(nomeusuario);
        }
    }
}
