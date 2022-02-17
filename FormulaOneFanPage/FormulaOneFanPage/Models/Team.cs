using System;

namespace FormulaOneFanPage.Models {
    public class Team {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Championships { get; set; }

        public Driver[] Drivers { get; set; }
    }
}
