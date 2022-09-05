using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Bloodthirsty.Capitulos;
using Project_Bloodthirsty.Capitulos.Capitulo_2;
using Project_Bloodthirsty.Contexto;

namespace Project_Bloodthirsty
{
    internal class Bloodthirsty
    {
        enum MENU { New = 1, Load, Options}        
        static public void Main()
        {
            Console.Clear();   
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                        ATENÇÃO");
            Console.WriteLine("                                                 ");
            Console.WriteLine("                                        JOGO DESENVOLVIDO PELA VOIIDDE_G_STUDIO");
            Console.WriteLine("                                          SE TEM PROBLEMAS DE SAUDE NÃO JOGUE");
            Console.WriteLine("                                    JOGO BASEADO EM ESCOLHAS E TEXTOS PRE-DEFINIDOS");
            Console.WriteLine("                           LEMBRE-SE CADA ESCOLHA É UMA AÇÃO FIXA. DEPOIS DE FEITA NÃO HA VOLTA");
            Console.WriteLine("                          LEIA CADA PERGUNTA COM CALMA E ATENÇÃO. NÃO DEIXE NADA PASSAR POR VOCÊ");
            Console.ReadKey();

            bool sair = false;
            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("                                                     ");
                Console.WriteLine("                                                  BLOODTHIRSTY");
                Console.WriteLine("                                                     ");
                Console.WriteLine("                                                   NOVO JOGO    ( 1 )");
                Console.WriteLine("                                                 CARREGAR JOGO  ( 2 )");
                Console.WriteLine("                                                    OPÇÕES      ( 3 )");
                Console.WriteLine("                                                                     ");
                int Escolha = int.Parse(Console.ReadLine());
                
                
                MENU Menu = (MENU)Escolha;
                switch (Menu)
                {
                    case MENU.New:
                        New();
                   break;
                   case MENU.Load:
                        Load();
                   break;
                    case MENU.Options:
                        Console.Clear();
                        Console.WriteLine("                                                     ");
                        Console.WriteLine("                                                 JOGUE NO F11");
                        Console.WriteLine("                                  UTILIZE CTRL + SCROLL PARA REGULAR O TAMANHO");
                        Console.WriteLine("                                                APAGUE AS LUZES");
                        Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
                        Console.ReadKey();
                        break;
                }
            }
                            
        }
        static void New()
        {
            Contextos.Contexto();
            Capitulo1.C1();
        }

        enum CAPITULOS { C1 = 1, C2}
        static void Load()
        {
            Console.Clear();
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                       ESCOLHA O CAPITULO QUE DESEJA INICIAR.");

            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("                                                     ");
                Console.WriteLine("                                                    CAPITULO 1  ( 1 )");
                Console.WriteLine("                                                    CAPITULO 2  ( 2 )");
                Console.WriteLine("                                                     ");
                int Escolha = int.Parse(Console.ReadLine());
                CAPITULOS Capitulos = (CAPITULOS)Escolha;

                switch (Capitulos)
                {
                    case CAPITULOS.C1:
                        Capitulo1.C1();
                        break;
                    case CAPITULOS.C2:
                        Capitulo2.C2();
                        break;
                }
                break;
            }

        }

        

    }
        
}

