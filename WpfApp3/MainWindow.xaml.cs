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

namespace WpfApp3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float? res;
        private char operacion;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btns_Click(object sender, RoutedEventArgs e)
        {
            tbx.Text += ((Button)sender).Content;
        }

        private void BtnBorrar_Click(object sender, RoutedEventArgs e)
        {
            tbx.Text = "";
        }

        

        private void BtnIgual_Click(object sender, RoutedEventArgs e)
        {
            if (tbx.Text != "" && res != null)
            {
                Resultado();
                tbx.Text = res.ToString();
                res = null;
            }
        }

        

        private void Resultado()
        {
            switch (operacion)
            {
                case '+':
                    res += float.Parse(tbx.Text);
                    break;
                case '-':
                    res -= float.Parse(tbx.Text);
                    break;
                case '/':
                    res /= float.Parse(tbx.Text);
                    break;
                case '*':
                    res *= float.Parse(tbx.Text);
                    break;
            }

            
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            res = null;
        }

        private void BtnOperacion_Click(object sender, RoutedEventArgs e)
        {
            if (tbx.Text != "")
            {
                if(res == null)
                {
                    res = float.Parse(tbx.Text);
                }
                else
                {
                    Resultado();
                }
                operacion = char.Parse(((Button)sender).Content.ToString());
                tbx.Text = "";
            }
        }
    }
}
