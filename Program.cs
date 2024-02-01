using System;
using System.Reflection;
namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //var meuArray = new Teste[2] { new Teste(), new Teste() };
            var meuArray = new string[2] { "ola", "teste" };

            foreach (var item in meuArray)
            {
                Console.WriteLine(item);
            }


            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() { Id = 10, Name = "Gustavo" };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Name);
            }

        }

        public struct Funcionario
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }


    }
}