using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormulaOneFanPage.Models {
    public class Driver {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public int DriverNumber { get; set; }
        public int TeamId { get; set; }
        public string Description { get; set; }
        public int Championships { get; set; }

        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }
    }
}
