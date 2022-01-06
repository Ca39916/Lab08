using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8
{
    internal class Pessoa2 : IComparer<Pessoa2>  // Interface IComparer ordena uma lista comparando os atributos 
    {
        public string meuNome { get; set; }
        public int minhaIdade { get; set; }
        public string ordenacao { get; set; } //atributo ordenacao ordena a variavel desejada

        public Pessoa2(string n, int i)
        {
            meuNome = n;
            minhaIdade = i;
        }
        public int Compare(Pessoa2 x, Pessoa2 y) //implementaçao da inteface IComparer
        {
            if (ordenacao == "Nome")
            {
                return x.meuNome.CompareTo(y.meuNome);
            }
            else
            {
                return x.minhaIdade.CompareTo(y.minhaIdade);
            }
        }

    }
        
}

       
           
      


    

