using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace tpmodul7_1302204061
{
    class CovidConfig
    {
        //Attribute untuk diserialisasi
        public int satuan_suhu { get; set; }
        public int batas_hari_demam { get; set; }
        public int pesan_ditolak { get; set; }
        public int pesan_diterima { get; set; }

        //constructor kosong untuk deserialisasi
        public CovidConfig() {
             CovidConfig config = "celcius";

        }
        public CovidConfig(int satuan_suhu, int batas_hari_demam,int pesan_ditolak, int pesan_diterima)
        {
            satuan_suhu = satuan_suhu;
            batas_hari_demam = batas_hari_demam;
            pesan_ditolak = pesan_ditolak;
            pesan_diterima = pesan_diterima;

        }

        private void CovidConfig(object sender, EventArgs e)
        {
            //Membuat object konfigurasi
            CovidConfig covidConfig = new UIConfig();
            //Membaca data konfigurasi untuk digunakan untuk setting
            Height = uIConfig.config.Height;
            Width = uIConfig.config.Width;
        }

       
        }



    }
}
