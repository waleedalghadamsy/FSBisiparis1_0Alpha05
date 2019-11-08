﻿using BisiparişÇekirdek.Valıklar.Esansiyel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BisiparişÇekirdek.Valıklar.Erzak
{
    public class Restoran : İşyeri
    {
        #region Data Members (Veri Üyeler)
        #endregion

        #region Constructors (Oluşturucular) (Yapıcılar)
        public Restoran()
        {
        }

        public Restoran(string isim) : base(isim)
        {

        }
        #endregion

        #region Properties (Özellikler)
        public RestoranTürler Tür { get; set; }
        public RestoranHizmetler Hizmetler { get; set; }
        [NotMapped]
        public List<Menü> Menüler { get; set; }
        [NotMapped]
        public List<byte[]> Fotoğraflar { get; set; }
        [NotMapped]
        public List<ÇalışmaZamanlama> ÇalışmaZamanlamalar { get; set; }
        public OnayDurum OnayDurum { get; set; }
        #endregion

        #region Methods (Metotlar) (Yöntemler)
        #endregion
    }
}
