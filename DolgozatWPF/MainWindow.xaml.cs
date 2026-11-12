using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DolgozatWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Dolgozo> Dolgozok = new List<Dolgozo>();
        public MainWindow()
        {
            InitializeComponent();

            var d1 = new Dolgozo("Kovács János", 20, 78);
            var d2 = new Dolgozo("Asztalos Levente", 25, 87);
            var d3 = new Dolgozo("Szabó Marcell", 19, 56);
            var d4 = new Dolgozo("Kristályos Róbert", 53, 81);
            var d5 = new Dolgozo("Füzéri Károly", 34, 65);

            DolgozoEmberek.ItemsSource = Dolgozok;


        }

        private void btnHozzaadas_Click(object sender, RoutedEventArgs e)
        {
            string nev = Name.Text;
            int eletkor = int.Parse(Age.Text);
            int pontSzam = int.Parse(Point.Text);

            if (eletkor < 0 && eletkor > 100 && pontSzam < 0 && pontSzam > 100)
            {
                Dolgozok.Add(new Dolgozo(nev, eletkor, pontSzam));

                Name.Clear();
                Age.Clear();
                Point.Clear();

            }
        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Az adatok mentése megtörtént!");
        }
    }
}