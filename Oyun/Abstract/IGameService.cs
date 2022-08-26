using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface IGameService
    {
        void Add(BilgisayarOyunu bilgisayarOyunu);
        void Delete(BilgisayarOyunu bilgisayarOyunu);
        void Update(BilgisayarOyunu bilgisayarOyunu);
        void ListBilgisayarOyunu();
    }
}
