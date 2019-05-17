using System.Collections.Generic;

namespace VierGewinnt.View.WPF
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        public MainWindowViewModel(IReadOnlyList<ISpielerViewModel> spielerViewModels)
        {
            SpielerViewModels = spielerViewModels;
        }

        public ISpielBrettViewModel SpielBrettViewModel => null;

        public IReadOnlyList<ISpielerViewModel> SpielerViewModels { get; }

        public string GewinnerName => null;
    }
}