using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTranscation.UI.Entities
{
  public class Hesap
    {
     
        public int ID { get; set; }
        public string HesapNo { get; set; }
        public string Adi { get; set; }
        public  decimal Tutar { get; set; }
    }
}
