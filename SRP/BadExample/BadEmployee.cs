using SRP.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.BadExample
{
    internal class BadEmployee
    {

        public void CreateEmployee(Employee calisan)
        {
            try
            {
                #region Calışanın Kaydedilmesi


                string yazilacakSatir = calisan.Id + ";" +
                                        calisan.Adi + ";" +
                                        calisan.Soyadi + ";" +
                                        calisan.IseGiris;

                File.WriteAllText("calisanlar.txt", yazilacakSatir);
                #endregion

                #region Atılan Kaydın Loglanması
                string logstr = "Kayıt Tarihi" + DateTime.Now + ";" + calisan.Id;
                File.WriteAllText("Log.txt", logstr);
                #endregion
            }
            catch (Exception ex)
            {

                string hata = DateTime.Now + ";" + ex.Message;
                File.WriteAllText("Hata.txt", hata);
            }

        }
    }
}
