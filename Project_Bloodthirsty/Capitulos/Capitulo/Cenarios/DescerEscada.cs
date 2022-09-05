using Project_Bloodthirsty.Finais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Project_Bloodthirsty.Capitulos.Capitulo.Cenarios
{
    internal class DescerEscada
    {
        static SoundPlayer Som = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\FUNDO MUSICAL WAV.wav");
        static SoundPlayer Som2 = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\FUNDO AMBIENTE.wav");
        static SoundPlayer Som3 = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\SOM DE PASSOS.wav");
        static SoundPlayer Porta = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\PORTA.wav");
        static SoundPlayer Vidro = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\VIDRO.wav");
        static SoundPlayer Grito1 = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\GRITO ASSOMBRADO.wav");
        static SoundPlayer AbrirPorta = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\PORTA ABRINDO SEM CHAVE.wav");
        static SoundPlayer ChavePorta = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\PORTA ABRINDO COM CHAVE.wav");
        static SoundPlayer Correndo = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\CORRENDO.wav");
        static public void Descer()
        {
            Console.Clear();
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                           (  20:11  )");
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                               Você decide andar pelo lugar também.");
            Console.WriteLine("                                                    Há cinco opões para seguir:");
            Console.WriteLine("                                                     ");
            Descer1();
        }
        static public void Descer1()
        {         
            bool game = true;
            while (game = true)
            {
                Console.WriteLine("                                                     ");
                Console.WriteLine("                                                         Subir escada       ( 1 )");
                Console.WriteLine("                                                        Porta da direita    ( 2 )");
                Console.WriteLine("                                                        Porta da esquerda   ( 3 )");
                Console.WriteLine("                                                      Porta atrás da escada ( 4 )");
                Console.WriteLine("                                                        Porta da frente     ( 5 )");
                Console.WriteLine("                                                                                 ");
                Console.WriteLine("                                                          Sua escolha é: ");

                int Pergunta = int.Parse(Console.ReadLine());

                if (Pergunta == 1)
                {
                    Console.Clear();
                    Console.WriteLine("                                                     ");
                    Console.WriteLine("                                                   Subindo a escada ( ... )");
                    Som3.PlaySync();

                    Console.Clear();
                    Descer2();
                    Console.Clear();
                    Vidro.PlaySync();
                    Console.WriteLine("                                                     ");
                    Console.WriteLine("                                        Você sobe a escada e uma lâmpada estoura.");
                    Console.WriteLine("                           Isso o deixa assustado, mas quer continuar procurando pelos quartos.");
                    Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
                    Console.ReadKey();
                    Console.Clear();

                    Capitulo1.C1_1();
                }
                else if (Pergunta == 2)
                {
                    Console.Clear();
                    Som3.PlaySync();
                    Console.WriteLine("                                                     ");
                    Console.WriteLine("                                        A porta esta com a maçaneta quebrada.");
                    Console.WriteLine("                                             Ela não se abre forçando-a.");
                    Console.WriteLine("                                Então você volta e tenta outra das opções restantes.");
                    Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Pergunta == 3)
                {
                    Console.Clear();
                    Som3.PlaySync();
                    Console.WriteLine("                                                     ");
                    Console.WriteLine("                                               A porta esta trancada.");
                    Console.WriteLine("                                      Na fechadura há um desenho de Lua gravado.");
                    Console.WriteLine("                                           A porta não se abre forçando-a.");
                    Console.WriteLine("                                Então você volta e tenta outra das opções restantes.");
                    Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Pergunta == 4)
                {
                    Console.Clear();
                    Console.WriteLine("                                                     ");
                    Console.WriteLine("                                                 Jessie escolheu esta porta.");
                    Console.WriteLine("                                                    Escolha outra opção.");
                    Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Pergunta == 5)
                {
                    Console.Clear();
                    Correndo.PlaySync();
                    Console.WriteLine("                                                     ");
                    Console.WriteLine("                                                          ( 20:15 )");
                    Console.WriteLine("                                                     ");
                    Console.WriteLine("                                                    Você foge acovardado.");
                    Console.WriteLine("                                               E deixa seus amigos para morrer.");
                    Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
                    Console.ReadKey();
                    Finalcovarde.Finalfuga();
                }
            }                        
        }
        static public void Descer2()
        {
            Console.Clear();
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                   Você subiu a escada ( ... )");
            Console.WriteLine("                                                     ");

            bool game = true;
            while(game == true)
            {
                Console.WriteLine("                                                    Deseja descer e ver mais?");
                Console.WriteLine("                                                            Sim ( 1 )");
                Console.WriteLine("                                                            Não ( 2 )");

                int Descer = int.Parse(Console.ReadLine());
                Console.Clear();

                if (Descer == 1)
                {
                    Console.WriteLine("                                                     ");
                    Console.WriteLine("                                                     Descendo a escada ( ... )");
                    Som3.PlaySync();

                    Console.Clear();
                    DescerEscada.Descer1();
                }

                if (Descer == 2)
                {
                    break;
                }
            }           
        }
    }
}
