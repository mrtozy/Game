
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface IGamerService
    {
        void Add(Oyuncu oyuncu);
        void Delete(Oyuncu oyuncu);
        void Update(Oyuncu oyuncu);
        void BoyleBiriVarMi(Oyuncu oyuncu);
        void ListOyuncu();
    }
}
