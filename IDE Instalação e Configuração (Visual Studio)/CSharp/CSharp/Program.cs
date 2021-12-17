using System;
using Interface;
using Enum;



namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Edu;
            Pessoas pessoa3 = Pessoas.Carlos;
            var pessoa4 = (Pessoas)5;


            Pessoa persion = new Pessoa();

            persion.Nome = "Edu";
            persion.Idade = 18;
            persion.Estado = "SP";

            var persion2 = new Pessoa();
            persion2.Nome = "Carlos";
            persion2.Idade = 30;
            persion2.Estado = "PA";

            Animal animal = new Animal();
            animal.Nome = "Toto";
            animal.Nome = "Carlos";
            animal.Especie = "Cachorro";


            Console.WriteLine(persion.Idade);
            Console.WriteLine(animal.Especie);
            Console.WriteLine(pessoa3); 
        }
    }
}
