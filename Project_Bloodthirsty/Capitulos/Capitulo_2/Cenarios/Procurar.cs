using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Project_Bloodthirsty.Capitulos.Capitulo_2.Cenarios
{
    internal class Procurar
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
        static public void Procurando()
        {
            Console.Clear();
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                 ( 20:40 )");
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.ReadKey();

            Console.WriteLine("                                    - Kevin - Eu vou atrás desses muleques.");
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.ReadKey();
            Console.WriteLine("                           - Kevin - Me resta agora somente a porta atrás da escada.");
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("                                          Você entra na porta ( ... ) ");
            AbrirPorta.PlaySync();
            Console.WriteLine("                                                     ");

            Som2.PlayLooping();
            Console.WriteLine("                            Ao entrar você vê Jessie desmaiada escostada no fim do corredor.");
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.ReadKey();

            bool game = true;
            while (game)
            {
                Console.WriteLine("                                                     ");
                Console.Clear();
                Console.WriteLine("                                          Você vê duas opções:");
                Console.WriteLine("                                                     ");
                Console.WriteLine("                                                Acorda-la         ( 1 )");
                Console.WriteLine("                                           Leva-la para o saguão  ( 2 )");

                int Escolha = int.Parse(Console.ReadLine());
                
                if(Escolha == 1)
                {
                    Console.Clear();
                    Console.WriteLine("                                                     ");
                    Console.WriteLine("                                              Jessie acorda ( ... ) ");
                    Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
                    Console.ReadKey();

                    Console.WriteLine("                                                     ");
                    Console.WriteLine("                     - Kevin - O que houve? Você por acaso tropeçou naquele piso quebrado? ");
                    Console.WriteLine("                                                     ");
                    Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
                    Console.ReadKey();
                }
            } 
            
        }
    }
}
