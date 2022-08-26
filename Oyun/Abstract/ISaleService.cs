using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface ISaleService
    {
        void Satis(Oyuncu oyuncu, BilgisayarOyunu bilgisayarOyunu, Kampanya kampanya);
    }
}
