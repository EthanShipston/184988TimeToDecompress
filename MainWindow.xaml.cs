/* Ethan Shipston
 * 29/3/2019
 * a program which decompresses given information.
 */
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

namespace _184988TimeToDecompress
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = "";

            string input = txtInput.Text + "\n\r";
            int.TryParse(input.Substring(0, input.IndexOf("\n")), out int L);
            input = input.Remove(0, input.IndexOf("\n") + 1);
            int[] quant = new int[L];
            string[] info = new string[L];
            
            for (int i = 0; i < L; i++)
            {
                int.TryParse(input.Substring(0, input.IndexOf(" ")), out quant[i]);
                info[i] = input.Substring(input.IndexOf(" ") + 1, 1);
                input = input.Remove(0, input.IndexOf("\n") + 1);
            }

            for (int i = 0; i < L; i++)
            {
                for (int ii = 0; ii < quant[i]; ii++)
                {
                    lblOutput.Content += info[i];
                    if (ii == quant[i] - 1)
                    {
                        lblOutput.Content += "\n";
                    }
                }
            }
        }
    }
}
