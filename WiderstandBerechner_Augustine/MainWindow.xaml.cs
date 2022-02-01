using System.Windows;

namespace WiderstandBerechner_Augustine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public double wert0, wert1;
        public bool schaltungstyp0;
        public double wertges;

        private void button_berechenen_Click(object sender, RoutedEventArgs e)
        {
            double v = System.Convert.ToDouble(TextboxWiderstand1.Text);
            wert0 =
                wert1 = System.Convert.ToDouble(TextboxWiderstand2.Text);

            if (ComboboxSchaltung.Text == "Parallelschaltung")
            {
                schaltungstyp0 = true;
            }
            else
            {
                schaltungstyp0 = false;
            }


            if (schaltungstyp0 == true)
            {
                wert0 = 1 / wert0;
            }


            wertges = wert0 + wert1;

            TextboxWiderstandGesamt.Text = wertges.ToString();
        }
    }
}