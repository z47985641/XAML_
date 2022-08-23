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
    public partial class Pglotto : ContentPage
    {
        public Pglotto()
        {
            InitializeComponent();
            List<int> list = new List<int>() {};
            List<int> muns = new List<int>() {};
            int num,j,i;
            Random rand = new Random();
            string word = "中獎號碼為 : ";

            for (num =1; num < 50; num++)
            {
                list.Add(num);
            }

            for (num = 1; num < 7; num++)
            {
                int indexOfrand = rand.Next(0, list.Count);
                muns.Add(list[indexOfrand]);
                list.RemoveAt(indexOfrand);
            }

            for (i = 0; i < muns.Count; i++)
            {
                for (j = 0; j < muns.Count -1; j++)
                {
                    if(muns[j]> muns[j + 1]) 
                    { 
                    int temp = muns[j];
                    muns[j] = muns[j + 1];
                    muns[j + 1] = temp;
                    }
                }
            }
            foreach(int x in muns)
                word += x + " ";

            Text1.Text = word;
        }

        private void Btnchange_Clicked(object sender, EventArgs e)
        {

        }
    }
}