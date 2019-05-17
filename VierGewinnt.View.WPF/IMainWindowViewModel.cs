using System.Collections.Generic;

namespace VierGewinnt.View.WPF
{
    public interface IMainWindowViewModel
    {
        ISpielBrettViewModel SpielBrettViewModel { get; }

        IReadOnlyList<ISpielerViewModel> SpielerViewModels { get; }

        string GewinnerName { get; }
    }
}