using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pgcal : ContentPage
    {
        int N1 , N2, N3;
        string op;
        public Pgcal()
        {
            InitializeComponent();
        }

        private void Btnnum(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b == null)
                return;

            int t = Convert.ToInt32(text1.Text);

            if (t == 0)
                text1.Text = b.Text;
            else
                text1.Text += b.Text; 

        }

        private void Btncal(object sender, EventArgs e)
        {
  

            N2 = Convert.ToInt32(text1.Text);

            if (op == "+")
                text1.Text =Convert.ToString (N3 + N2);
            else if (op == "-")
                text1.Text = Convert.ToString(N3 - N2);
            else if (op == "*")
                text1.Text = Convert.ToString(N3 * N2);
            else if (op == "/")
                text1.Text = Convert.ToString(N3 / N2);

        }

        private void Btnop(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b == null)
                return;

            N1 = Convert.ToInt32(text1.Text);
            

            op = b.Text;
            text1.Text = "0";

            if (op == "+")
                N3 += N1;
            else if (op == "-")
                N3 -= N1;
            else if (op == "*")
                N3 *= N1;
            else if (op == "/")
                N3 /= N1;



        }
    }
}