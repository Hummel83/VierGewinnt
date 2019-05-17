using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierGewinnt.Core;

namespace VierGewinnt.View.WPF
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly IReadOnlyList<ISpielerViewModel> _spielerViewModels;

        public MainWindowViewModel(IReadOnlyList<ISpielerViewModel> spielerViewModels)
        {
            _spielerViewModels = spielerViewModels;
        }

        public ISpielBrettViewModel SpielBrettViewModel
        {
            get { return null; }
        }

        public IReadOnlyList<ISpielerViewModel> SpielerViewModels
        {
            get { return _spielerViewModels; }
        }

        public string GewinnerName
        {
            get { return null; }
        }
    }
}
