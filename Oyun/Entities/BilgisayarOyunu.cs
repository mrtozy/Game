using Oyun.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities
{
    public class BilgisayarOyunu : IEntity
    {
      
            public int Id { get; set; }
            public string BilgisayarOyunAd { get; set; }
            public double Fiyat { get; set; }

        
    }
}
