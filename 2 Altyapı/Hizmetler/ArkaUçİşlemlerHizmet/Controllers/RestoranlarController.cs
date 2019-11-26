﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BisiparişÇekirdek.Valıklar.Erzak;
using BisiparişÇekirdek.Valıklar.Esansiyel;
using BisiparişÇekirdek.Valıklar.VeriGünlüğü;
using BisiparişVeriAltYapı;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArkaUçİşlemlerHizmet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RestoranlarController : ControllerBase
    {
        #region Data Members (Veri Üyeler)
        #endregion

        #region Constructors (Oluşturucular) (Yapıcılar)
        #endregion

        #region Properties (Özellikler)
        #endregion

        #region Methods (Metotlar) (Yöntemler)
        [ActionName("RestoranlarAl")]
        [HttpGet]
        public async Task<ActionResult<List<Restoran>>> Get()
        {
            try
            {
                var restoranlar = await BisiparişVeriAltYapı.RestoranlarVeriYardımcı.RestoranlarAl();

                return restoranlar;
                //if (restoranlar != null && restoranlar.Any())
                //    return Ok(restoranlar);
                //else
                //    return new EmptyResult();
            }
            catch (Exception ex)
            {
                await BisiparişVeriYardımcı.GünlükKaydet(OlaySeviye.Hata, ex);
                throw ex;
            }
        }

        [ActionName("RestoranAl")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Restoran>> Get(int id)
        {
            try
            {
                var restoran = await BisiparişVeriAltYapı.RestoranlarVeriYardımcı.RestoranAl(id);

                return restoran;//Ok(restoran);
            }
            catch (Exception ex)
            {
                await BisiparişVeriYardımcı.GünlükKaydet(OlaySeviye.Hata, ex);
                throw ex;
            }
        }

        [ActionName("ŞimdikiKullanıcıRestoranlarAl")]
        [HttpGet("{kullanıcıId}")]
        public async Task<ActionResult<List<Restoran>>> ŞimdikiKullanıcıRestoranlarAl(int kullanıcıId)
        {
            try
            {
                return await RestoranlarVeriYardımcı.ŞimdikiKullanıcıRestoranlarAl(kullanıcıId);
            }
            catch (Exception ex)
            {
                await BisiparişVeriYardımcı.GünlükKaydet(OlaySeviye.Hata, ex);
                throw ex;
            }
        }

        [ActionName("YeniRestoranlarAl")]
        [HttpGet]
        public async Task<ActionResult<List<Restoran>>> YeniRestoranlarAl()
        {
            try
            {
                return await BisiparişVeriAltYapı.RestoranlarVeriYardımcı.YeniRestoranlarAl();
            }
            catch (Exception ex)
            {
                await BisiparişVeriYardımcı.GünlükKaydet(OlaySeviye.Hata, ex);
                throw ex;
            }
        }

        [ActionName("RestoranFotoğraflarAl")]
        [HttpGet("{id}")]
        public async Task<ActionResult<List<VarlıkFotoğraf>>> RestoranFotoğraflarAl(int id)
        {
            try
            {
                var fotolr = await BisiparişVeriAltYapı.RestoranlarVeriYardımcı.RestoranFotoğraflarAl(id);

                return fotolr;
            }
            catch (Exception ex)
            {
                await BisiparişVeriYardımcı.GünlükKaydet(OlaySeviye.Hata, ex);
                throw ex;
            }
        }

        [ActionName("HizmetlerDeğiştir")]
        [HttpPost]
        public async Task<ActionResult<İcraSonuç>> HizmetlerDeğiştir(List<string> rstrnIdVeHzmtlr)
        {
            try
            {
                return await RestoranlarVeriYardımcı.HizmetlerDeğiştir(int.Parse(rstrnIdVeHzmtlr[0]),
                                            (RestoranHizmetler)Enum.Parse(typeof(RestoranHizmetler), rstrnIdVeHzmtlr[1]));
            }
            catch (Exception ex)
            {
                await BisiparişVeriYardımcı.GünlükKaydet(OlaySeviye.Hata, ex);
                throw ex;
            }
        }

        [ActionName("RestoranOnayla")]
        [HttpPost]
        public async Task<ActionResult<İcraSonuç>> RestoranOnayla(int restoranId)
        {
            try
            {
                //await BisiparişVeriAltYapı.BisiparişVeriYardımcı.GünlükKaydetme(new BisiparişÇekirdek.Valıklar.VeriGünlüğü.Günlük()
                //{
                //    Seviye = BisiparişÇekirdek.Valıklar.VeriGünlüğü.OlaySeviye.Uyarı,
                //    Kaynak = "RestoranlarController.Post",
                //    Mesaj = "DB Saving new restaurant...",
                //    Tarih = DateTime.Now.ToString("dd-MM-yyyy"),
                //    Zaman = DateTime.Now.ToString("HH:mm:ss.fffff"),
                //});

                var sonuç = await BisiparişVeriAltYapı.RestoranlarVeriYardımcı.RestoranOnayla(restoranId);

                //await BisiparişVeriAltYapı.BisiparişVeriYardımcı.GünlükKaydetme(new BisiparişÇekirdek.Valıklar.VeriGünlüğü.Günlük()
                //{
                //    Seviye = BisiparişÇekirdek.Valıklar.VeriGünlüğü.OlaySeviye.Uyarı,
                //    Kaynak = "RestoranlarController.Post",
                //    Mesaj = sonuç != null ? "Result is there" : "(NULL result)",
                //    Tarih = DateTime.Now.ToString("dd-MM-yyyy"),
                //    Zaman = DateTime.Now.ToString("HH:mm:ss.fffff"),
                //});

                return sonuç;
            }
            catch (Exception ex)
            {
                await BisiparişVeriYardımcı.GünlükKaydet(OlaySeviye.Hata, ex);
                throw ex;
            }
        }

        [ActionName("RestoranReddet")]
        [HttpPost]
        public async Task<ActionResult<İcraSonuç>> RestoranReddet(List<string> idVeSebep)
        {
            try
            {
                //await BisiparişVeriAltYapı.BisiparişVeriYardımcı.GünlükKaydetme(new BisiparişÇekirdek.Valıklar.VeriGünlüğü.Günlük()
                //{
                //    Seviye = BisiparişÇekirdek.Valıklar.VeriGünlüğü.OlaySeviye.Uyarı,
                //    Kaynak = "RestoranlarController.Post",
                //    Mesaj = "DB Saving new restaurant...",
                //    Tarih = DateTime.Now.ToString("dd-MM-yyyy"),
                //    Zaman = DateTime.Now.ToString("HH:mm:ss.fffff"),
                //});

                var sonuç = await BisiparişVeriAltYapı.RestoranlarVeriYardımcı.RestoranReddet(int.Parse(idVeSebep[0]), idVeSebep[1]);

                //await BisiparişVeriAltYapı.BisiparişVeriYardımcı.GünlükKaydetme(new BisiparişÇekirdek.Valıklar.VeriGünlüğü.Günlük()
                //{
                //    Seviye = BisiparişÇekirdek.Valıklar.VeriGünlüğü.OlaySeviye.Uyarı,
                //    Kaynak = "RestoranlarController.Post",
                //    Mesaj = sonuç != null ? "Result is there" : "(NULL result)",
                //    Tarih = DateTime.Now.ToString("dd-MM-yyyy"),
                //    Zaman = DateTime.Now.ToString("HH:mm:ss.fffff"),
                //});

                return sonuç;
            }
            catch (Exception ex)
            {
                await BisiparişVeriYardımcı.GünlükKaydet(OlaySeviye.Hata, ex);
                throw ex;
            }
        }

        [ActionName("YeniRestoranEkle")]
        [HttpPost]
        public async Task<ActionResult<İcraSonuç>> Post(Restoran yeniRestoran)
        {
            try
            {
                //await BisiparişVeriYardımcı.GünlükKaydetme(OlaySeviye.Uyarı, "DB Saving new restaurant...");

                var sonuç = await RestoranlarVeriYardımcı.YeniRestoranEkle(yeniRestoran);

                if (sonuç.BaşarılıMı)
                    BisiparişSistemVeriYardımcı.İşlemKaydet(new Sistemİşlem()
                    {
                        KullanıcıId = yeniRestoran.OluşturuKimsiId,
                        Tip = İşlemTip.YeniRestoranEkledi,
                        ÖğeId = yeniRestoran.Id
                    });

                //await BisiparişVeriYardımcı.GünlükKaydetme(OlaySeviye.Uyarı, sonuç != null ? "Result is there" : "(NULL result)");

                return sonuç;

                //if (sonuç.BaşarılıMı)
                //    return Ok(sonuç);//CreatedAtAction(nameof(Post), new { id = yeniRestoran.Id }, yeniRestoran);
                //else
                //    return BadRequest(sonuç);
            }
            catch (Exception ex)
            {
                await BisiparişVeriYardımcı.GünlükKaydet(OlaySeviye.Hata, ex);
                throw ex;
            }
        }

        [ActionName("RestoranDeğiştir")]
        [HttpPut]
        public async Task<ActionResult<İcraSonuç>> Put(Restoran restoran)
        {
            try
            {
                var sonuç = await RestoranlarVeriYardımcı.RestoranDeğiştir(restoran);

                if (sonuç.BaşarılıMı)
                    BisiparişSistemVeriYardımcı.İşlemKaydet(new Sistemİşlem()
                    {
                        KullanıcıId = restoran.OluşturuKimsiId,
                        Tip = İşlemTip.RestoranDeğiştirdi,
                        ÖğeId = restoran.Id
                    });

                return sonuç;

                //if (sonuç.BaşarılıMı)
                //    return Ok();
                //else
                //    return BadRequest(sonuç.Mesaj);
            }
            catch (Exception ex)
            {
                await BisiparişVeriYardımcı.GünlükKaydet(OlaySeviye.Hata, ex);
                throw ex;
            }
        }
        #endregion
    }
}