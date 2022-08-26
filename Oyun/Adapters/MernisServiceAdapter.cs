using Game.Abstract;
using Game.Entities;

using Oyun.MServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        

        public bool CheckIfRealPerson(Oyuncu oyuncu)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(oyuncu.KimlikId), oyuncu.Ad.ToUpper(), oyuncu.SoyAd.ToUpper(), oyuncu.DogumGun.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
