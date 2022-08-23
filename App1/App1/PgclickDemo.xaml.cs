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
    public partial class PgclickDemo : ContentPage
    {
        double A, B, C, XX,SS,judge;
        string word ="";

        private void Button_Clicked(object sender, EventArgs e)
        {
            A = Double.Parse(text1.Text);
            B = Double.Parse(text2.Text);
            C = Double.Parse(text3.Text);

            XX = (Math.Sqrt(B * B - 4 * A * C) - B) / (2 * A);
            SS = (-Math.Sqrt(B * B - 4 * A * C) - B) / (2 * A);
            if (SS == XX)
                word = SS.ToString("0.0#");
            else
                word = XX.ToString("0.0#") + "\n" + SS.ToString("0.0#");
            anser.Text = word;
        }

        public PgclickDemo()
        {
            InitializeComponent();

            
        }
    }
}