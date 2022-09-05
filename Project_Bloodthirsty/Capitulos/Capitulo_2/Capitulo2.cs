using Project_Bloodthirsty.Capitulos.Capitulo_2.Cenarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Project_Bloodthirsty.Capitulos.Capitulo_2
{
    internal class Capitulo2
    {
        static SoundPlayer Som = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\FUNDO MUSICAL WAV.wav");
        static SoundPlayer Som2 = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\FUNDO AMBIENTE.wav");
        static SoundPlayer Som3 = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\SOM DE PASSOS.wav");
        static SoundPlayer Porta = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\PORTA.wav");
        static SoundPlayer Vidro = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\VIDRO.wav");
        static SoundPlayer Grito1 = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\GRITO ASSOMBRADO.wav");
        static SoundPlayer Relogio = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\Relogio.wav");
        static SoundPlayer TicTac = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\TIC TAC.wav");
        static SoundPlayer Correndo = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\CORRENDO.wav");
        static SoundPlayer AbrirPorta = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\PORTA ABRINDO SEM CHAVE.wav");
        static SoundPlayer ChavePorta = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\PORTA ABRINDO COM CHAVE.wav");
        static public void C2()
        {
            Console.Clear();
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                           CAPITULO 2: GRITO  ( 20:35 )");
            TicTac.PlaySync();


            Console.WriteLine("                                                     ");
            Console.WriteLine("                        Você se assusta com o grito e corre de volta para o saguão ( ... )");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.ReadKey();
            Console.Clear();

            Correndo.PlaySync();
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                 (  20:36  )");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.ReadKey();

            Som2.Play();
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                        - Kevin - Mas que porr* foi essa?");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.WriteLine("                                                     ");
            Console.ReadKey();
            Console.WriteLine("                                            (  Você olha em volta ...  )");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.ReadKey();
            Console.WriteLine("                                                     ");
            Console.WriteLine("                          - Kevin - E cadê todo mundo? Essa não é hora de ficarem por ai!");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.WriteLine("                                                     ");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                 ( 20:37 )");
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                       Você não sabe por onde começar.");
            Console.WriteLine("                                     Então resolve procurar seus amigos.");
            Console.WriteLine("                                            Mas não tem certeza.");
            Console.WriteLine("                                                     ");

            bool game = true;
            while (game == true)
            {
                Console.WriteLine("                                            Deseja procura-los? ( 1 )");
                Console.WriteLine("                                              Deseja esperar?   ( 2 )");
                Console.WriteLine("                                                     ");

                int Procura = int.Parse(Console.ReadLine());
                if (Procura == 1)
                {
                    Procurar.Procurando();
                }
                else if (Procura == 2)
                {

                }
            }                       
        }
    }
}
