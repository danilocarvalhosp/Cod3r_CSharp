using System;
using Encapsulamento;

namespace CursoCSharp.OO
{
#pragma warning disable CS0436 // Conflitos de tipo com o tipo importado
    public class FilhoNaoReconhecido : SubCelebridade
#pragma warning restore CS0436 // Conflitos de tipo com o tipo importado
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNaoReconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            // Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            // Console.WriteLine(SegredoFamilia);
            // Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();
        public new void MeusAcessos()
        {
            Console.WriteLine("AmigoDistante...");

            Console.WriteLine(amiga.InfoPublica);
            // Console.WriteLine(amiga.CorDoOlho);
            // Console.WriteLine(amiga.NumeroCelular);
            // Console.WriteLine(amiga.JeitoDeFalar);
            // Console.WriteLine(amiga.SegredoFamilia);
            // Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }

    internal class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
