namespace WiderstandBerechner_Augustine
{
    public class Widerstand
    {
        private float wert;
        private bool Reihenschaltung;

        public float _wert
        {
            get => wert;
            set
            {
                wert = value;
            }
        }

        public bool _Reihenschaltung
        {
            get => Reihenschaltung;
            set
            {
                Reihenschaltung = value;
            }
        }
    }
}