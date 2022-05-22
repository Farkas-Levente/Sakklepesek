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
    /// 
    public partial class MainWindow : Window
    {
        public int meret = 10;
        public Button[,] negyzetek;

        public MainWindow()
        {
            
            InitializeComponent();
            TablaKialakitasa();

            List<int> startPos = new List<int>();
            startPos.Add(3);
            startPos.Add(2);

            List<List<int>> stepList = new List<List<int>>();
            List<int> step1 = new List<int>();
            step1.Add(1);
            step1.Add(1);
            List<int> step2 = new List<int>();
            step2.Add(2);
            step2.Add(1);
            stepList.Add(step1);
            stepList.Add(step2);


            Babu currentBabu = new Babu(negyzetek, startPos,stepList,"gyalog");
            HighLightButtons(currentBabu.lephetOda);
            //negyzetek[3,1].Background = Brushes.Blue;
        }
        

        public class Babu
        {
           public string uniCode;
           public Button currentButton;
           public List<List<int>> stepList;

           public List<List<int>> lephetOda;


            public Babu(Button[,] negyzetek,List<int> startPos, List<List<int>> stepList,string uniCode)
            {
                
                this.stepList = stepList;
                currentButton = negyzetek[startPos[0], startPos[1]];
                currentButton.Content = uniCode;
                UjraSzamolLehetsegesLepeseket(startPos);
                
                
            }
            public  void UjraSzamolLehetsegesLepeseket(List<int> currentPos)
            {
                lephetOda = new List<List<int>>();
                for (int i = 0; i < stepList.Count; i++)
                {
                    List<int> posok = new List<int>();
                    posok.Add(currentPos[0] + stepList[i][0]);
                    posok.Add(currentPos[1] + stepList[i][1]);
                    lephetOda.Add(posok);
                }
            }

        }

        public void HighLightButtons(List<List<int>> stepList)
        {
            foreach (var pos in stepList)
            {

                negyzetek[pos[0], pos[1]].Background = Brushes.Blue;
            }
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
        private List<int> GetIndex(Button button)
        {
            for (int i = 0; i < meret; i++)
            {
                for (int j = 0; j < meret; j++)
                {
                    if (negyzetek[i, j] == button)
                    {

                        List<int> indexek = new List<int>();
                        indexek.Add(i);
                        indexek.Add(j);

                        return indexek;
                    }
                }
            }
            return null;
        }
       
        
    }

}
