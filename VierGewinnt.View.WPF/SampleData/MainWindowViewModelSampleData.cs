using System.Collections.Generic;
using VierGewinnt.Core;

namespace VierGewinnt.View.WPF.SampleData
{
    public class MainWindowViewModelSampleData : IMainWindowViewModel
    {
        private readonly IReadOnlyList<ISpielerViewModel> _spielerViewModels;

        public MainWindowViewModelSampleData()
        {
            var spielerViewModel = new List<ISpielerViewModel>
            {
                new SpielerViewModelSampleData("Player A", new Farbe(128, 0, 0)),
                new SpielerViewModelSampleData("Player B", new Farbe(0, 0, 128)){IstAnDerReihe = false}
            };

            _spielerViewModels = spielerViewModel;
        }

        public ISpielBrettViewModel SpielBrettViewModel => null;

        public IReadOnlyList<ISpielerViewModel> SpielerViewModels => _spielerViewModels;
        public string GewinnerName => _spielerViewModels[0].Spieler.SpielerName;
    }
}