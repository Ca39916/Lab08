using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8
{
    public class Pessoa : IComparable<Pessoa> //interface IComparable utilizada para ordenaçao
    {
        private string meuNome;
        private int minhaIdade;
        public Pessoa(string n, int i)
        {
            meuNome = n;
            minhaIdade = i;
        }
        public string Nome
        {
            get { return meuNome; }
        }
        public int Idade
        {
            get { return minhaIdade; }
            set { minhaIdade = value; }
        }
        public int CompareTo(Pessoa outro) //implementaçao da interface Icomparable
        {
            return minhaIdade.CompareTo(outro.minhaIdade);
        }


    }
}
