using System;

namespace Laboratorio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lista = { "Gustavo", "Danilo", "Matheus", "Odin" };
            Console.WriteLine("Array antes da ordenacao");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i] + " ");
            }
            Console.WriteLine();
            Array.Sort(lista); //chama método compareTo
            Console.WriteLine("Array depois da ordenacao");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i] + " ");
                Console.ReadKey();
            }

            Console.WriteLine();
            Pessoa[] lista2 = {new Pessoa("Jose", 25),new Pessoa("Ana", 28),new Pessoa("Paulo", 20)};
            Array.Sort(lista2);//chama método compareTo
            Console.ReadKey();
            Console.WriteLine("Array depois da ordenacao");
            for (int i = 0; i < lista2.Length; i++) //length calcula o tamanho da lista e nao preciso colocar o numero exato das linhas da lista
            {
                Console.WriteLine(lista2[i].Nome + " ");
                Console.ReadKey();
            }


            Console.WriteLine();
            Console.WriteLine("------ Execício 3.1 ------");
            Pessoa[] lista3 = { new Pessoa("Jose", 25), new Pessoa("Ana", 28), new Pessoa("Paulo", 20) };
            Array.Sort(lista3); //chama método compareTo
            Console.ReadKey();
            Console.WriteLine("Array depois da ordenacao");
            for (int i = 0; i < lista3.Length; i++)
            {
                Console.WriteLine(lista3[i].Nome + " " + lista3[i].Idade);
                Console.ReadKey();
            }

            Console.WriteLine("------ Execício 3.2 ------");
            //Não é possivel usar a interface Icomparable para ordenar duas colunas diferentes

            Console.WriteLine();
            Console.WriteLine("------ Execício 3.3 ------");
            //Array ordenado por Nome
            Pessoa2[] lista4 = { new Pessoa2("Jose", 25), new Pessoa2("Ana", 28), new Pessoa2("Paulo", 20) };
            Pessoa2 P2 = new Pessoa2("",0); 
            P2.ordenacao = "Nome"; //p2 variavel que recebe a ordenaçao desejada
            Array.Sort(lista4, P2); //chama método Compare
            Console.ReadKey();
            Console.WriteLine("Array ordenado por Nome");
            for (int i = 0; i < lista4.Length; i++)
            {
                Console.WriteLine(lista4[i].meuNome + " " + lista4[i].minhaIdade);
                Console.ReadKey();
            }

            Console.WriteLine();
            //Array ordenado por idade
            P2.ordenacao = "Idade"; //p2 variavel que recebe a ordenaçao desejada
            Array.Sort(lista4, P2); //chama método Compare
            Console.ReadKey();
            Console.WriteLine("Array ordenado pela Idade");
            for (int i = 0; i < lista4.Length; i++)
            {
                Console.WriteLine(lista4[i].meuNome + " " + lista4[i].minhaIdade);
                Console.ReadKey();
            }
        }   
    }
}
