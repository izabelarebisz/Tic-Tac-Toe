using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kółko_i_krzyżyk.ViewModel
{
    using BaseClass;
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Model.Gra gra = new Model.Gra(); 

        private char[] znaki = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public char[] Znaki 
        {
            get { return znaki; }
            private set
            {
                znaki = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Znaki))); 
            }

        }
        private bool koniec;
        private ICommand postawZnak_0;
        public ICommand PostawZnak_0
        {
            get
            {
                return postawZnak_0 ?? (postawZnak_0 = new RelayCommand(
                    (p) =>
                    {
                        Znaki = gra.ustawZnak(0, Znaki);                       
                        komunikat = gra.wyswietlKomunikat(Znaki, Imie_1, Imie_2);
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Komunikat)));
                        koniec = gra.czyKoniec(Znaki);
                    },
                    p => !koniec));
            }
        }

        private ICommand postawZnak_1;
        public ICommand PostawZnak_1
        {
            get
            {
                return postawZnak_1 ?? (postawZnak_1 = new RelayCommand(
                    (p) => { 
                        Znaki = gra.ustawZnak(1, Znaki);                       
                        komunikat = gra.wyswietlKomunikat(Znaki, Imie_1, Imie_2);
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Komunikat)));
                        koniec = gra.czyKoniec(Znaki);
                    },
                    p => !koniec));
            }
        }

        private ICommand postawZnak_2;
        public ICommand PostawZnak_2
        {
            get
            {
                return postawZnak_2 ?? (postawZnak_2 = new RelayCommand(
                    (p) => { 
                        Znaki = gra.ustawZnak(2, Znaki);                      
                        komunikat = gra.wyswietlKomunikat(Znaki, Imie_1, Imie_2);
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Komunikat)));
                        koniec = gra.czyKoniec(Znaki);
                    },
                    p => !koniec));
            }
        }

        private ICommand postawZnak_3;
        public ICommand PostawZnak_3
        {
            get
            {
                return postawZnak_3 ?? (postawZnak_3 = new RelayCommand(
                    (p) => { 
                        Znaki = gra.ustawZnak(3, Znaki);                      
                        komunikat = gra.wyswietlKomunikat(Znaki, Imie_1, Imie_2);
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Komunikat)));
                        koniec = gra.czyKoniec(Znaki);
                    },
                    p => !koniec));
            }
        }

        private ICommand postawZnak_4;
        public ICommand PostawZnak_4
        {
            get
            {
                return postawZnak_4 ?? (postawZnak_4 = new RelayCommand(
                    (p) => { 
                        Znaki = gra.ustawZnak(4, Znaki);                       
                        komunikat = gra.wyswietlKomunikat(Znaki, Imie_1, Imie_2);
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Komunikat)));
                        koniec = gra.czyKoniec(Znaki);
                    },
                    p => !koniec));
            }
        }

        private ICommand postawZnak_5;
        public ICommand PostawZnak_5
        {
            get
            {
                return postawZnak_5 ?? (postawZnak_5 = new RelayCommand(
                    (p) => { 
                        Znaki = gra.ustawZnak(5, Znaki);                        
                        komunikat = gra.wyswietlKomunikat(Znaki, Imie_1, Imie_2);
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Komunikat)));
                        koniec = gra.czyKoniec(Znaki);
                    },
                    p => !koniec));
            }
        }

        private ICommand postawZnak_6;
        public ICommand PostawZnak_6
        {
            get
            {
                return postawZnak_6 ?? (postawZnak_6 = new RelayCommand(
                    (p) => { 
                        Znaki = gra.ustawZnak(6, Znaki);                       
                        komunikat = gra.wyswietlKomunikat(Znaki, Imie_1, Imie_2);
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Komunikat)));
                        koniec = gra.czyKoniec(Znaki);
                    },
                    p => !koniec));
            }
        }

        private ICommand postawZnak_7;
        public ICommand PostawZnak_7
        {
            get
            {
                return postawZnak_7 ?? (postawZnak_7 = new RelayCommand(
                    (p) => { 
                        Znaki = gra.ustawZnak(7, Znaki);                       
                        komunikat = gra.wyswietlKomunikat(Znaki, Imie_1, Imie_2);
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Komunikat)));
                        koniec = gra.czyKoniec(Znaki);
                    },
                    p => !koniec));
            }
        }

        private ICommand postawZnak_8;
        public ICommand PostawZnak_8
        {
            get
            {
                return postawZnak_8 ?? (postawZnak_8 = new RelayCommand(
                    (p) => { 
                        Znaki = gra.ustawZnak(8, Znaki);                      
                        komunikat = gra.wyswietlKomunikat(Znaki, Imie_1, Imie_2);
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Komunikat)));
                        koniec = gra.czyKoniec(Znaki);
                    },
                    p => !koniec));
            }
        }

        private ICommand start;
        public ICommand Start
        {
            get 
            {
                return start ?? (start = new RelayCommand(
                    (p) => { Znaki = gra.czyscTab();
                        Komunikat = "Teraz gracz " + Imie_1;
                        koniec = false;     
                    },
                    p => true));
                        

            }
        }

        private string komunikat;
        public string Komunikat
        {

            get { return komunikat;
            }

            private set
            {
                komunikat = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Komunikat)));
            }
        }
        private string imie_1;
        public string Imie_1
        {
            get { return imie_1; }
            set
            {
                imie_1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Imie_1)));
            }
        }
        private string imie_2;
        public string Imie_2
        {
            get { return imie_2; }
            set
            {
                imie_2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Imie_2)));
            }
        }

    }
} 



