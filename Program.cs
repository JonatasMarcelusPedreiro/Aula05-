using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Condicoes
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade;





            Console.WriteLine(" Bem-vindo ao Conradito Auto");
            Console.Write(" Para começar, digite sua idade: ");
            idade= Int32.Parse(Console.ReadLine());


            Console.WriteLine($" Você tem {idade} anos!");


            if (idade >= 18)
            {
                Console.WriteLine(" Parabéns! Você ja pode tirar a CNH");


            }

            else
            {

                Console.WriteLine(" Você não tem idade suficiente ainda");

            }




            




            Console.ReadKey();

        }   




        void Revisao ()
        {

            string nome;
            int nascimento;
            string profissão;

            Console.WriteLine(" Bem-vindo ao cadastro de currículos nome");
            Console.WriteLine(" \n \n ");


            Console.WriteLine(" Para começar, digite seu primeiro nome");
            nome = Console.ReadLine();

            Console.WriteLine(" Digite o ano que você nasceu: ");
            nascimento = Int32.Parse(Console.ReadLine());

            Console.WriteLine(" Digite sua profissão: ");
            profissão = Console.ReadLine();

            Console.WriteLine(" \n \n ");

            Console.WriteLine(" Cadastro realizado com sucesso! \n ");

            Console.WriteLine($" Você se chama {nome} e tem {2023 - nascimento} anos \n");
            Console.WriteLine($" Vagas para: {profissão}");


            Console.ReadKey();













        }
    }
}
