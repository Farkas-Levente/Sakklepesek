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
        Babu bástya;
        Babu futó;
        Babu feherGyalog;
        Babu feketeGyalog;
        Babu kiralyno;
        Babu kiraly;
        public MainWindow()
        {
            
            InitializeComponent();


            egysegValaszto.Items.Add("Fekete Gyalog");
            egysegValaszto.Items.Add("Fehér Gyalog");
            egysegValaszto.Items.Add("Bástya");
            egysegValaszto.Items.Add("Futó");
            egysegValaszto.Items.Add("Huszár");
            egysegValaszto.Items.Add("Királynő");
            egysegValaszto.Items.Add("Király");
            TablaKialakitasa();

            #region FeketeGyalog
            //FeketeGyalog
            List<int> startPos = new List<int>();
            startPos.Add(8);
            startPos.Add(8);

            List<List<int>> stepList = new List<List<int>>();
            List<int> step1 = new List<int>();
            //step1.Add(1);
            //step1.Add(0);
            //stepList.Add(step1);
            List<int> step2 = new List<int>();
            step2.Add(-1);
            step2.Add(0);

            stepList.Add(step2);



            feketeGyalog = new Babu(negyzetek, startPos,stepList, "\u265F");

            #endregion

            #region FehérGyalog
            List<int> fehérGyalogStartPos = new List<int>();
            fehérGyalogStartPos.Add(2);
            fehérGyalogStartPos.Add(2);

            List<List<int>> fehérStepList = new List<List<int>>();
            List<int> feherStep = new List<int>();
            feherStep.Add(1);
            feherStep.Add(0);
            fehérStepList.Add(feherStep);




            feherGyalog = new Babu(negyzetek, fehérGyalogStartPos, fehérStepList, "\u2659");
            #endregion

            #region Huszár
            //Huszár

            List<int> startPos2 = new List<int>();
            startPos2.Add(5);
            startPos2.Add(5);

            List<List<int>> stepList2 = new List<List<int>>();
            List<int> step3 = new List<int>();
            step3.Add(2);
            step3.Add(-1);
            stepList2.Add(step3);
            List<int> step4 = new List<int>();
            step4.Add(2);
            step4.Add(1);
            stepList2.Add(step4);

            List<int> step5 = new List<int>();
            step5.Add(-2);
            step5.Add(-1);
            stepList2.Add(step5);
            List<int> step6 = new List<int>();
            step6.Add(-2);
            step6.Add(1);
            stepList2.Add(step6);

            List<int> step7 = new List<int>();
            step7.Add(1);
            step7.Add(-2);
            stepList2.Add(step7);
            List<int> step8 = new List<int>();
            step8.Add(1);
            step8.Add(2);
            stepList2.Add(step8);
            List<int> step9 = new List<int>();
            step9.Add(-1);
            step9.Add(-2);
            stepList2.Add(step9);
            List<int> step10 = new List<int>();
            step10.Add(-1);
            step10.Add(2);
            stepList2.Add(step10);

            huszár = new Babu(negyzetek, startPos2, stepList2, "\u265E");
            #endregion

            #region Bástya
            //Bástya
            List<int> bástyaStartPos = new List<int>();
            bástyaStartPos.Add(4);
            bástyaStartPos.Add(2);

            List<List<int>> bástyaSteplist = new List<List<int>>();
            for (int i = 1; i <= 10; i++)
            {
                List<int> bastyaStep1 = new List<int>();
                bastyaStep1.Add(i);
                bastyaStep1.Add(0);
                bástyaSteplist.Add(bastyaStep1);
            }
            for (int i = 1; i <= 10; i++)
            {
                List<int> bastyaStep1 = new List<int>();
                bastyaStep1.Add(-i);
                bastyaStep1.Add(0);
                bástyaSteplist.Add(bastyaStep1);
            }
            for (int i = 1; i <= 10; i++)
            {
                List<int> bastyaStep1 = new List<int>();
                bastyaStep1.Add(0);
                bastyaStep1.Add(i);
                bástyaSteplist.Add(bastyaStep1);
            }
            for (int i = 1; i <= 10; i++)
            {
                List<int> bastyaStep1 = new List<int>();
                bastyaStep1.Add(0);
                bastyaStep1.Add(-i);
                bástyaSteplist.Add(bastyaStep1);
            }






            bástya = new Babu(negyzetek, bástyaStartPos, bástyaSteplist, "\u265C");

            #endregion

            #region Királynő
            List<int> kiralynőStartPos = new List<int>();
            kiralynőStartPos.Add(2);
            kiralynőStartPos.Add(8);

            List<List<int>> kiralynőStepList = new List<List<int>>();
            for (int i = 1; i <= 10; i++)
            {
                List<int> bastyaStep1 = new List<int>();
                bastyaStep1.Add(i);
                bastyaStep1.Add(0);
                kiralynőStepList.Add(bastyaStep1);
            }
            for (int i = 1; i <= 10; i++)
            {
                List<int> bastyaStep1 = new List<int>();
                bastyaStep1.Add(-i);
                bastyaStep1.Add(0);
                kiralynőStepList.Add(bastyaStep1);
            }
            for (int i = 1; i <= 10; i++)
            {
                List<int> bastyaStep1 = new List<int>();
                bastyaStep1.Add(0);
                bastyaStep1.Add(i);
                kiralynőStepList.Add(bastyaStep1);
            }
            for (int i = 1; i <= 10; i++)
            {
                List<int> bastyaStep1 = new List<int>();
                bastyaStep1.Add(0);
                bastyaStep1.Add(-i);
                kiralynőStepList.Add(bastyaStep1);
            }

            for (int i = 1; i <= 10; i++)
            {
                List<int> futóStep1 = new List<int>();
                futóStep1.Add(i);
                futóStep1.Add(i);
                kiralynőStepList.Add(futóStep1);
            }
            for (int i = 1; i <= 10; i++)
            {
                List<int> futóStep1 = new List<int>();
                futóStep1.Add(-i);
                futóStep1.Add(-i);
                kiralynőStepList.Add(futóStep1);
            }
            for (int i = 1; i <= 10; i++)
            {
                List<int> futóStep1 = new List<int>();
                futóStep1.Add(i);
                futóStep1.Add(-i);
                kiralynőStepList.Add(futóStep1);
            }
            for (int i = 1; i <= 10; i++)
            {
                List<int> futóStep1 = new List<int>();
                futóStep1.Add(-i);
                futóStep1.Add(i);
                kiralynőStepList.Add(futóStep1);
            }
            kiralyno = new Babu(negyzetek, kiralynőStartPos, kiralynőStepList, "\u265B");
            #endregion


            #region Király
            List<int> kiralyStartPos = new List<int>();
            kiralyStartPos.Add(4);
            kiralyStartPos.Add(3);

            List<List<int>> kiralyStepList = new List<List<int>>();
            for (int i = 1; i <= 1; i++)
            {
                List<int> bastyaStep1 = new List<int>();
                bastyaStep1.Add(i);
                bastyaStep1.Add(0);
                kiralyStepList.Add(bastyaStep1);
            }
            for (int i = 1; i <= 1; i++)
            {
                List<int> bastyaStep1 = new List<int>();
                bastyaStep1.Add(-i);
                bastyaStep1.Add(0);
                kiralyStepList.Add(bastyaStep1);
            }
            for (int i = 1; i <= 1; i++)
            {
                List<int> bastyaStep1 = new List<int>();
                bastyaStep1.Add(0);
                bastyaStep1.Add(i);
                kiralyStepList.Add(bastyaStep1);
            }
            for (int i = 1; i <= 1; i++)
            {
                List<int> bastyaStep1 = new List<int>();
                bastyaStep1.Add(0);
                bastyaStep1.Add(-i);
                kiralyStepList.Add(bastyaStep1);
            }

            for (int i = 1; i <= 1; i++)
            {
                List<int> futóStep1 = new List<int>();
                futóStep1.Add(i);
                futóStep1.Add(i);
                kiralyStepList.Add(futóStep1);
            }
            for (int i = 1; i <= 1; i++)
            {
                List<int> futóStep1 = new List<int>();
                futóStep1.Add(-i);
                futóStep1.Add(-i);
                kiralyStepList.Add(futóStep1);
            }
            for (int i = 1; i <= 1; i++)
            {
                List<int> futóStep1 = new List<int>();
                futóStep1.Add(i);
                futóStep1.Add(-i);
                kiralyStepList.Add(futóStep1);
            }
            for (int i = 1; i <= 1; i++)
            {
                List<int> futóStep1 = new List<int>();
                futóStep1.Add(-i);
                futóStep1.Add(i);
                kiralyStepList.Add(futóStep1);
            }
            kiraly = new Babu(negyzetek, kiralyStartPos, kiralyStepList, "\u265A");
            #endregion

            #region Futó
            List<int> futóStartPos = new List<int>();
            futóStartPos.Add(7);
            futóStartPos.Add(3);

            List<List<int>> futóStepList = new List<List<int>>();
            for (int i = 1; i <= 10; i++)
            {
                List<int> futóStep1 = new List<int>();
                futóStep1.Add(i);
                futóStep1.Add(i);
                futóStepList.Add(futóStep1);
            }
            for (int i = 1; i <= 10; i++)
            {
                List<int> futóStep1 = new List<int>();
                futóStep1.Add(-i);
                futóStep1.Add(-i);
                futóStepList.Add(futóStep1);
            }
            for (int i = 1; i <= 10; i++)
            {
                List<int> futóStep1 = new List<int>();
                futóStep1.Add(i);
                futóStep1.Add(-i);
                futóStepList.Add(futóStep1);
            }
            for (int i = 1; i <= 10; i++)
            {
                List<int> futóStep1 = new List<int>();
                futóStep1.Add(-i);
                futóStep1.Add(i);
                futóStepList.Add(futóStep1);
            }
            futó = new Babu(negyzetek, futóStartPos, futóStepList, "\u265D");
            #endregion
            currentBabu = huszár;
            egysegValaszto.SelectedItem = "Huszár";
            HighLightButtons(currentBabu.lephetOda);
            UpdateLehetsegesLepesekText();
            //currentBabu.currentButton.Content = '\u265D';


        }
        
        public void UpdateLehetsegesLepesekText()
        {
            lehetsegesLepesekText.Content = " ";
            foreach (var item in currentBabu.lephetOda)
            {
                foreach (var pos in item)
                {
                    lehetsegesLepesekText.Content +=   pos+ ",";
                }
                lehetsegesLepesekText.Content += " | ";
            }
            
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
            UpdateCurrentPosText();
            UpdateLehetsegesLepesekText();
            
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

            if (egysegValaszto.SelectedItem.ToString() == "Huszár")
            {
                currentBabu = huszár;
            }
            else if (egysegValaszto.SelectedItem.ToString() == "Fekete Gyalog")
            {
                currentBabu = feketeGyalog;
            }
            else if (egysegValaszto.SelectedItem.ToString() == "Fehér Gyalog")
            {
                currentBabu = feherGyalog;
            }
            else if (egysegValaszto.SelectedItem.ToString() == "Futó")
            {
                currentBabu = futó;
            }
            else if (egysegValaszto.SelectedItem.ToString() == "Bástya")
            {
                currentBabu = bástya;
            }
            else if(egysegValaszto.SelectedItem.ToString() == "Királynő")
            {
                currentBabu = kiralyno;
            }
            else if(egysegValaszto.SelectedItem.ToString() == "Király")
            {
                currentBabu = kiraly;
            }
            currentBabu.UjraSzamolLehetsegesLepeseket(GetIndex(currentBabu.currentButton));
            UjraSzinezTabla();
            HighLightButtons(currentBabu.lephetOda);
            
            UpdateCurrentPosText();
            UpdateLehetsegesLepesekText();
        }

        private void UpdateCurrentPosText()
        {
            posText.Content = " " + (GetIndex(currentBabu.currentButton)[0] + 1) + "," + (GetIndex(currentBabu.currentButton)[1] + 1);
        }
    }

}
