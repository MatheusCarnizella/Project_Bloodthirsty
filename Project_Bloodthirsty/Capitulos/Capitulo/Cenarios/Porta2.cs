using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Project_Bloodthirsty.Capitulos.Capitulo.Cenarios
{
    internal class Porta2
    {
        static SoundPlayer Som = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\FUNDO MUSICAL WAV.wav");
        static SoundPlayer Som2 = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\FUNDO AMBIENTE.wav");
        static SoundPlayer Passos = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\SOM DE PASSOS.wav");
        static SoundPlayer Portaa = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\PORTA.wav");
        static SoundPlayer Vidro = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\VIDRO.wav");
        static SoundPlayer Melancolia = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\MELANCOLIA.wav");
        static SoundPlayer AbrirPorta = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\PORTA ABRINDO SEM CHAVE.wav");
        static SoundPlayer ChavePorta = new SoundPlayer(@"C:\Users\Voiidde\Desktop\Git_projects\VS PROJECTS\Project_Bloodthirsty\Project_Bloodthirsty\Musicas\PORTA ABRINDO COM CHAVE.wav");
        static public void PortaB()
        {
            Console.Clear();
            Console.WriteLine("                                                          ");
            Console.WriteLine("                                                     Entrando no quarto ( ... )");
            AbrirPorta.PlaySync();
            Console.WriteLine("                                                     ");

            Melancolia.PlayLooping();
            Console.WriteLine("                                        Ao entrar você não vê nada de interessante no quarto.");
            Console.WriteLine("                                 Você apenas vê na parede uma moldura com um mapa escrito: LABORATÓRIO.");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("                                                          ");
            Console.WriteLine("                          - Kevin - É um desenho até que bonito. Acho que os donos não ligam de eu levar.");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.WriteLine("                                                          ");
            Console.ReadKey();
        }
    }
}
