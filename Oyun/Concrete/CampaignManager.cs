using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class CampaignManager : ICampaignService
    {
        List<Kampanya> Kampanyas = new List<Kampanya>();
        public void Add(Kampanya campaign)
        {
            Console.WriteLine("Kampanya Tanımlandı. " + campaign.KampanyaAd);
            Kampanyas.Add(campaign);
        }

        public void Delete(Kampanya campaign)
        {
            Console.WriteLine("Kampanya Listeden Kaldırıldı. " + campaign.KampanyaAd);
            Kampanyas.Remove(campaign);
            ListKampanya();
        }

       

        public void ListKampanya()
        {
            Console.WriteLine("Mevcut Olan Kampanyalar.");
           
            foreach (Kampanya k in Kampanyas)
            {
                Console.WriteLine(k.KampanyaAd);
            }
        }

        public void Update(Kampanya campaign)
        {
            Console.WriteLine("Kampanya Güncellendi. " + campaign.KampanyaAd);
        }
    }
}
