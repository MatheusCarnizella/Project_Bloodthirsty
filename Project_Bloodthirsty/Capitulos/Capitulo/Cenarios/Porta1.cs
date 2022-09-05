using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Project_Bloodthirsty.Capitulos.Capitulo.Cenarios
{
    internal class Porta1
    {
        static SoundPlayer Som = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\FUNDO MUSICAL WAV.wav");
        static SoundPlayer Som2 = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\FUNDO AMBIENTE.wav");
        static SoundPlayer Passos = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\SOM DE PASSOS.wav");
        static SoundPlayer Portaa = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\PORTA.wav");
        static SoundPlayer Vidro = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\VIDRO.wav");
        static SoundPlayer Melancolia = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\MELANCOLIA.wav");
        static SoundPlayer AbrirPorta = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\PORTA ABRINDO SEM CHAVE.wav");
        static SoundPlayer ChavePorta = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\PORTA ABRINDO COM CHAVE.wav");
        static public void PortaA()
        {
            Console.Clear();
            Console.WriteLine("                                                          ");
            Console.WriteLine("                                                     Entrando no quarto ( ... )");
            AbrirPorta.PlaySync();
            Console.WriteLine("                                                     ");

            Melancolia.PlayLooping();
            Console.WriteLine("             Ao entrar você vê no canto esquerdo do quarto uma mancha de sangue. Estranhamente não parecia estar seco.");
            Console.WriteLine("                                          Você ignora e em cima da cama encontra um bilhete:");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("                                                   _________________________________________");
            Console.WriteLine("                                              _____│                                        │");
            Console.WriteLine("                                          ___│               Vânia ( ... )                  │");
            Console.WriteLine("                                         │             Se encontrar esse bilhete,           │");
            Console.WriteLine("                                         │            Fuja o mais rapido que puder,         │");
            Console.WriteLine("                                         │             Me esqueça, não há salvação,         │");
            Console.WriteLine("                                         │    Eu descobri que a chave está no Laboratório,  │");
            Console.WriteLine("                                         │     Mas a chave da Lua não lembro onde deixei,   │");
            Console.WriteLine("                                         │             Encontre-as e fuja. SALVE-SE!       _│");
            Console.WriteLine("                                         │              FOI UM ERRO ENTRAR AQUI!!!       _│");
            Console.WriteLine("                                         │______________________________________________│");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.ReadKey();




        }
    }
}
