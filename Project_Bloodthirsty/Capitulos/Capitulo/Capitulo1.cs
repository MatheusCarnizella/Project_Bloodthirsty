using Project_Bloodthirsty.Capitulos.Capitulo.Cenarios;
using Project_Bloodthirsty.Capitulos.Capitulo_2;
using Project_Bloodthirsty.Finais;
using Project_Bloodthirsty.SFXUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Project_Bloodthirsty.Capitulos
{
    internal class Capitulo1
    {

        static public void C1()
        {

            Console.Clear();
            Console.WriteLine("                                                                                         ");
            Console.WriteLine("                                             CAPÍTULO 1: MANSÃO GELADA ( 20:01 )");
            //Porta.PlaySync();
            SFXUtility.GetSpecificSoundPlayerSFX("Porta").PlaySync();


            Console.Clear();
            //FundoAmbiente.PlayLooping();
            SFXUtility.GetSpecificSoundPlayerSFX("FundoAmbiente").PlayLooping();
            Console.WriteLine("                                                     ");
            Console.WriteLine("                               - Kevin - Então essa é a mansão!!?? Não me parece grandes coisas.");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.WriteLine("                                                     ");
            Console.ReadKey();
            Console.WriteLine("                  - Jessie - Imagine quanta história não há aqui!!! Acho que vou dar um volta pelos quartos.");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.WriteLine("                                                     ");
            Console.ReadKey();
            Console.WriteLine("                            - Kevin - Você quem sabe parceira. Só não esquece a lanterna, esperta.");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.WriteLine("                                                     ");
            Console.ReadKey();
            Console.WriteLine("                        - Max - Ficou maluco cara? A casa é enorme, você pode literalmente se perder!!");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.WriteLine("                                                     ");
            Console.ReadKey();
            Console.WriteLine("                                                   - Kevin / Jessie - MEDROSO!!!!");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.WriteLine("                                                     ");
            Console.ReadKey();
            Console.WriteLine("                                                    - Jessie - Até daqui a pouco.");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.WriteLine("                                                     ");
            Console.ReadKey();

            DescerEscada.Descer();
                       
        }
        static public void C1_1()
        {
            Console.Clear();
            //FundoAmbiente.PlayLooping();
            SFXUtility.GetSpecificSoundPlayerSFX("FundoAmbiente").PlayLooping();
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                          ( 20:15 )");
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                 Na sua frente há um corredor.");
            Console.WriteLine("                                   Você percebe que a maioria das portas estão com barricadas.");
            Console.WriteLine("                                   Sobram exatemente duas portas e um criado mudo no corredor.");

            bool game = true;
            while (game == true)
            {
                Console.WriteLine("                                                     ");
                Console.WriteLine("                                                         Porta número 1   ( 1 )");
                Console.WriteLine("                                                         Porta número 2   ( 2 )");
                Console.WriteLine("                                                           Criado mudo    ( 3 )");
                Console.WriteLine("                                                                                 ");
                Console.WriteLine("                                                          Sua escolha é: ");

                int Pergunta = int.Parse(Console.ReadLine());

                if (Pergunta == 1)
                {
                    Porta1.PortaA();
                    Console.Clear();
                    Console.WriteLine("                                                          ");
                    Console.WriteLine("                                      - Kevin - Que estranho. Melhor voltar e avisar a todos.");
                    Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
                    Console.WriteLine("                                                          ");
                    Console.ReadKey();
                    Console.WriteLine("                                             - Kevin - Antes vou verificar a outra porta.");
                    Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
                    Console.WriteLine("                                                          ");
                    Console.ReadKey();

                    Console.Clear();
                    Console.WriteLine("                                                          ");
                    Console.WriteLine("                                                         Porta número 2   ( 2 )");
                    Console.WriteLine("                                                           Criado mudo    ( 3 )");
                    Console.WriteLine("                                                                                 ");
                    Console.WriteLine("                                                          Sua escolha é: ");

                    int Pergunta2 = int.Parse(Console.ReadLine());

                    if (Pergunta2 == 2)
                    {
                        Porta2.PortaB();
                        Console.Clear();
                        Console.WriteLine("                                                          ");
                        Console.WriteLine("                                                       Criado mudo    ( 3 )");
                        Console.WriteLine("                                                                                 ");
                        Console.WriteLine("                                                          Sua escolha é: ");

                        int Pergunta3 = int.Parse(Console.ReadLine());

                        if (Pergunta3 == 3)
                        {
                            CriadoMudo.CriadoMudoA();
                            Console.Clear();
                            break;
                        }
                    }
                    if (Pergunta2 == 3)
                    {
                        CriadoMudo.CriadoMudoA();
                        Console.Clear();
                        Console.WriteLine("                                                          ");
                        Console.WriteLine("                                                      Porta número 2   ( 2 )");
                        Console.WriteLine("                                                                                 ");
                        Console.WriteLine("                                                          Sua escolha é: ");

                        int Pergunta3 = int.Parse(Console.ReadLine());

                        if (Pergunta3 == 2)
                        {
                            Porta2.PortaB();
                            Console.Clear();
                            break;
                        }
                    }
                }
                if (Pergunta == 2)
                {
                    Porta2.PortaB();
                    Console.Clear();
                    Console.WriteLine("                                                          ");
                    Console.WriteLine("                                                         Porta número 1   ( 1 )");
                    Console.WriteLine("                                                           Criado mudo    ( 3 )");
                    Console.WriteLine("                                                                                 ");
                    Console.WriteLine("                                                          Sua escolha é: ");

                    int Pergunta3 = int.Parse(Console.ReadLine());

                    if (Pergunta3 == 1)
                    {
                        Porta1.PortaA();
                        Console.Clear();
                        Console.WriteLine("                                                          ");
                        Console.WriteLine("                                      - Kevin - Que estranho. Melhor voltar e avisar a todos.");
                        Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
                        Console.WriteLine("                                                          ");
                        Console.ReadKey();
                        Console.ReadKey();
                        Console.WriteLine("                                             - Kevin - Antes vou verificar o criado mudo.");
                        Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
                        Console.WriteLine("                                                          ");
                        Console.ReadKey();

                        Console.Clear();
                        Console.WriteLine("                                                          ");
                        Console.WriteLine("                                                           Criado mudo    ( 3 )");
                        Console.WriteLine("                                                                                 ");
                        Console.WriteLine("                                                          Sua escolha é: ");

                        int Pergunta2 = int.Parse(Console.ReadLine());

                        if (Pergunta2 == 3)
                        {
                            CriadoMudo.CriadoMudoA();
                            Console.Clear();
                            break;
                        }
                    }
                    if (Pergunta3 == 3)
                    {
                        CriadoMudo.CriadoMudoA();
                        Console.Clear();
                        Console.WriteLine("                                                          ");
                        Console.WriteLine("                                                         Porta número 1   ( 1 )");
                        Console.WriteLine("                                                                                 ");
                        Console.WriteLine("                                                          Sua escolha é: ");

                        int Pergunta2 = int.Parse(Console.ReadLine());

                        if (Pergunta2 == 1)
                        {
                            Console.Clear();
                            Porta1.PortaA();
                            Console.WriteLine("                                                          ");
                            Console.WriteLine("                                      - Kevin - Que estranho. Melhor voltar e avisar a todos.");
                            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
                            Console.WriteLine("                                                          ");
                            break;
                        }

                    }
                }
                if (Pergunta == 3)
                {
                    CriadoMudo.CriadoMudoA();
                    Console.Clear();
                    Console.WriteLine("                                                          ");
                    Console.WriteLine("                                                      Porta número 1   ( 1 )");
                    Console.WriteLine("                                                      Porta número 2   ( 2 )");
                    Console.WriteLine("                                                                                 ");
                    Console.WriteLine("                                                          Sua escolha é: ");

                    int Pergunta3 = int.Parse(Console.ReadLine());

                    if (Pergunta3 == 1)
                    {
                        Porta1.PortaA();
                        Console.Clear();
                        Console.WriteLine("                                                          ");
                        Console.WriteLine("                                      - Kevin - Que estranho. Melhor voltar e avisar a todos.");
                        Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
                        Console.WriteLine("                                                          ");
                        Console.ReadKey();
                        Console.WriteLine("                                             - Kevin - Antes vou verificar a outra porta.");
                        Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
                        Console.WriteLine("                                                          ");
                        Console.ReadKey();

                        Console.Clear();
                        Console.WriteLine("                                                         Porta número 2   ( 2 )");
                        Console.WriteLine("                                                                                 ");
                        Console.WriteLine("                                                          Sua escolha é: ");

                        int Pergunta2 = int.Parse(Console.ReadLine());

                        if (Pergunta2 == 2)
                        {
                            Porta2.PortaB();
                            Console.Clear();
                            break;
                        }
                    }
                    if (Pergunta3 == 2)
                    {
                        Porta2.PortaB();
                        Console.Clear();

                        Console.Clear();
                        Console.WriteLine("                                                          ");
                        Console.WriteLine("                                                         Porta número 1   ( 1 )");
                        Console.WriteLine("                                                                                 ");
                        Console.WriteLine("                                                          Sua escolha é: ");

                        int Pergunta2 = int.Parse(Console.ReadLine());

                        if (Pergunta2 == 1)
                        {
                            Porta1.PortaA();
                            Console.Clear();
                            Console.WriteLine("                                                          ");
                            Console.WriteLine("                                      - Kevin - Que estranho. Melhor voltar e avisar a todos.");
                            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
                            Console.WriteLine("                                                          ");
                            Console.ReadKey();
                            break;
                        }
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                          ( 20:34 )");
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                   Você decide voltar para o saguão e contar o que descobriu.");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.ReadKey();

            Console.Clear();
            //Grito1.PlaySync();
            SFXUtility.GetSpecificSoundPlayerSFX("GritoAssombrado").PlaySync();
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                          ( 20:35 )");
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                       FIM DO CAPÍTULO 1");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.ReadKey();

            Capitulo2.C2();
        }
    }
}
