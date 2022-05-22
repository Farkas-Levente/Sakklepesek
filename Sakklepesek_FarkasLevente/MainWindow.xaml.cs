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
        Babu currentBabu;
        Babu huszár;
        public MainWindow()
        {
            
            InitializeComponent();


            egysegValaszto.Items.Add("Gyalog");
            egysegValaszto.Items.Add("Bástya");
            egysegValaszto.Items.Add("Futó");
            egysegValaszto.Items.Add("Huszár");
            TablaKialakitasa();

            List<int> startPos = new List<int>();
            startPos.Add(3);
            startPos.Add(2);

            List<List<int>> stepList = new List<List<int>>();
            List<int> step1 = new List<int>();
            step1.Add(1);
            step1.Add(0);
            stepList.Add(step1);
            List<int> step2 = new List<int>();
            step2.Add(-1);
            step2.Add(0);
            
            stepList.Add(step2);

            

            currentBabu = new Babu(negyzetek, startPos,stepList,"Gyalog");



            List<int> startPos2 = new List<int>();
            startPos2.Add(0);
            startPos2.Add(2);

            List<List<int>> stepList2 = new List<List<int>>();
            List<int> step3 = new List<int>();
            step3.Add(1);
            step3.Add(0);
            stepList2.Add(step3);
            List<int> step4 = new List<int>();
            step4.Add(-1);
            step4.Add(0);
            stepList2.Add(step4);

            huszár = new Babu(negyzetek, startPos2, stepList2, "Huszár");

            HighLightButtons(currentBabu.lephetOda);
            
        }
        

        public class Babu
        {
           public string uniCode;
           public Button currentButton;
            
           public List<List<int>> stepList;
           Button[,] negyzetek;
           public List<List<int>> lephetOda;

            public void MoveTo(List<int> nextPos)
            {
                if (negyzetek[nextPos[0], nextPos[1]].Content.ToString() != " " ) return;
                bool mehet = false;
                foreach (var pos in lephetOda)
                {
                    if(pos[0] == nextPos[0] && pos[1] == nextPos[1])
                    {
                        mehet = true;
                    }
                }
                if (!mehet) return;
                
                currentButton.Content = " ";
                
                currentButton = negyzetek[nextPos[0], nextPos[1]];
                currentButton.Content = uniCode;
                UjraSzamolLehetsegesLepeseket(nextPos);
                
            }
            public Babu(Button[,] negyzetek,List<int> startPos, List<List<int>> stepList,string uniCode)
            {
                this.negyzetek = negyzetek;
                this.stepList = stepList;
                currentButton = negyzetek[startPos[0], startPos[1]];
                this.uniCode = uniCode;
                currentButton.Content = uniCode;
                UjraSzamolLehetsegesLepeseket(startPos);
                
                
            }
            public  void UjraSzamolLehetsegesLepeseket(List<int> currentPos)
            {
                lephetOda = new List<List<int>>();
                for (int i = 0; i < stepList.Count; i++)
                {
                    try
                    {
                        List<int> posok = new List<int>();
                        posok.Add(currentPos[0] + stepList[i][0]);
                        posok.Add(currentPos[1] + stepList[i][1]);
                        if (negyzetek[posok[0], posok[1]].Content.ToString() == " ")
                        {
                            lephetOda.Add(posok);
                        }
                    }
                    catch(IndexOutOfRangeException)
                    {

                    }
                    
                    
                }
            }

        }

        public void HighLightButtons(List<List<int>> stepList)
        {
            
            
                foreach (var pos in stepList)
                {
                    try
                    {
                    negyzetek[pos[0], pos[1]].Background = Brushes.Blue;
                    }
                    catch (IndexOutOfRangeException)
                    {

                    }
                }
            
            
            
        }
        public void UjraSzinezTabla()
        {
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

                    negyzet.Content = " ";
                    negyzet.Click += Mozgat;

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

        private void Mozgat(object sender, RoutedEventArgs e)
        {
            currentBabu.MoveTo(GetIndex((Button)sender));
            
            UjraSzinezTabla();
            HighLightButtons(currentBabu.lephetOda);
            
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

        private void EgysegValaszto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(egysegValaszto.SelectedItem.ToString() == "Gyalog")
            {
                negyzetek[0, 0].Background = Brushes.Green;
            }
        }
    }

}
