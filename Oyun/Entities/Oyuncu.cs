using Oyun.Abstract;
using System;

namespace Game.Entities
{
    public class Oyuncu: IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public DateTime DogumGun { get; set; }
        public string KimlikId { get; set; }

    }
}
