using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ListBox
{
    class Jmeno : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _PJmeno;
        public string PJmeno
        {
            get => _PJmeno;
            set { _PJmeno = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Forname")); }
        }

        private string _Prijmeni;
        public string Prijmeni
        {
            get => _Prijmeni;
            set { _Prijmeni = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Surname")); }
        }

        private DateTime _Vek;
        public DateTime Vek
        {
            get => _Vek;
            set { _Vek = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Birthdate")); }
        }

        private string _RodneCis;
        public string RodneCis
        {
            get => _RodneCis;
            set { _RodneCis = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PersonalID")); }
        }

        public static List<Jmeno> ListOfLidi = new List<Jmeno>();
    }
}
