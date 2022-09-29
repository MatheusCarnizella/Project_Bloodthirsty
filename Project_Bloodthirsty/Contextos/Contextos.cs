using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Project_Bloodthirsty.SFXUtils;

namespace Project_Bloodthirsty.Contexto
{
    internal class Contextos
    {
        static public void Contexto()
        {
            //FundoMusical.Play();
            SFXUtility.GetSpecificSoundPlayerSFX("FundoMusical").Play();
            Console.Clear();
            Console.WriteLine("                                                     ");
            Console.WriteLine("                            Você (Kevin) descobre sobre uma mansão antiga supostamente assombrada.");
            Console.WriteLine("             Na curiosidade chama seus amigos, Jessie e Max, num desafio de passar uma noite inteira na mansão.");
            Console.WriteLine("          Por algum motivo todos concordam em compartilhar este tempo juntos, combinando de se encontrar as 20:00.");
            Console.WriteLine("                      Ao chegarem são recebidos com um sopro gelado arrepiando todo o seu corpo.");
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                 THE NIGHTMARE HAS BEGIN");
            Console.WriteLine("                                                                                         (PRESSIONE ENTER)");
            Console.ReadKey();
        }
    }
}
