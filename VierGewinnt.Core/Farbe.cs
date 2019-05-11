namespace VierGewinnt.Core
{
    public class Farbe
    {
        private readonly byte _blau;
        private readonly byte _gruen;
        private readonly byte _rot;

        public Farbe(byte rot, byte gruen, byte blau)
        {
            _rot = rot;
            _gruen = gruen;
            _blau = blau;
        }

        public byte Blau { get { return _blau; } }
        public byte Gruen { get { return _gruen; } }

        public byte Rot { get { return _rot; } }
    }
}