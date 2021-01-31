using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTranscation.UI.Entities
{
    public class HesapLog
    {
        public int ID { get; set; }
        public int GonderenHesap { get; set; }
        public int AliciHesap { get; set; }
        public decimal Tutar { get; set; }
        public DateTime IslemTarih { get; set; }

    }
}
