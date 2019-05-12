namespace VierGewinnt.Core
{
    public class Farbe
    {
        public Farbe(byte rot, byte gruen, byte blau)
        {
            Rot = rot;
            Gruen = gruen;
            Blau = blau;
        }

        public byte Blau { get; }

        public byte Gruen { get; }

        public byte Rot { get; }
    }
}