using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        List<Oyuncu> gamers = new List<Oyuncu>();
        public void Add(Oyuncu oyuncu)
        {
            BoyleBiriVarMi(oyuncu);
            Console.WriteLine("Veritabanına Kayıt Edildi: " + oyuncu.Ad);
            gamers.Add(oyuncu);


        }

        public void Delete(Oyuncu oyuncu)
        {

            BoyleBiriVarMi(oyuncu);
            Console.WriteLine(oyuncu.Ad + " Kişisi Silindi.");

            ListOyuncu();
        }

        public void Update(Oyuncu oyuncu)
        {
            BoyleBiriVarMi( oyuncu);
            Console.WriteLine(oyuncu.Ad + " Oyuncu Güncellendi.");
            ListOyuncu();
        }

        public void ListOyuncu()
        {
          
            Console.WriteLine("Veritabanına Kayıtlı Oyuncular");
            foreach (Oyuncu gamer in gamers)
            {
                Console.WriteLine(gamer.Ad + " " + gamer.SoyAd);
            }
        }

        public void BoyleBiriVarMi(Oyuncu oyuncu)
        {
            if (!_gamerCheckService.CheckIfRealPerson(oyuncu))
            {
                throw new Exception("Böyle biri yok");
        }            
            
        }
    }
}
