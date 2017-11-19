using System.Collections.Generic;

namespace SeaBattle.EApp.Common.Dto
{
    public class InitInfo
    {
        public int SeaHeight { get; set; }
        public int SeaWidth { get; set; }
        public IDictionary<int, int> ShipCounts { get; set; }
    }
}