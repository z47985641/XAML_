using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<string> list = new List<string>() { "紅", "黃", "藍", "綠" };
            Random rand = new Random();
            list.Add("紫");
            int index = rand.Next(0, list.Count);
            text1.Text = list[index];
            list.RemoveAt(index);
             index = rand.Next(0, list.Count);
            text2.Text = list[index];
            list.RemoveAt(index);
             index = rand.Next(0, list.Count);
            text3.Text = list[index];
            list.RemoveAt(index);
             index = rand.Next(0, list.Count);
            text4.Text = list[index];
            list.RemoveAt(index);

        }

    
    }
}
