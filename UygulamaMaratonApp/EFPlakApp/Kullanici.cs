﻿using MaratonApp.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPlakApp
{
    public class Kullanici:Entity
    {
        //public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sifre { get; set; }
        public string KullaniciAdi { get; set; }

    }
}
