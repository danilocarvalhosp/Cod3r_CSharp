using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // ACESSADO POR TODOS
        public string InfoPublica = "Tenho um instagram!";

        // ACESSADO POR HERANÇA
        protected string CorDoOlho = "Verde";

        // ACESSADO NO MESMO PROJETO (MESMO ASSBEMLY)
        internal ulong NumeroCelular = 5511999999999;

        // ACESSADO POR HERANÇA OU NO MESMO PROJETO (MESMO ASSEMBLY)
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // ACESSADO NA MESMA CLASSE OU POR HERANÇA NO MESMO PROJETO
        private protected string SegredoFamilia = "Bla bla";

        // ACESSADO SOMENTE NA MESMA CLASSE
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
