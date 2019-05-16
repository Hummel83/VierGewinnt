using System.ComponentModel;
using System.Runtime.CompilerServices;
using VierGewinnt.Core;

namespace VierGewinnt.View.WPF
{
    public class SpielerViewModel : ISpielerViewModel, INotifyPropertyChanged
    {
        private bool _istAnDerReihe;

        public SpielerViewModel(Spieler spieler)
        {
            Spieler = spieler;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Spieler Spieler { get; }

        public bool IstAnDerReihe
        {
            get => _istAnDerReihe;
            set
            {
                if (_istAnDerReihe == value) return;

                _istAnDerReihe = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}