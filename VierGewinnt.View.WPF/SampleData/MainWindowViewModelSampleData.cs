using System.Collections.Generic;
using VierGewinnt.Core;

namespace VierGewinnt.View.WPF.SampleData
{
    public class MainWindowViewModelSampleData : IMainWindowViewModel
    {
        public MainWindowViewModelSampleData()
        {
            var spielerViewModel = new List<ISpielerViewModel>
            {
                new SpielerViewModelSampleData("Player A", new Farbe(128, 0, 0)),
                new SpielerViewModelSampleData("Player B", new Farbe(0, 0, 128)) {IstAnDerReihe = false}
            };

            SpielerViewModels = spielerViewModel;
        }

        public ISpielBrettViewModel SpielBrettViewModel => null;

        public IReadOnlyList<ISpielerViewModel> SpielerViewModels { get; }

        public string GewinnerName => SpielerViewModels[0].Spieler.SpielerName;
    }
}