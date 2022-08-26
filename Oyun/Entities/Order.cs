using Oyun.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Entities
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public string Gamer { get; set; }
        public string Game { get; set; }
        public int Discount { get; set; }

    }
}
