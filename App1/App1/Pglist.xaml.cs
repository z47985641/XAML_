using App1.mode;
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
    public partial class Pglist : ContentPage
    {
        public Pglist()
        {
            InitializeComponent();
            List<Class1> list = (Application.Current as App).from;
            lv假單.ItemsSource = list;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}