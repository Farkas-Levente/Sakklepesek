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

namespace Sakklepesek_FarkasLevente
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int meret = 10;
        Button[,] negyzetek;
        public MainWindow()
        {
            InitializeComponent();
            TablaKialakitasa();
        }


       
        private void TablaKialakitasa()
        {
            tabla.Children.Clear();
            negyzetek = new Button[meret, meret];
            for (int i = 0; i < meret; i++)
            {

                for (int j = 0; j < meret; j++)
                {


                    Button negyzet = new Button();


                    negyzet.Width = tabla.Width / meret;
                    negyzet.Height = tabla.Height / meret;
                    negyzet.Margin = new Thickness(tabla.Width / meret * j, tabla.Height / meret * i, 0, 0);


                    

                    tabla.Children.Add(negyzet);

                    negyzetek[i, j] = negyzet;

                }
            }

            for (int i = 0; i < meret; i++)
            {

                for (int j = 0; j < meret; j++)
                {


                    if (j % 2 == 1 && i % 2 == 1)
                    {
                        negyzetek[i, j].Background = Brushes.Khaki;
                    }
                    else if (j % 2 == 0 && i % 2 == 0)
                    {
                        negyzetek[i, j].Background = Brushes.Khaki;
                    }
                    else
                    {
                        negyzetek[i, j].Background = Brushes.IndianRed;
                    }

                }
            }

        }
    }
}
