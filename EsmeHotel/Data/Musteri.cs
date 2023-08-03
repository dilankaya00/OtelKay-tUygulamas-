using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsmeHotel
{
    public class Musteri
    {
        public int Id { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi{ get; set; }
        public string Cinsiyet{ get; set; }
        public string Telefon{ get; set; }
        public string TC{ get; set; }
        public string Mail{ get; set; }
        public string OdaNo{ get; set; }
        public int Ucret{ get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public List<Musteri> MusteriList { get; set; }   
    }
}
