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
    public partial class Pgfrom : ContentPage
    {
        List<Class1> list = new List<Class1>();
        int position;
        public Pgfrom()
        {
            InitializeComponent();
            Addlist();

        }

        private void Addlist()
        {
            list.Add(new Class1 { Id = 1, 日期 = "2022/10/10", 核可結果 = false, 理由 = "睡覺", 申請人 = "軒", 簽核主管 = "Amos" });
            list.Add(new Class1 { Id = 2, 日期 = "2021/10/20", 核可結果 = true, 理由 = "昨天太晚下班", 申請人 = "志賢", 簽核主管 = "Amos" });
            list.Add(new Class1 { Id = 3, 日期 = "2022/02/25", 核可結果 = true, 理由 = "出遊", 申請人 = "文祥", 簽核主管 = "Amos" });
        }

        private void Btnfirstimg(object sender, EventArgs e)
        {
            position = 0;
            Additem(position);
        }

        private void Btnlastimg(object sender, EventArgs e)
        {
            position = list.Count - 1;
            Additem(position);
        }

        private void Additem(int index)
        {
            txtxId.Text = list[position].Id.ToString();
            txt日期.Text = list[position].日期;
            txt理由.Text = list[position].理由;
            txt簽准人.Text = list[position].簽核主管;
            txt申請人.Text = list[position].申請人;
        }

        private void Btnsearch(object sender, EventArgs e)
        {

        }

        private void Btnlist(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pglist());
            (Application.Current as App).from = list;
        }

        private void Btnpreimg(object sender, EventArgs e)
        {
            position--;
            if (position < 0)
                position = 0;
            Additem(position);
        }

        private void Btnnextimg(object sender, EventArgs e)
        {
            position++;
            if (position > list.Count)
                position = list.Count - 1;
            Additem(position);
        }
    }
}