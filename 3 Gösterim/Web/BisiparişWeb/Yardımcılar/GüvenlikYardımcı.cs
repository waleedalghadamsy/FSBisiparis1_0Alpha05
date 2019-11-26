﻿using BisiparişÇekirdek.Valıklar.Esansiyel;
using BisiparişÇekirdek.Valıklar.Güvenlik;
using BisiparişÇekirdek.Valıklar.VeriGünlüğü;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using BisiparişÇekirdek.Valıklar.Erzak;

namespace BisiparişWeb.Yardımcılar
{
    public class GüvenlikYardımcı
    {
        #region Data Members (Veri Üyeler)
        #endregion

        #region Constructors (Oluşturucular) (Yapıcılar)
        static GüvenlikYardımcı()
        {
            Kullanıcılar = new List<Kullanıcı>(); 
        }
        #endregion

        #region Properties (Özellikler)
        public static string GüvenlikHizmetUrl { get; set; }
        private static string KullanıcılarUrl => $"{GüvenlikHizmetUrl}/Kullanıcılar";
        public static bool KullanıcıGirişYaptıMı
        {
            get
            {
                return BisiparişWebYardımcı.Session.Keys.Contains("GirişYaptıMı") ? BisiparişWebYardımcı.Session.GetString("GirişYaptıMı").Equals("Evet") : false;
            }
            set
            {
                if (value)
                    BisiparişWebYardımcı.Session.SetString("GirişYaptıMı", "Evet");
                else
                    BisiparişWebYardımcı.Session.SetString("GirişYaptıMı", "Hayır");
            }
        }
        public static Kullanıcı ŞimdikiKullanıcı
        {
            get
            {
                try
                {
                    //Task.Run(async () => await BisiparişWebYardımcı.AyıklamaKaydet("Retrieveing user from session"));

                    var jsonKlnc = BisiparişWebYardımcı.Session.Keys.Contains("ŞuAnkiKullanıcı") ?      
                                        BisiparişWebYardımcı.Session.GetString("ŞuAnkiKullanıcı") 
                                        : null;

                    //Task.Run(async () => await BisiparişWebYardımcı.AyıklamaKaydet(
                    //        !string.IsNullOrWhiteSpace(jsonKlnc) ? jsonKlnc : "(Nothing)"));

                    return !string.IsNullOrWhiteSpace(jsonKlnc)  ? 
                        Newtonsoft.Json.JsonConvert.DeserializeObject<Kullanıcı>(jsonKlnc) 
                        : null;
                }
                catch (Exception ex)
                {
                    Task.Run(async () => await BisiparişWebYardımcı.HataKaydet(ex));

                    return null;
                }
            }
            set
            {
                try
                {
                    var jsnUser = Newtonsoft.Json.JsonConvert.SerializeObject(value);
                    //var ssn = BisiparişWebYardımcı.Session != null ? "OK" : "(null)";

                    //Task.Run(async() => {
                    //    await BisiparişWebYardımcı.AyıklamaKaydet($"JSON User: {jsnUser}");
                    //    await BisiparişWebYardımcı.AyıklamaKaydet($"Session: {ssn}");
                    //});

                    BisiparişWebYardımcı.Session.SetString("ŞuAnkiKullanıcı", jsnUser);

                    //Task.Run(async () =>
                    //{
                    //    try
                    //    {
                    //        //await GünlükKaydetme(OlaySeviye.Ayıklama, "Into Session User Set");

                    //        var jsnUser = Newtonsoft.Json.JsonConvert.SerializeObject(value);

                    //        //await GünlükKaydetme(OlaySeviye.Ayıklama, $"JSON User: {jsnUser}");

                    //        BisiparişWebYardımcı.Session.SetString("ŞuAnkiKullanıcı", jsnUser);

                    //        //await GünlükKaydetme(OlaySeviye.Ayıklama, "The user object is stored in session");

                    //        //var usrKey = Session.Keys.Contains("ŞuAnkiKullanıcı");

                    //        //await GünlükKaydetme(OlaySeviye.Ayıklama, $"Is the user really in session: {usrKey}");

                    //        //var ssnUsr = Session.GetString("ŞuAnkiKullanıcı");

                    //        //await GünlükKaydetme(OlaySeviye.Ayıklama, $"Verifying user from session: {ssnUsr}");
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        await BisiparişWebYardımcı.GünlükKaydetme(OlaySeviye.Hata, ex);
                    //    }
                    //});
                }
                catch (Exception ex)
                {
                    Task.Run(async () => await BisiparişWebYardımcı.HataKaydet(ex));
                }
            }
        }
        public static int ŞimdikiKullanıcıId
        {
            get
            {
                return BisiparişWebYardımcı.Session.Keys.Contains("KullanıcıId") ? BisiparişWebYardımcı.Session.GetInt32("KullanıcıId").Value : -1;
            }
            set
            {
                BisiparişWebYardımcı.Session.SetInt32("KullanıcıId", value);
            }
        }
        public static string ŞimdikiKullanıcıİsim
        {
            get
            {
                try
                {
                    //var isSessionAvailable = BisiparişWebYardımcı.Session != null ? "OK" : "(NULL)";

                    //Task.Run(async () => await BisiparişWebYardımcı.GünlükKaydetme(OlaySeviye.Ayıklama, "Into..."));
                    //Task.Run(async () => await BisiparişWebYardımcı.GünlükKaydetme(OlaySeviye.Ayıklama,
                    //    $"Session obj: {isSessionAvailable}"));

                    return BisiparişWebYardımcı.Session.Keys.Contains("Kullanıcıİsim") 
                        ? BisiparişWebYardımcı.Session.GetString("Kullanıcıİsim") : "(Hiç kimse)";
                }
                catch (Exception ex)
                {
                    Task.Run(async () => await BisiparişWebYardımcı.HataKaydet(ex));
                    return "(ERROR!)";
                }
            }
            set
            {
                try
                {
                    //Task.Run(async () => await BisiparişWebYardımcı.GünlükKaydetme(OlaySeviye.Ayıklama, "Setting user name..."));
                    BisiparişWebYardımcı.Session.SetString("Kullanıcıİsim", value);
                }
                catch (Exception ex)
                {
                    Task.Run(async () => await BisiparişWebYardımcı.HataKaydet(ex));
                }
            }
        }
        public static bool ŞimdikiKullanıcıSistemYöneticiMi => ŞimdikiKullanıcı.Rol == KullanıcıRol.SistemYönetici;
        public static bool ŞimdikiKullanıcıİşletmeYöneticiMi => ŞimdikiKullanıcı.Rol == KullanıcıRol.İşletmeYönetici;
        public static bool ŞimdikiKullanıcıDestekTemsilciMi => ŞimdikiKullanıcı.Rol == KullanıcıRol.MüşteriDestekTemsilci;
        public static bool ŞimdikiKullanıcıİşletmeKullanıcıMı => ŞimdikiKullanıcı.Rol == KullanıcıRol.İşletmeKullanıcı;
        public static bool ŞimdikiKullanıcıMüşteriMi => ŞimdikiKullanıcı.Rol == KullanıcıRol.Müşteri;
        public static string ŞuAnkiKullanıcıMenüKısmiGörüntü { get; set; }
        public static List<Kullanıcı> Kullanıcılar { get; set; }
        public static List<SelectListItem> KullanıcıRolar { get; set; }

        #endregion

        #region Methods (Metotlar) (Yöntemler)
        public static async Task<List<Kullanıcı>> KullanıcılarAl()
        {
            try
            {
                using (var istemci = new System.Net.Http.HttpClient())
                {
                    //await BisiparişWebYardımcı.AyıklamaKaydet($"Getting users... {GüvenlikHizmetUrl}");

                    var jsonStr = await istemci.GetStringAsync(KullanıcılarUrl + "/KullanıcılarAl");
                    var rslt = !string.IsNullOrWhiteSpace(jsonStr) ? "OK" : "(null)";

                    //await BisiparişWebYardımcı.AyıklamaKaydet($"Back from service -- {rslt}");

                    if (!string.IsNullOrWhiteSpace(jsonStr))
                        Kullanıcılar = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanıcı>>(jsonStr);

                    return Kullanıcılar;
                }
            }
            catch (Exception ex)
            {
                await BisiparişWebYardımcı.HataKaydet(ex);
                throw ex;
            }
        }

        public static void KullanıcıVeriHazırla()
        {
            try
            {
                Task.Run(async () =>
                {
                    await BisiparişWebYardımcı.AyıklamaKaydet("Into...");

                    if (ŞimdikiKullanıcı != null)
                    {
                        if (ŞimdikiKullanıcı.Rol == KullanıcıRol.SistemYönetici)
                        {
                            KullanıcıRolar = new List<SelectListItem>()
                                {
                                    new SelectListItem() { Value = "0", Text = "(Rol seçiniz)", Selected = true },
                                    new SelectListItem() { Value = "1", Text = "Sistem Yönetici" },
                                    new SelectListItem() { Value = "2", Text = "Müşteri Destek Temsilci" },
                                    new SelectListItem() { Value = "3", Text = "İşletme Yönetici" },
                                    new SelectListItem() { Value = "4", Text = "İşletme Çalışan" }
                                };
                        }
                        else if (ŞimdikiKullanıcı.Rol == KullanıcıRol.İşletmeYönetici)
                        {
                            KullanıcıRolar = new List<SelectListItem>()
                                {
                                    new SelectListItem() { Value = "0", Text = "(Rol seçiniz)", Selected = true },
                                    new SelectListItem() { Value = "3", Text = "İşletme Yönetici" },
                                    new SelectListItem() { Value = "4", Text = "İşletme Çalışan" }
                                };
                        }
                    }
                    else
                        await BisiparişWebYardımcı.AyıklamaKaydet("User is null!!!");
                });
            }
            catch (Exception ex)
            {
                Task.Run(async () => await BisiparişWebYardımcı.HataKaydet(ex));
                throw ex;
            }
        }

        public static async Task<Kullanıcı> Giriş(string girişİsim, string şifre)
        {
            try
            {
                //await GünlükKaydetme(OlaySeviye.Ayıklama, "Into...");

                using (var istemci = new System.Net.Http.HttpClient())
                {
                    var jsonStr = await istemci.GetStringAsync(KullanıcılarUrl + $"/Giriş/{girişİsim}");

                    if (!string.IsNullOrWhiteSpace(jsonStr))
                    {
                        var klnc = Newtonsoft.Json.JsonConvert.DeserializeObject<Kullanıcı>(jsonStr);
                        var pwdHasher = new PasswordHasher<Kullanıcı>();
                        var sonuç = pwdHasher.VerifyHashedPassword(klnc, klnc.KarmaŞifre, şifre);

                        if (sonuç == PasswordVerificationResult.Success)
                            return klnc;
                        else
                            return null;
                    }
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                await BisiparişWebYardımcı.HataKaydet(ex);
                throw ex;
            }
        }

        public static async Task KullanıcıGirişti(Kullanıcı kullanıcı)
        {
            try
            {
                await BisiparişWebYardımcı.AyıklamaKaydet("Into...");

                //await BisiparişWebYardımcı.AyıklamaKaydet(BisiparişWebYardımcı.Session != null ? "Session OK" : "Session NULL!!");

                ŞimdikiKullanıcı = kullanıcı; ŞimdikiKullanıcıId = kullanıcı.Id; ŞimdikiKullanıcıİsim = kullanıcı.AdSoyad;
                KullanıcıGirişYaptıMı = true;

                await BisiparişWebYardımcı.AyıklamaKaydet("Calling Hazirla...");

                KullanıcıVeriHazırla();
            }
            catch (Exception ex)
            {
                await BisiparişWebYardımcı.HataKaydet(ex);
                throw ex;
            }
        }

        public static async Task<bool?> AdSoyadZatenVarMı(string adSoyad)
        {
            try
            {
                using (var istemci = new System.Net.Http.HttpClient())
                {
                    var jsonStr = await istemci.GetStringAsync(KullanıcılarUrl + $"/AdSoyadZatenVarMı/{adSoyad}");

                    return Newtonsoft.Json.JsonConvert.DeserializeObject<bool>(jsonStr);
                }
            }
            catch (Exception ex)
            {
                await BisiparişWebYardımcı.HataKaydet(ex);
                throw ex;
            }
        }

        public static async Task<bool?> GirişİsimZatenKullanıldıMı(string girişİsim)
        {
            try
            {
                await BisiparişWebYardımcı.AyıklamaKaydet("Into...");

                using (var istemci = new System.Net.Http.HttpClient())
                {
                    var jsonStr = await istemci.GetStringAsync(KullanıcılarUrl + $"/GirişİsimZatenKullanıldıMı/{girişİsim}");

                    return Newtonsoft.Json.JsonConvert.DeserializeObject<bool>(jsonStr);
                }
            }
            catch (Exception ex)
            {
                await BisiparişWebYardımcı.HataKaydet(ex);
                throw ex;
            }
        }

        //public static async Task Çıkış()
        //{
        //    try
        //    {
        //        Session.Clear();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        public static async Task<İcraSonuç> YeniKullanıcıEkle(Kullanıcı yeniKullanıcı)
        {
            try
            {
                yeniKullanıcı.SistemDurum = VarlıkSistemDurum.Aktif;
                yeniKullanıcı.OluşturuKimsiId = ŞimdikiKullanıcıId; yeniKullanıcı.Oluşturulduğunda = DateTime.Now;
                yeniKullanıcı.KaldırmaSebebi = ""; 
                yeniKullanıcı.SonGirişTarihVeZaman = new DateTime(1, 1, 1);

                await BisiparişWebYardımcı.AyıklamaKaydet("Saving user...");
                //await GünlükKaydetme(OlaySeviye.Uyarı, "JSON user: " + JsonİçerikOluşturWithStr(yeniKullanıcı).Item2);

                var pwdHasher = new Microsoft.AspNetCore.Identity.PasswordHasher<Kullanıcı>();

                yeniKullanıcı.KarmaŞifre = pwdHasher.HashPassword(yeniKullanıcı, yeniKullanıcı.AsılŞifre);
                yeniKullanıcı.AsılŞifre = "";

                using (var istemci = new System.Net.Http.HttpClient())
                {
                    //await BisiparişWebYardımcı.GünlükKaydet(OlaySeviye.Uyarı, 
                    //    Newtonsoft.Json.JsonConvert.SerializeObject(yeniKullanıcı));

                    var msj = await istemci.PostAsync(KullanıcılarUrl + "/YeniKullanıcıEkle", 
                        BisiparişWebYardımcı.JsonİçerikOluştur(yeniKullanıcı));

                    if (msj.Content != null)
                    {
                        //var rslt = Newtonsoft.Json.JsonConvert.DeserializeObject<İcraSonuç>(await msj.Content.ReadAsStringAsync());
                        //var cntTp = msj.Content.Headers.ContentType.ToString();
                        //var stCd = msj.StatusCode;
                        //var rsn = msj.ReasonPhrase;

                        //await BisiparişWebYardımcı.GünlükKaydet(OlaySeviye.Uyarı, $"Back from saving restaurant. Rslt: {cntTp} || {rslt}");
                        //await BisiparişWebYardımcı.GünlükKaydet(OlaySeviye.Uyarı, $"Response details. {stCd} || {rsn}");

                        var snç = Newtonsoft.Json.JsonConvert.DeserializeObject<İcraSonuç>(await msj.Content.ReadAsStringAsync());

                        if (snç.BaşarılıMı)
                        {
                            yeniKullanıcı.Id = snç.YeniEklediId;
                            //Kullanıcılar.Add(yeniKullanıcı);
                        }

                        await BisiparişWebYardımcı.AyıklamaKaydet($"Final rslt: {snç.BaşarılıMı} | {snç.YeniEklediId}");

                        return snç;
                    }
                    else
                    {
                        await BisiparişWebYardımcı.AyıklamaKaydet("Back from saving restaurant. Null content");

                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                await BisiparişWebYardımcı.HataKaydet(ex);
                throw ex;
            }
        }

        public static async Task<İcraSonuç> YeniRestoranKullanıcıEkle(Kullanıcı yeniKullanıcı, int restoranId)
        {
            İcraSonuç sonuç1 = null, sonuç2 = null;

            try
            {
                yeniKullanıcı.SistemDurum = VarlıkSistemDurum.Aktif;
                yeniKullanıcı.OluşturuKimsiId = ŞimdikiKullanıcıId; yeniKullanıcı.Oluşturulduğunda = DateTime.Now;

                await BisiparişWebYardımcı.AyıklamaKaydet("Saving restaurant user...");

                sonuç1 = await YeniKullanıcıEkle(yeniKullanıcı);

                if (sonuç1.BaşarılıMı)
                {
                    await BisiparişWebYardımcı.AyıklamaKaydet("Saving user restrauant id...");
                    //await BisiparişWebYardımcı.AyıklamaKaydet($"{yeniKullanıcı.Id} | {sonuç1.YeniEklediId}");

                    using (var istemci = new System.Net.Http.HttpClient())
                    {
                        var msj = await istemci.PostAsync(KullanıcılarUrl + "/KullanıcıRestoranKaydet",
                            BisiparişWebYardımcı.JsonİçerikOluştur(new KullanıcıRestoran() 
                                            { 
                                                KullanıcıId = yeniKullanıcı.Id, RestoranId = restoranId,
                                                SistemDurum = VarlıkSistemDurum.Aktif, 
                                                OluşturuKimsiId = ŞimdikiKullanıcıId, Oluşturulduğunda = DateTime.Now
                                            }));

                        //var msjCnt = msj != null ? (msj.Content != null).ToString() : "msj null";
                        //await BisiparişWebYardımcı.AyıklamaKaydet(
                        //    $"Back from posting user restrauant id -- {msj != null} | {msjCnt}");

                        if (msj != null && msj.Content != null)
                        {
                            sonuç2 = Newtonsoft.Json.JsonConvert.DeserializeObject<İcraSonuç>(await msj.Content.ReadAsStringAsync());
                            //var cntTp = msj.Content.Headers.ContentType.ToString();

                            var chk = sonuç2 != null ? sonuç2.BaşarılıMı.ToString() : "(null)";
                            await BisiparişWebYardımcı.AyıklamaKaydet(
                                $"Back from saving user_restaurant id's. Rslt: {chk}");
                        }

                        return sonuç2 != null ? sonuç1 : null;
                    }
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                await BisiparişWebYardımcı.HataKaydet(ex);
                throw ex;
            }
        }

        public static async Task<İcraSonuç> KullanıcıDegiştir(Kullanıcı kullanıcı)
        {
            try
            {
                await BisiparişWebYardımcı.AyıklamaKaydet("Modifying user...");
                //await GünlükKaydetme(OlaySeviye.Uyarı, "JSON user: " + JsonİçerikOluşturWithStr(yeniKullanıcı).Item2);

                using (var istemci = new System.Net.Http.HttpClient())
                {
                    var msj = await istemci.PostAsync(KullanıcılarUrl + "/KullanıcıDegiştir", 
                        BisiparişWebYardımcı.JsonİçerikOluştur(kullanıcı));

                    if (msj.Content != null)
                    {
                        //var rslt = Newtonsoft.Json.JsonConvert.DeserializeObject<İcraSonuç>(await msj.Content.ReadAsStringAsync());
                        //var cntTp = msj.Content.Headers.ContentType.ToString();

                        //await GünlükKaydetme(OlaySeviye.Uyarı, $"Back from saving restaurant. Rslt: {cntTp} || {rslt}");

                        return Newtonsoft.Json.JsonConvert.DeserializeObject<İcraSonuç>(await msj.Content.ReadAsStringAsync());
                    }
                    else
                    {
                        //await GünlükKaydetme(OlaySeviye.Uyarı, "Back from saving restaurant. Null content");

                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                await BisiparişWebYardımcı.HataKaydet(ex);
                throw ex;
            }
        }

        public static async Task<İcraSonuç> KullanıcıKaldır(int kullannıcıId, string sebep)
        {
            try
            {
                await BisiparişWebYardımcı.AyıklamaKaydet("Removing user...");
                //await GünlükKaydetme(OlaySeviye.Uyarı, "JSON user: " + JsonİçerikOluşturWithStr(yeniKullanıcı).Item2);

                using (var istemci = new System.Net.Http.HttpClient())
                {
                    var msj = await istemci.PostAsync(KullanıcılarUrl + "/KullanıcıKaldır",
                        BisiparişWebYardımcı.JsonİçerikOluştur(new List<string>() { kullannıcıId.ToString(), sebep }));

                    if (msj.Content != null)
                    {
                        //var rslt = Newtonsoft.Json.JsonConvert.DeserializeObject<İcraSonuç>(await msj.Content.ReadAsStringAsync());
                        //var cntTp = msj.Content.Headers.ContentType.ToString();

                        //await GünlükKaydetme(OlaySeviye.Uyarı, $"Back from saving restaurant. Rslt: {cntTp} || {rslt}");

                        return Newtonsoft.Json.JsonConvert.DeserializeObject<İcraSonuç>(await msj.Content.ReadAsStringAsync());
                    }
                    else
                    {
                        //await GünlükKaydetme(OlaySeviye.Uyarı, "Back from saving restaurant. Null content");

                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                await BisiparişWebYardımcı.HataKaydet(ex);
                throw ex;
            }
        }

        public static async Task<İcraSonuç> ŞifreDegiştir(int kullanıcıId, string şifre)
        {
            try
            {
                await BisiparişWebYardımcı.AyıklamaKaydet("Changing password...");
                //await GünlükKaydetme(OlaySeviye.Uyarı, "JSON user: " + JsonİçerikOluşturWithStr(yeniKullanıcı).Item2);

                var pwdHasher = new Microsoft.AspNetCore.Identity.PasswordHasher<Kullanıcı>();
                var karmaŞifre = pwdHasher.HashPassword(new Kullanıcı(), şifre);

                using (var istemci = new System.Net.Http.HttpClient())
                {
                    var msj = await istemci.PostAsync(KullanıcılarUrl + "/ŞifreDegiştir",
                        BisiparişWebYardımcı.JsonİçerikOluştur(new List<string>() { kullanıcıId.ToString(), karmaŞifre }));

                    if (msj.Content != null)
                    {
                        //var rslt = Newtonsoft.Json.JsonConvert.DeserializeObject<İcraSonuç>(await msj.Content.ReadAsStringAsync());
                        //var cntTp = msj.Content.Headers.ContentType.ToString();

                        //await GünlükKaydetme(OlaySeviye.Uyarı, $"Back from saving restaurant. Rslt: {cntTp} || {rslt}");

                        return Newtonsoft.Json.JsonConvert.DeserializeObject<İcraSonuç>(await msj.Content.ReadAsStringAsync());
                    }
                    else
                    {
                        //await GünlükKaydetme(OlaySeviye.Uyarı, "Back from saving restaurant. Null content");

                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                await BisiparişWebYardımcı.HataKaydet(ex);
                throw ex;
            }
        }

        public static async Task<List<SelectListItem>> ŞimdikiKullanıcıRestoranlarAl()
        {
            List<SelectListItem> restoranlarListe = null;
            List<Restoran> restoranlar = null;

            try
            {
                await BisiparişWebYardımcı.AyıklamaKaydet("Into...");

                if (ŞimdikiKullanıcıSistemYöneticiMi)
                    restoranlarListe = await RestoranlarYardımcı.RestoranlarListeAl();
                else if (ŞimdikiKullanıcıİşletmeYöneticiMi)
                    restoranlar = await RestoranlarYardımcı.ŞimdikiKullanıcıRestoranlarAl();

                if (restoranlar != null && restoranlar.Any())
                {
                    await BisiparişWebYardımcı.AyıklamaKaydet($"Got {restoranlar.Count}");

                    restoranlarListe = new List<SelectListItem>();

                    restoranlarListe.Add(new SelectListItem() { Value = "0", Text = "(Restoran seçiniz)" });

                    foreach (var rstrn in restoranlar)
                        restoranlarListe.Add(new SelectListItem() { Value = rstrn.Id.ToString(), Text = rstrn.İsim });
                }

                return restoranlarListe;
            }
            catch (Exception ex)
            {
                await BisiparişWebYardımcı.HataKaydet(ex);
                throw ex;
            }
        }

        //public static async Task<int> ŞimdikiKullanıcıRestoranIdAl()
        //{
        //    try
        //    {
        //        await Task.Run(() => { });

        //        return 1;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
        #endregion
    }
}
