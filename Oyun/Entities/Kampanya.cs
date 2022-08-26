using Oyun.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Entities
{
    public class Kampanya : IEntity
    {
        public int Id { get; set; }
        public string KampanyaAd { get; set; }
        public int İndirim { get; set; }

    }
}
