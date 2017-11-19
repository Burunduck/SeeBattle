using System.Collections.Generic;

namespace SeaBattle.EApp.Common.Dto
{
    public class Ship
    {
        public Orientation Orientation { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Len { get; set; }
        public IList<int> Hits { get; set; }
    }
}