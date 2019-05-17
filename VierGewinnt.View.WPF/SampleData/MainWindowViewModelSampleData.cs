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
                new SpielerViewModelSampleData("Player A", new Farbe(0, 0, 128)){IstAnDerReihe = false}
            };

            _spielerViewModels = spielerViewModel;
        }

        public ISpielBrettViewModel SpielBrettViewModel
        {
            get { return null; }
        }

        public IReadOnlyList<ISpielerViewModel> SpielerViewModels
        {
            get { return _spielerViewModels; }
        }
    }
}