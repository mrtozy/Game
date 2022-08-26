using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class SaleManager : ISaleService
    {
     
          

        public void Satis(Oyuncu oyuncu, BilgisayarOyunu bilgisayarOyunu, Kampanya kampanya)
        {

                int topla = (int)(bilgisayarOyunu.Fiyat - ((kampanya.İndirim * bilgisayarOyunu.Fiyat) / 100));
                Console.WriteLine("Satın Alınan Oyun: " + bilgisayarOyunu.BilgisayarOyunAd);
            Console.WriteLine("Satın Alan Oyuncu: " + oyuncu.Ad + " " + oyuncu.SoyAd);
            Console.WriteLine("Satın Alınan Oyunun Fiyatı: " + bilgisayarOyunu.Fiyat);
            Console.WriteLine("İndirim Miktarı: %" + kampanya.İndirim);
            Console.WriteLine("İndirimli Fiyat: " + topla);
            Console.WriteLine("Satış İşlemi Başarıyla Gerçekleştirildi.");
        }
       
        }
    }

