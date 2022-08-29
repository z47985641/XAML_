using System;
using System.Collections.Generic;
using System.Text;

namespace App1.mode
{
    public class Class1
    {
        public int Id { get; set; }
        public string 申請人 { get; set; }
        public string 簽核主管 { get; set; }
        public string 理由 { get; set; }
        public string 日期 { get; set; }
        public bool 核可結果 { get; set; }
        public override string ToString()
        {
            return this.日期 +"-"+ this.理由 +"["+this.申請人+"]";
        }

    }
}
