using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Project_Bloodthirsty.Finais
{
    internal class Finalcovarde
    {
        static SoundPlayer Melancolia = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\MELANCOLIA.wav"); 
        static public void Finalfuga()
        {
            Console.Clear();
            Melancolia.Play();
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                  FINAL DO COVARDE");
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                           VOCÊ SOBREVIVE, MAS A QUE PREÇO?");
            Console.WriteLine("                                                PERDEU TODOS OS AMIGOS.");
            Console.WriteLine("                                          COMO VOCÊ DARÁ ESSA NOTICIA A TODOS?");
            Console.WriteLine("                                        COMO VOCÊ DIRÁ QUE FOI COVARDE E EGOÍSTA?");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.ReadKey();

            Bloodthirsty.Main();
        }
    }
}
