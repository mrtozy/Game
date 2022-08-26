using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface ICampaignService
    {
        void Add(Kampanya kampanya);
        void Update(Kampanya kampanya);
        void Delete(Kampanya kampanya);
        void ListKampanya();
    }
}
