using VierGewinnt.Core;

namespace VierGewinnt.View.WPF
{
    public interface ISpielerViewModel
    {
        Spieler Spieler { get; }
        bool IstAnDerReihe { get; }
    }
}