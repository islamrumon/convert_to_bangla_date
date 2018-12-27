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

namespace BuilFunction1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class MonthNam
    {

    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnChanged_Click(object sender, RoutedEventArgs e)
        {
            this.NumChangeToBangla();
        }
        public void NumChangeToBangla()
        {
            string enNumInp = this.txtboxInput.Text.Trim();  //12-February-2018
            char[] bnNum = { '০', '১', '২', '৩', '৪', '৫', '৬', '৭', '৮', '৯' };
            string[] bn = { "জানু", "ফেব্রু", "মার্চ", "এপ্রি", "মে", "জুন", "জুলা", "আগ", "সেপ্টে", "অক্টো", "নভে", "ডিসে" };
            string[] bnFull = { "জানুয়ারি", "ফেব্রুয়ারি", "মার্চ", "এপ্রিল", "মে", "জুন", "জুলাই", "আগস্ট", "সেপ্টেম্বর", "অক্টোবর", "নভেম্বর", "ডিসেম্বর" };
            string[] enFull = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
         //   string[] en = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            string banNumOutput = "";

            foreach (var c in enNumInp.ToArray())
            {
                char c1 = c;
                for (int i = 0; i <= 9; i++)
                {
                    if (c1.ToString() == i.ToString())
                    {
                        c1 = bnNum[i];
                        break;
                    }
                }
                banNumOutput += c1.ToString();  // 
            }
            //for (int i = 0; i < 12; i++)
            //{
            //    if (banNumOutput.Contains(enFull[i])) //  == enNumInp.Contains(enFull[i])
            //    {
            //        banNumOutput = banNumOutput.Replace(enFull[i], bnFull[i].ToString());
            //        break;
            //    }
            //    else  if(banNumOutput.Contains(en[i])) //June    == enNumInp.Contains(en[i])
            //    {
            //        // var bb = banNumOutput.Contains(en[i]);
            //        banNumOutput = banNumOutput.Replace(en[i].ToString(), bn[i].ToString());
            //    }
            //}
            for (int i = 0; i < 12; i++)
            {
                if (banNumOutput.Contains(enFull[i]))
                {
                    banNumOutput = banNumOutput.Replace(enFull[i], bnFull[i].ToString());
                    break;
                }
                else if (banNumOutput.Contains(enFull[i].Substring(0, 3)))
                {
                    banNumOutput = banNumOutput.Replace(enFull[i].Substring(0, 3).ToString(), bn[i].ToString());
                }
            }
            this.lblShow.Content = banNumOutput;
        }



        #region ss
        private void btnChanged1_Click(object sender, RoutedEventArgs e)
        {
          //  this.monthChange();
            this.NumChangeToBangla1();

        }
        public void NumChangeToBangla1()
        {
            string enNumInp = this.txtboxInput1.Text.Trim();  //12-February-2018
            char[] bnNum = { '০', '১', '২', '৩', '৪', '৫', '৬', '৭', '৮', '৯' };
            string[] bn = { "জানু", "ফেব্রু", "মার্চ", "এপ্রি", "মে", "জুন", "জুলা", "আগ", "সেপ্টে", "অক্টো", "নভে", "ডিসে" };
            string[] bnFull = { "জানুয়ারি", "ফেব্রুয়ারি", "মার্চ", "এপ্রিল", "মে", "জুন", "জুলাই", "আগস্ট", "সেপ্টেম্বর", "অক্টোবর", "নভেম্বর", "ডিসেম্বর" };
            string[] enFull = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            //   string[] en = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            string banNumOutput = "";

            foreach (var c in enNumInp.ToArray())
            {
                char c1 = c;
                for (int i = 0; i <= 9; i++)
                {
                    if (c1.ToString() == i.ToString())
                    {
                        c1 = bnNum[i];
                        break;
                    }
                }
                banNumOutput += c1.ToString();  // 
            }
            for (int i = 0; i < 12; i++)
            {
                if (banNumOutput.Contains(enFull[i]))
                {
                    banNumOutput = banNumOutput.Replace(enFull[i], bnFull[i].ToString());
                    break;
                }
                else if (banNumOutput.Contains(enFull[i].Substring(0, 3)))
                {
                    banNumOutput = banNumOutput.Replace(enFull[i].Substring(0, 3).ToString(), bn[i].ToString());
                }
            }
            this.lblShow1.Content = banNumOutput;
        }
        public void monthChange()
        {
            string input = this.txtboxInput1.Text.Trim();
            // string[] bnNam = input;
            string[] bn = { "জানু", "ফেব্রু", "মার্চ", "এপ্রি", "মে", "জুন", "জুলা", "আগ", "সেপ্টে", "অক্টো", "নভে", "ডিসে" };
            string[] bnFull = { "জানুয়ারি", "ফেব্রুয়ারি", "মার্চ", "এপ্রিল", "মে", "জুন", "জুলাই", "আগস্ট", "সেপ্টেম্বর", "অক্টোবর", "নভেম্বর", "ডিসেম্বর" };
            string[] en = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string output = "";

            for (int i = 0; i < 12; i++)
            {
                string bb = en[i].Substring(0, 3);

                if (input.Contains(en[i]))
                {
                    output = bnFull[i];
                }
                else if (input == bb)
                {
                    output = bn[i];
                }
            }

            this.lblShow1.Content = output;



        }
        #endregion



        public string DateToBangla(string enNumInp)
        {
            enNumInp = this.txtboxInput.Text.Trim();  //12-February-2018
            char[] bnNum = { '০', '১', '২', '৩', '৪', '৫', '৬', '৭', '৮', '৯' };
            string[] bn = { "জানু", "ফেব্রু", "মার্চ", "এপ্রি", "মে", "জুন", "জুলা", "আগ", "সেপ্টে", "অক্টো", "নভে", "ডিসে" };
            string[] bnFull = { "জানুয়ারি", "ফেব্রুয়ারি", "মার্চ", "এপ্রিল", "মে", "জুন", "জুলাই", "আগস্ট", "সেপ্টেম্বর", "অক্টোবর", "নভেম্বর", "ডিসেম্বর" };
            string[] enFull = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            //   string[] en = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            string banNumOutput = "";

            foreach (var c in enNumInp.ToArray())
            {
                char c1 = c;
                for (int i = 0; i <= 9; i++)
                {
                    if (c1.ToString() == i.ToString())
                    {
                        c1 = bnNum[i];
                        break;
                    }
                }
                banNumOutput += c1.ToString();  // 
            }
            for (int i = 0; i < 12; i++)
            {
                if (banNumOutput.Contains(enFull[i]))
                {
                    banNumOutput = banNumOutput.Replace(enFull[i], bnFull[i].ToString());
                    break;
                }
                else if (banNumOutput.Contains(enFull[i].Substring(0, 3)))
                {
                    banNumOutput = banNumOutput.Replace(enFull[i].Substring(0, 3).ToString(), bn[i].ToString());
                }
            }
            this.lblShow.Content = banNumOutput;


            return banNumOutput ;
        }
    }

}
