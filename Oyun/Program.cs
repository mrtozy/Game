using Game.Adapters;
using Game.Concrete;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Oyuncu o1;
            BilgisayarOyunu g1, g2, g3;
            Kampanya c1, c2, c3;

            GamerMethod(out o1);
            GameMethod(out g1, out g2, out g3);
            CampaignMethod(out c1, out c2, out c3);

            GameManager gameManager = new GameManager();
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            CampaignManager campaignManager = new CampaignManager();
            SaleManager salaManager = new SaleManager();

            gamerManager.BoyleBiriVarMi(o1);
            gamerManager.Add(o1);

            gamerManager.ListOyuncu();

            gamerManager.Update(o1);
            gameManager.Add(g1);
            gameManager.Add(g2);
            gameManager.Add(g3);
           
            campaignManager.Add(c1);
            campaignManager.Add(c2);
    
            salaManager.Satis(o1, g3, c3);






            Console.ReadLine();
        }



        private static void CampaignMethod(out Kampanya campaign, out Kampanya campaign2, out Kampanya campaign3)
        {
            campaign = new Kampanya()
            {
                Id = 1,
                KampanyaAd = "kış",
                İndirim = 69,
            };
            campaign2 = new Kampanya()
            {
                Id = 2,
                KampanyaAd = "ilkbahar",
                İndirim = 27,
            };
            campaign3 = new Kampanya()
            {
                Id = 3,
                KampanyaAd = "yaz",
                İndirim = 45,
            };
        }

        private static void GameMethod(out BilgisayarOyunu game, out BilgisayarOyunu game2, out BilgisayarOyunu game3)
        {
            game = new BilgisayarOyunu()
            {
                Id = 1,
                BilgisayarOyunAd = "Cod1",
                Fiyat = 125
            };
            game2 = new BilgisayarOyunu()
            {
                Id = 2,
                BilgisayarOyunAd = "Cod2",
                Fiyat = 25
            };
            game3 = new BilgisayarOyunu()
            {
                Id = 3,
                BilgisayarOyunAd = "Cod3",
                Fiyat = 25
            };
           
        }

        private static void GamerMethod(out Oyuncu o1)
        {
            o1 = new Oyuncu()
            {
                Ad = "eyyyyrt",
                SoyAd = "gggg",
                DogumGun = new DateTime(1999, 03, 07),
                Id = 1,
                KimlikId = "0000000000"
            };

        }
    }
}
