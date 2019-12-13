﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HazırlaÇekirdek.Valıklar.Esansiyel;
using HazırlaÇekirdek.Valıklar.Muhasebe;
using HazırlaÇekirdek.Valıklar.VeriGünlüğü;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaliHizmet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KuponlarController : ControllerBase
    {
        #region Data Members (Veri Üyeler)
        #endregion

        #region Constructors (Oluşturucular) (Yapıcılar)
        #endregion

        #region Properties (Özellikler)
        #endregion

        #region Methods (Metotlar) (Yöntemler)
        [ActionName("Kuponlar")]
        [HttpGet]
        public async Task<ActionResult<List<Kupon>>> Get()
        {
            try
            {
                return await HazırlaVeriAltYapı.MaliVeriYardımcı.KuponlarAl();
            }
            catch (Exception ex)
            {
                await HazırlaVeriAltYapı.HazırlaVeriYardımcı.GünlükKaydet(OlaySeviye.Hata, ex);
                throw ex;
            }
        }

        [ActionName("YeniKuponEkle")]
        [HttpPost]
        public async Task<ActionResult<İcraSonuç>> Post(Kupon yeniKupon)
        {
            try
            {
                return await HazırlaVeriAltYapı.MaliVeriYardımcı.YeniKuponEkle(yeniKupon);
            }
            catch (Exception ex)
            {
                await HazırlaVeriAltYapı.HazırlaVeriYardımcı.GünlükKaydet(OlaySeviye.Hata, ex);
                throw ex;
            }
        }

        [ActionName("KuponDeaktifEt")]
        [HttpPost]
        public async Task<ActionResult<İcraSonuç>> KuponDeaktifEt(int kuponId)
        {
            try
            {
                return await HazırlaVeriAltYapı.MaliVeriYardımcı.KuponDeaktifEt(kuponId);
            }
            catch (Exception ex)
            {
                await HazırlaVeriAltYapı.HazırlaVeriYardımcı.GünlükKaydet(OlaySeviye.Hata, ex);
                throw ex;
            }
        }
        #endregion
    }
}