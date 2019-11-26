﻿using Microsoft.EntityFrameworkCore;
using BisiparişÇekirdek.Valıklar.Esansiyel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BisiparişÇekirdek.Valıklar.Erzak;
using BisiparişÇekirdek.Valıklar.VeriGünlüğü;
using BisiparişÇekirdek.Valıklar.Güvenlik;

namespace BisiparişVeriAltYapı
{
    public class BisiparişVeriYardımcı
    {
        #region Data Members (Veri Üyeler)
        #endregion

        #region Constructors (Oluşturucular) (Yapıcılar)
        static BisiparişVeriYardımcı()
        {

        }
        #endregion

        #region Properties (Özellikler)
        public static string BağlantıDizesi { get; set; }
        #endregion

        #region Methods (Metotlar) (Yöntemler)
        //public static async Task<List<Ülke>> ÜlkelerAl()
        //{
        //    try
        //    {
        //        using(var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var ülkeler = vtBğlm.Ülkeler;

        //            if (ülkeler != null && await ülkeler.AnyAsync())
        //                return await ülkeler.ToListAsync();
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<İl>> İllerAl()
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var iller = vtBğlm.İller;

        //            if (iller != null && await iller.AnyAsync())
        //                return await iller.ToListAsync();
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<İl>> İlçelerOlanİllerAl()
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var iller = vtBğlm.İller;

        //            if (iller != null && await iller.AnyAsync())
        //            {
        //                foreach (var il in iller)
        //                    il.İlçeler = await SemtlerOlanİlİlçelerAl(il.Id);

        //                return await iller.ToListAsync();
        //            }
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<İl> İlAl(int id)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            return await vtBğlm.İller.FirstAsync(il => il.Id == id);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<İlçe>> İlçelerAl()
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var vtİlçeler = vtBğlm.İlçeler;

        //            if (vtİlçeler != null && await vtİlçeler.AnyAsync())
        //                return await vtİlçeler.ToListAsync();
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<İlçe>> İlİlçelerAl(int ilId)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var il = await vtBğlm.İller.FirstAsync(birİl => birİl.Id == ilId);
        //            var vtİlİlçeler = vtBğlm.İlçeler.Where(ilç => ilç.İlId == il.Id);

        //            if (vtİlİlçeler != null && await vtİlİlçeler.AnyAsync())
        //                return await vtİlİlçeler.ToListAsync();
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<İlçe>> SemtlerOlanİlİlçelerAl(int ilId)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var il = await vtBğlm.İller.FirstAsync(birİl => birİl.Id == ilId);
        //            var vtİlİlçeler = vtBğlm.İlçeler.Where(ilç => ilç.İlId == il.Id);

        //            if (vtİlİlçeler != null && await vtİlİlçeler.AnyAsync())
        //            {
        //                foreach (var ilçe in vtİlİlçeler)
        //                    ilçe.Semtler = await MahallelerOlanİlçeSemtlerAl(ilçe.Id);

        //                return await vtİlİlçeler.ToListAsync();
        //            }
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
        
        //public static async Task<İlçe> İlçeAl(int id)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            return await vtBğlm.İlçeler.FirstAsync(ilç => ilç.Id == id);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<Semt>> SemtlerAl()
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var vtSemtler = vtBğlm.Semtler;

        //            if (vtSemtler != null && await vtSemtler.AnyAsync())
        //                return await vtSemtler.ToListAsync();
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<Semt>> İlçeSemtlerAl(int ilçeId)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var vtİlçSemtler = vtBğlm.Semtler.Where(smt => smt.İlçeId == ilçeId);

        //            if (vtİlçSemtler != null && await vtİlçSemtler.AnyAsync())
        //                return await vtİlçSemtler.ToListAsync();
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<Semt>> MahallelerOlanİlçeSemtlerAl(int ilçeId)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var vtİlçSemtler = vtBğlm.Semtler.Where(smt => smt.İlçeId == ilçeId);

        //            if (vtİlçSemtler != null && await vtİlçSemtler.AnyAsync())
        //            {
        //                foreach (var semt in vtİlçSemtler)
        //                    semt.Mahalleler = await SemtMahallelerAl(semt.Id);

        //                return await vtİlçSemtler.ToListAsync();
        //            }
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<Semt> SemtAl(int id)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            return await vtBğlm.Semtler.FirstAsync(smt => smt.Id == id);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<Mahalle>> MahallelerAl()
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var vtMahalleler = vtBğlm.Mahalleler;

        //            if (vtMahalleler != null && await vtMahalleler.AnyAsync())
        //                return await vtMahalleler.ToListAsync();
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<Mahalle>> SemtMahallelerAl(int semtId)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var vtMahSemtler = vtBğlm.Mahalleler.Where(mh => mh.SemtId == semtId);

        //            if (vtMahSemtler != null && await vtMahSemtler.AnyAsync())
        //                return await vtMahSemtler.ToListAsync();
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<Mahalle> MahalleAl(int id)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            return await vtBğlm.Mahalleler.FirstAsync(mh => mh.Id == id);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<Kafe>> KafelerAl()
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var kafeler = vtBğlm.Kafeler;

        //            if (kafeler != null && await kafeler.AnyAsync())
        //                return await kafeler.ToListAsync();
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<Kafe>> MahalleKafelerAl(int mahalleId)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var sorgu = from kf in vtBğlm.Kafeler
        //                        from ilt in vtBğlm.İşyeriİletişimler
        //                        from ydr in vtBğlm.YerlerAdresler
        //                        where kf.İletişimId == ilt.Id && ilt.AdresId == ydr.Id && ydr.MahalleId == mahalleId
        //                        select kf;

        //            if (sorgu != null && await sorgu.AnyAsync())
        //                return await sorgu.ToListAsync();
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<Kafe> KafeAl(int id)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            return await vtBğlm.Kafeler.FirstAsync(rst => rst.Id == id);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<İcraSonuç> YeniKafeEkle(Kafe yeniKafe)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var aynaKafe = await vtBğlm.Kafeler.FirstOrDefaultAsync(
        //                    kf => kf.İsim.Equals(yeniKafe.İsim, StringComparison.OrdinalIgnoreCase));

        //            if (aynaKafe == null)
        //            {
        //                yeniKafe.İletişimId = await İletişimKaydetme(vtBğlm, yeniKafe.İletişim);

        //                var kfEkledi = await vtBğlm.Kafeler.AddAsync(yeniKafe); await vtBğlm.SaveChangesAsync();

        //                if (kfEkledi != null && kfEkledi.Entity.Id > 0)
        //                {
        //                    if (yeniKafe.Fotoğraflar != null && yeniKafe.Fotoğraflar.Any())
        //                    {
        //                        foreach (var ftf in yeniKafe.Fotoğraflar)
        //                            vtBğlm.Fotoğraflar.Add(new ElemanFotoğraf()
        //                            { ElemanId = yeniKafe.Id, ElemanTip = FotoğrafElemanTip.Kafe, Fotoğraf = ftf });

        //                        await vtBğlm.SaveChangesAsync();
        //                    }

        //                    if (yeniKafe.Menüler != null && yeniKafe.Menüler.Any())
        //                    {
        //                        await MenülerKaydetme(vtBğlm, yeniKafe.Id, yeniKafe.Menüler);

        //                        foreach (var ftf in yeniKafe.Fotoğraflar)
        //                            vtBğlm.Fotoğraflar.Add(new ElemanFotoğraf()
        //                            { ElemanId = yeniKafe.Id, ElemanTip = FotoğrafElemanTip.Kafe, Fotoğraf = ftf });

        //                        await vtBğlm.SaveChangesAsync();
        //                    }

        //                    return İcraSonuç.Başarılı;
        //                }
        //                else
        //                    return İcraSonuç.BaşarıSız;
        //            }
        //            else
        //                return new İcraSonuç() { BaşarılıMı = false, Mesaj = "Bu kafe zaten var." };
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<İcraSonuç> KafeDeğiştir(Kafe kafe)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var öncekiKafe = await vtBğlm.Kafeler.FirstAsync(kf => kf.Id == kafe.Id);

        //            //öncekiKafe.ÇalışmaSaatleri
        //            öncekiKafe.AktifMi = kafe.AktifMi;

        //            await vtBğlm.SaveChangesAsync();

        //            return İcraSonuç.Başarılı;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<Restoran>> RestoranlarAl()
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var tümRstrn = vtBğlm.Restoranlar;

        //            if (tümRstrn != null && await tümRstrn.AnyAsync())
        //                return await tümRstrn.ToListAsync();
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<Restoran>> MahalleRestoranlarAl(int mahalleId)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var sorgu = from rst in vtBğlm.Restoranlar
        //                        from ilt in vtBğlm.İşyeriİletişimler
        //                        from ydr in vtBğlm.YerlerAdresler
        //                        where rst.İletişimId == ilt.Id && ilt.AdresId == ydr.Id && ydr.MahalleId == mahalleId
        //                        select rst;

        //            if (sorgu != null && await sorgu.AnyAsync())
        //                return await sorgu.ToListAsync();
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<Restoran> RestoranAl(int id)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            return await vtBğlm.Restoranlar.FirstAsync(rst => rst.Id == id);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<İcraSonuç> YeniRestoranEkle(Restoran yeniRestoran)
        //{
        //    try
        //    {
        //        //await GünlükKaydetme(new Günlük()
        //        //{
        //        //    Seviye = OlaySeviye.Uyarı,
        //        //    Kaynak = "VeriYardımcı.YeniRestoranEkle",
        //        //    Mesaj = "Into...",
        //        //    Tarih = DateTime.Now.ToString("dd-MM-yyyy"),
        //        //    Zaman = DateTime.Now.ToString("HH:mm:ss.fffff"),
        //        //});

        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            //await GünlükKaydetme(new Günlük()
        //            //{
        //            //    Seviye = OlaySeviye.Uyarı,
        //            //    Kaynak = "VeriYardımcı.YeniRestoranEkle",
        //            //    Mesaj = "Checking...",
        //            //    Tarih = DateTime.Now.ToString("dd-MM-yyyy"),
        //            //    Zaman = DateTime.Now.ToString("HH:mm:ss.fffff"),
        //            //});

        //            var aynaRstrn = await vtBğlm.Restoranlar.FirstOrDefaultAsync(
        //                                    rst => rst.İsim.Equals(yeniRestoran.İsim, StringComparison.OrdinalIgnoreCase));

        //            if (aynaRstrn == null)
        //            {
        //                //await GünlükKaydetme(new Günlük()
        //                //{
        //                //    Seviye = OlaySeviye.Uyarı,
        //                //    Kaynak = "VeriYardımcı.YeniRestoranEkle",
        //                //    Mesaj = "Restaurant name is new",
        //                //    Tarih = DateTime.Now.ToString("dd-MM-yyyy"),
        //                //    Zaman = DateTime.Now.ToString("HH:mm:ss.fffff"),
        //                //});

        //                yeniRestoran.İletişimId = await İletişimKaydetme(vtBğlm, yeniRestoran.İletişim);

        //                //await GünlükKaydetme(new Günlük()
        //                //{
        //                //    Seviye = OlaySeviye.Uyarı,
        //                //    Kaynak = "VeriYardımcı.İletişimKaydetme",
        //                //    Mesaj = "Actual restaurant save...",
        //                //    Tarih = DateTime.Now.ToString("dd-MM-yyyy"),
        //                //    Zaman = DateTime.Now.ToString("HH:mm:ss.fffff"),
        //                //});

        //                var rstEkledi = await vtBğlm.Restoranlar.AddAsync(yeniRestoran); await vtBğlm.SaveChangesAsync();

        //                if (rstEkledi != null && rstEkledi.Entity.Id > 0)
        //                {
        //                    //await GünlükKaydetme(new Günlük()
        //                    //{
        //                    //    Seviye = OlaySeviye.Uyarı,
        //                    //    Kaynak = "VeriYardımcı.İletişimKaydetme",
        //                    //    Mesaj = "Checking restaurant menus...",
        //                    //    Tarih = DateTime.Now.ToString("dd-MM-yyyy"),
        //                    //    Zaman = DateTime.Now.ToString("HH:mm:ss.fffff"),
        //                    //});

        //                    await MenülerKaydetme(vtBğlm, yeniRestoran.Id, yeniRestoran.Menüler);

        //                    //var nPics = yeniRestoran.Fotoğraflar != null ? $"Found: {yeniRestoran.Fotoğraflar.Count} pics" : "No pics";

        //                    //await GünlükKaydetme(new Günlük()
        //                    //{
        //                    //    Seviye = OlaySeviye.Uyarı,
        //                    //    Kaynak = "VeriYardımcı.İletişimKaydetme",
        //                    //    Mesaj = $"Checking restaurant photos ({nPics})",
        //                    //    Tarih = DateTime.Now.ToString("dd-MM-yyyy"),
        //                    //    Zaman = DateTime.Now.ToString("HH:mm:ss.fffff"),
        //                    //});

        //                    if (yeniRestoran.Fotoğraflar != null && yeniRestoran.Fotoğraflar.Any())
        //                    {
        //                        foreach (var ftf in yeniRestoran.Fotoğraflar)
        //                            vtBğlm.Fotoğraflar.Add(new VarlıkFotoğraf()
        //                            { VarlıkId = yeniRestoran.Id, VarlıkTip = FotoğrafVarlıkTip.Restoran, Fotoğraf = ftf });

        //                        await vtBğlm.SaveChangesAsync();
        //                    }

        //                    //await GünlükKaydetme(new Günlük()
        //                    //{
        //                    //    Seviye = OlaySeviye.Uyarı,
        //                    //    Kaynak = "VeriYardımcı.YeniRestoranEkle",
        //                    //    Mesaj = "Saved successsfully",
        //                    //    Tarih = DateTime.Now.ToString("dd-MM-yyyy"),
        //                    //    Zaman = DateTime.Now.ToString("HH:mm:ss.fffff"),
        //                    //});

        //                    return new İcraSonuç() { BaşarılıMı = true, YeniEklediId = yeniRestoran.Id };
        //                }
        //                else
        //                    return İcraSonuç.BaşarıSız;
        //            }
        //            else
        //                return new İcraSonuç() { BaşarılıMı = false, Mesaj = "Bu restoran zaten var." };
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<İcraSonuç> RestoranDeğiştir(Restoran restoran)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var öncekiRstr = await vtBğlm.Restoranlar.FirstAsync(kf => kf.Id == restoran.Id);

        //            //öncekiRstr.ÇalışmaSaatleri
        //            öncekiRstr.AktifMi = restoran.AktifMi;

        //            await vtBğlm.SaveChangesAsync();

        //            return İcraSonuç.Başarılı;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<Menü>> RestoranMenülerAl(int restoranId)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var mnulr = vtBğlm.Menüler.Where(m => m.YerTür == YerTür.Restoran && m.YerId == restoranId);

        //            if (mnulr != null && await mnulr.AnyAsync())
        //                return await mnulr.ToListAsync();
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        ////public static async Task<İşyeriİletişim> RestoranİletişimAl(int iletişimId)
        ////{
        ////    try
        ////    {
        ////        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        ////        {
        ////            var rstİletişim = await vtBğlm.İşyeriİletişimler.FirstOrDefaultAsync(m => m.Id == iletişimId);

        ////            if (rstİletişim != null)
        ////            {
        ////                rstİletişim.Adres = await vtBğlm.YerlerAdresler.FirstAsync(ya => ya.Id == rstİletişim.AdresId);

        ////                //TODO: Get telephones and emails

        ////                return rstİletişim;
        ////            }
        ////            else
        ////                return null;
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {

        ////        throw ex;
        ////    }
        ////}

        //public static async Task<List<VarlıkFotoğraf>> RestoranFotoğraflarAl(int restoranId)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var fotolr = vtBğlm.Fotoğraflar.Where(m => m.VarlıkTip == FotoğrafVarlıkTip.Restoran && m.VarlıkId == restoranId);

        //            if (fotolr != null && await fotolr.AnyAsync())
        //                return await fotolr.ToListAsync();
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<Menü>> KafeMenülerAl(int kafeId)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var mnulr = vtBğlm.Menüler.Where(m => m.YerTür == YerTür.Kafe && m.YerId == kafeId);

        //            if (mnulr != null && await mnulr.AnyAsync())
        //                return await mnulr.ToListAsync();
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<İşyeriİletişim> KafeİletişimAl(int iletişimId)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var kfİletişim = await vtBğlm.İşyeriİletişimler.FirstOrDefaultAsync(m => m.Id == iletişimId);

        //            if (kfİletişim != null)
        //            {
        //                kfİletişim.Adres = await vtBğlm.YerlerAdresler.FirstAsync(ya => ya.Id == kfİletişim.AdresId);

        //                //TODO: Get telephones and emails

        //                return kfİletişim;
        //            }
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<List<ElemanFotoğraf>> KafeFotoğraflarAl(int restoranId)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var fotolr = vtBğlm.Fotoğraflar.Where(m => m.ElemanTip == FotoğrafElemanTip.Kafe && m.ElemanId == restoranId);

        //            if (fotolr != null && await fotolr.AnyAsync())
        //                return await fotolr.ToListAsync();
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<Menü> MenüAl(int menüId)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            return await vtBğlm.Menüler.FirstAsync(m => m.Id == menüId);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<İcraSonuç> YeniMenüEkle(Menü yeniMenü)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var aynaMnu = await vtBğlm.Menüler.FirstOrDefaultAsync(mn =>
        //                                        mn.Ad.Equals(yeniMenü.Ad, StringComparison.OrdinalIgnoreCase));

        //            if (aynaMnu == null)
        //            {
        //                var mnEkledi = await vtBğlm.Menüler.AddAsync(yeniMenü); await vtBğlm.SaveChangesAsync();

        //                if (mnEkledi != null && mnEkledi.Entity.Id > 0)
        //                {
        //                    foreach (var mnuÖğ in yeniMenü.MenüÖğeler)
        //                    {
        //                        mnuÖğ.MenüId = yeniMenü.Id; await vtBğlm.MenülerÖğeler.AddAsync(mnuÖğ);
        //                    }

        //                    await vtBğlm.SaveChangesAsync();

        //                    return new İcraSonuç() { BaşarılıMı = true, YeniEklediId = yeniMenü.Id };
        //                }
        //                else
        //                    return İcraSonuç.BaşarıSız;
        //            }
        //            else
        //                return new İcraSonuç() { BaşarılıMı = false, Mesaj = "Bu restoran zaten var." };
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<İcraSonuç> MenüDeğiştir(Menü menü)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var öncekiMnu = await vtBğlm.Menüler.FirstAsync(mn => mn.Id == menü.Id);

        //            //öncekiRstr.ÇalışmaSaatleri
        //            öncekiMnu.AktifMi = menü.AktifMi;

        //            await vtBğlm.SaveChangesAsync();

        //            return İcraSonuç.Başarılı;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<bool> GirişİsimZatenKullanıldıMı(string girişİsim)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            return await vtBğlm.Kullanıcılar.AnyAsync(k => k.Girişİsim.Equals(girişİsim));
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<Kullanıcı> Giriş(string girişİsim, string şifre)
        //{
        //    try
        //    {
        //        //await GünlükKaydetme(OlaySeviye.Ayıklama, $"Into -- {girişİsim} || {şifre}");

        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var klnc = await vtBğlm.Kullanıcılar.FirstOrDefaultAsync(k => k.Girişİsim == girişİsim);

        //            //var bulundu = klnc != null ? "Evet" : "Yok";
        //            //await GünlükKaydetme(OlaySeviye.Ayıklama, $"Result: {bulundu}");

        //            if (klnc != null)
        //            {
        //                if (string.Compare(klnc.Şifre, şifre, false) == 0)
        //                {
        //                    //await GünlükKaydetme(OlaySeviye.Ayıklama, "Logged in timestamp...");

        //                    klnc.SonGirişTarihVeZaman = DateTime.Now;
        //                    await vtBğlm.SaveChangesAsync();

        //                    //await GünlükKaydetme(OlaySeviye.Ayıklama, "Returning...");

        //                    return klnc;
        //                }
        //                else
        //                    return null;
        //            }
        //            else
        //                return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        await GünlükKaydetme(OlaySeviye.Hata, ex.Message);
        //        throw ex;
        //    }
        //}

        //public static async Task<İcraSonuç> YeniKullanıcıEkle(Kullanıcı yeniKullanıcı)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            await vtBğlm.Kullanıcılar.AddAsync(yeniKullanıcı);

        //            await vtBğlm.SaveChangesAsync();

        //            return new İcraSonuç() { BaşarılıMı = true, YeniEklediId = yeniKullanıcı.Id };
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<İcraSonuç> KullanıcıDegiştir(Kullanıcı kullanıcı)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var klnc = await vtBğlm.Kullanıcılar.FirstAsync(k => k.Id == kullanıcı.Id);

        //            klnc.AktifMi = kullanıcı.AktifMi; klnc.Cinsiyet = kullanıcı.Cinsiyet;
        //            klnc.Rol = kullanıcı.Rol; klnc.Şifre = kullanıcı.Şifre;

        //            await vtBğlm.SaveChangesAsync();

        //            return İcraSonuç.Başarılı;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static async Task<İcraSonuç> ŞifreDegiştir(int kullanıcıId, string şifre)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            var klnc = await vtBğlm.Kullanıcılar.FirstAsync(k => k.Id == kullanıcıId);

        //            klnc.Şifre = şifre;

        //            await vtBğlm.SaveChangesAsync();

        //            return İcraSonuç.Başarılı;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
        //public static async Task<İcraSonuç> YeniKullanıcıEkle(Kullanıcı yeniKullanıcı)
        //{
        //    try
        //    {
        //        using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
        //        {
        //            //vtBğlm.Hesaplar.

        //            await vtBğlm.SaveChangesAsync();

        //            return İcraSonuç.Başarılı;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //private static async Task MenülerKaydetme(BisiparişVeriBağlam vtBğlm, int yerId, List<Menü> menüler)
        //{
        //    try
        //    {
        //        if (menüler != null && menüler.Any())
        //        {
        //            foreach (var mn in menüler)
        //            {
        //                mn.YerId = yerId;

        //                var mnEkldi = await vtBğlm.Menüler.AddAsync(mn);

        //                if (mnEkldi != null && mnEkldi.Entity.Id > 0 && mn.MenüÖğeler != null && mn.MenüÖğeler.Any())
        //                    foreach (var mnuÖğ in mn.MenüÖğeler)
        //                    {
        //                        mnuÖğ.MenüId = mn.Id;

        //                        await vtBğlm.MenülerÖğeler.AddAsync(mnuÖğ);
        //                    }
        //            }

        //            await vtBğlm.SaveChangesAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        public static async Task<int> İletişimKaydet(BisiparişVeriBağlam vtBğlm, İşyeriİletişim iletişim)
        {
            try
            {
                //await GünlükKaydetme(new Günlük()
                //{
                //    Seviye = OlaySeviye.Uyarı,
                //    Kaynak = "VeriYardımcı.İletişimKaydetme",
                //    Mesaj = "Saving communication...",
                //    Tarih = DateTime.Now.ToString("dd-MM-yyyy"),
                //    Zaman = DateTime.Now.ToString("HH:mm:ss.fffff"),
                //});

                if (iletişim != null)
                {
                    if (iletişim.Adres != null)
                    {
                        iletişim.Adres.SistemDurum = VarlıkSistemDurum.Aktif; iletişim.Adres.Oluşturulduğunda = DateTime.Now;

                        await vtBğlm.YerlerAdresler.AddAsync(iletişim.Adres); await vtBğlm.SaveChangesAsync();

                        iletişim.AdresId = iletişim.Adres.Id;
                    }

                    iletişim.SistemDurum = VarlıkSistemDurum.Aktif; iletişim.Oluşturulduğunda = DateTime.Now;

                    await vtBğlm.İşyeriİletişimler.AddAsync(iletişim); await vtBğlm.SaveChangesAsync();

                    return iletişim.Id;
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                await BisiparişVeriYardımcı.GünlükKaydet(OlaySeviye.Hata, ex);
                throw;
            }
        }
        
        public static async Task<İşyeriİletişim> İşyeriİletişimAl(int id)
        {
            try
            {
                using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
                {
                    var iletişim = await vtBğlm.İşyeriİletişimler.FirstAsync(m => m.Id == id);

                    iletişim.Adres = await vtBğlm.YerlerAdresler.FirstAsync(ad => ad.Id == iletişim.AdresId);

                    //TODO: Get telephones and emails

                    return iletişim;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static async Task SistemİşlemKaydet(Sistemİşlem işlem)
        {
            try
            {
                using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
                {
                    await vtBğlm.Sistemİşlemler.AddAsync(işlem); await vtBğlm.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static async Task GünlükKaydet(Günlük günlük)
        {
            try
            {
                using (var vtBğlm = new BisiparişVeriBağlam() { BağlantıDizesi = BağlantıDizesi })
                {
                    var newEntry = await vtBğlm.BilgiGünlük.AddAsync(günlük); await vtBğlm.SaveChangesAsync();

                    //if (newEntry != null)
                    //{
                    //    var newId = newEntry.Entity != null ? newEntry.Entity.Id : -1;
                    //    return $"{newEntry.State} | {newId}";
                    //}
                    //else
                    //    return "NULL";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static async Task GünlükKaydet(OlaySeviye seviye, string mesaj)
        {
            try
            {
                var şimdi = DateTime.Now;
                var method = new System.Diagnostics.StackFrame(4).GetMethod(); var methodContainer = method.DeclaringType;

                await GünlükKaydet(
                    new Günlük()
                    {
                        Seviye = seviye,
                        Kaynak = $"{methodContainer.FullName}.{method.Name}",
                        Mesaj = mesaj,
                        Tarih = şimdi.ToString("dd-MM-yyyy"),
                        Zaman = şimdi.ToString("HH:mm:ss.fffff")
                    });
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static async Task GünlükKaydet(OlaySeviye seviye, Exception ex)
        {
            try
            {
                var şimdi = DateTime.Now;
                var method = new System.Diagnostics.StackFrame(4).GetMethod(); var methodContainer = method.DeclaringType;

                await GünlükKaydet(
                    new Günlük()
                    {
                        Seviye = seviye,
                        Kaynak = $"{methodContainer.FullName}.{method.Name}",
                        Mesaj = GetInnerExceptions(ex),
                        Tarih = şimdi.ToString("dd-MM-yyyy"),
                        Zaman = şimdi.ToString("HH:mm:ss.fffff")
                    });
            }
            catch (Exception exp)
            {

                throw exp;
            }
        }

        private static string GetInnerExceptions(Exception ex)
        {
            string exceptionMessage = string.Format("[{2}] Message: {0} {1}", ex.Message,
                                        (!string.IsNullOrWhiteSpace(ex.Source) ? "Source: " + ex.Source : ""),
                                        ex.GetType().FullName);

            if (ex.InnerException != null)
                exceptionMessage += " -- INNER: " + GetInnerExceptions(ex.InnerException);

            return exceptionMessage;
        }
        #endregion
    }
}
