using System.Collections.Generic;
using VierGewinnt.Core;

namespace VierGewinnt.View.WPF
{
    public interface IMainWindowViewModel
    {
        ISpielBrettViewModel SpielBrettViewModel { get; }
    
        IReadOnlyList<ISpielerViewModel> SpielerViewModels { get; }

        string GewinnerName { get; }


    }
}