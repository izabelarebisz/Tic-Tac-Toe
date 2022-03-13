using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kółko_i_krzyżyk.Model
{
    class Gra
    {     
        
        public bool czyWygrana(char[] znaki)
        {
            //w poziomie
            if (znaki[0] == znaki[1] && znaki[1] == znaki[2] 
                && znaki[0] != ' ' && znaki[1] != ' ' && znaki[2] != ' ') 
                return true;
            if (znaki[3] == znaki[4] && znaki[4] == znaki[5]
                && znaki[3] != ' ' && znaki[4] != ' ' && znaki[5] != ' ') 
                return true;
            if (znaki[6] == znaki[7] && znaki[7] == znaki[8]
                 && znaki[6] != ' ' && znaki[7] != ' ' && znaki[8] != ' ') 
                return true;

            //w pionie
            if (znaki[0] == znaki[3] && znaki[3] == znaki[6]
                 && znaki[0] != ' ' && znaki[3] != ' ' && znaki[6] != ' ') 
                return true;
            if (znaki[1] == znaki[4] && znaki[4] == znaki[7]
                 && znaki[1] != ' ' && znaki[4] != ' ' && znaki[7] != ' ') 
                return true;
            if (znaki[2] == znaki[5] && znaki[5] == znaki[8]
                 && znaki[2] != ' ' && znaki[5] != ' ' && znaki[8] != ' ') 
                return true;

            //na ukos
            if (znaki[0] == znaki[4] && znaki[4] == znaki[8]
                 && znaki[0] != ' ' && znaki[4] != ' ' && znaki[8] != ' ') 
                return true;
            if (znaki[2] == znaki[4] && znaki[4] == znaki[6]
                 && znaki[2] != ' ' && znaki[4] != ' ' && znaki[6] != ' ') 
                return true;

            return false;
        }
        public bool czyRemis(char[] znaki)
        {
            for (int i = 0; i < 8; i++)
            {
                if (znaki[i] == ' ') return false;
            }
            return true;
        }

        public bool czyKoniec(char[] znaki)
        {
            if (czyWygrana(znaki) == true) return true;
            if (czyRemis(znaki) == true) return true;
            return false;
        }

        public string wyswietlKomunikat(char[] znaki, string imie1, string imie2)
        {

            if (czyWygrana(znaki) == true)
            {
                if (czyjRuch() == false) return "Zwycięża gracz " + imie2;
                else return "Zwycięża gracz " + imie1;
            }

            if (czyRemis(znaki) == true) return "Remis!";

            if (czyjRuch() == false) return "Teraz gracz " + imie1;
            else return "Teraz gracz " + imie2;
            
        }
        public char[] ustawZnak(int i, char[] znaki) //wstawia x lub o
        {
            char[] result = znaki;
            if (ktoryZnak()==true) result[i] = 'x';
            else result[i] = 'o';
            return result;
        } 

        private bool turn = false;
        bool czyjRuch()
        {
            turn ^= true;
            return turn;

        }

        private bool sign = false;
        bool ktoryZnak()
        {
            sign ^= true;
            return sign;

        }

        public char[] czyscTab()
        {
            char[] result = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            return result;
        }
    }
}
