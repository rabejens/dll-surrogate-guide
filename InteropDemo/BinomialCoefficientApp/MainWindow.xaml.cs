using System.Windows;

namespace BinomialCoefficientApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private readonly BinomialCoefficient _proxy;

        public MainWindow() {
            InitializeComponent();
            _proxy = new BinomialCoefficient();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e) {
            ulong n, k;
            if (!ulong.TryParse(txtN.Text, out n)) {
                txtResult.Text = "Error";
                return;
            }
            if (!ulong.TryParse(txtK.Text, out k)) {
                txtResult.Text = "Error";
                return;
            }
            if (n < k) {
                txtResult.Text = "n must be >= k";
                return;
            }
            var b = _proxy.BinCo(n, k);
            txtResult.Text = b.ToString();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            _proxy.Dispose();
        }
    }
}
