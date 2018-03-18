using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumGen_Client {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e) {
            try {
                int start = int.Parse(tbStart.Text);
                int end = int.Parse(tbEnd.Text);
                string result = getResults(start, end);
                tbResult.Text = result;
            }
            catch {
                tbResult.Text = "Error";
            }

        }

        private string getResults (int start, int end) {
            try {
                int index = comboBox.SelectedIndex;
                NumberGeneratorRef.NumberGeneratorService obj = new NumberGeneratorRef.NumberGeneratorService();
                obj.Url = tbURL.Text + @"/app/NumberGeneratorService.asmx";

                switch (index) {
                    case 0: return obj.primeRange(start, end);
                    case 1: return obj.compositeRange(start, end);
                    case 2: return obj.perfectSquaresRange(start, end);
                    case 3: return obj.fibonacciRange(start, end);
                    case 4: return obj.powersofTwo(start, end);
                    case 5: return obj.evenRange(start, end);
                    case 6: return obj.oddRange(start, end);
                    case 7: return obj.palindromeRange(start, end);
                }
                return "INVALID";
            }
            catch {
                return "ERROR";
            }
        }
    }
}
