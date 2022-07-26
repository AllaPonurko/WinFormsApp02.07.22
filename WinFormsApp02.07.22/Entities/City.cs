using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WinFormsApp02._07._22.Entities
{
    public class City
    {[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Population { get; set; }
        [Required]
        public int Postcode { get; set; }
        public override string ToString()
        {
            return Name;
        }
        public Guid CountryId { get; set; }
        public bool Capital { get; set; }
    }
}
