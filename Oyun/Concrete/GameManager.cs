using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class GameManager : IGameService
    {
        List<BilgisayarOyunu> games = new List<BilgisayarOyunu>();
        public void Add(BilgisayarOyunu game)
        {
            Console.WriteLine("Oyun Listeye Eklendi.");
            games.Add(game);
        }

        public void Delete(BilgisayarOyunu game)
        {
            games.Remove(game);
            Console.WriteLine("Oyun Listeden Kaldırıldı: "+ game.BilgisayarOyunAd);
            ListBilgisayarOyunu();
        }

        public void ListBilgisayarOyunu()
        {
            Console.WriteLine("Mevcut Oyunlar Listesi");
            foreach (BilgisayarOyunu game in games)
            {
                Console.WriteLine(game.BilgisayarOyunAd);
            }
        }

       

        public void Update(BilgisayarOyunu game)
        {
            Console.WriteLine(game.BilgisayarOyunAd + " Oyun Güncellendi.");
            ListBilgisayarOyunu();
        }
    }
}
