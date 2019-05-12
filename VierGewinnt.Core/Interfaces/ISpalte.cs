namespace VierGewinnt.Core
{
    public interface ISpalte
    {
        bool IstSpalteVoll { get; }
        void LasseSpielsteinFallen(Spielstein spielstein);
    }
}