using System;
using static System.Console;


namespace Palindromi
{
    class Program
    {
        static void Main(string[] args)
        {
            string sana = ("");             //käyttäjän syöttämä sana
            string sana2 = ("");            //välimerkitön sana
            string palindromi = ("");       //käännetty ja välimerkitön sana
 
            // jos sana ei ole tyhjä, toteuttaa kaksi metodia ja sen jälkeen kertoo vertaamalla annettua sanaa ja muuteuttua sanaa keskenään, onko palindromi vai ei
            do
            {
                WriteLine("Anna teksti (tyhjä lopettaa): ");
                sana = ReadLine();

                sana2 = PoistaValimerkit(sana);
                palindromi = Kaanna(sana2);

                if (sana2 == palindromi)
                {
                    WriteLine("On palindromi.");
                }
                else
                {
                    WriteLine("Ei ole palindromi.");
                }        
            }
            while (sana != string.Empty) ;
                

        }


        // poistaa välimerkit yms. korvaamalla ne tyhjällä
        static string PoistaValimerkit(string sana)
        {
            string sana2 = sana.Replace(".", "").Replace(":", "").Replace(";", "").Replace(",", "").Replace("!", "").Replace("?", "").Replace(" ", "");
            return sana2;
        }

        // kääntää sanan ympäri
        static string Kaanna(string sana2)
        {
            char[] charArray = sana2.ToCharArray();
            Array.Reverse(charArray);
            return (new string(charArray));
        }
    }
}
