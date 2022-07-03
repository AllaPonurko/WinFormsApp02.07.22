using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WinFormsApp02._07._22.Entities
{
    public class Country
    {[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Population { get; set; }
        [Required]
        public int InternationalCode { get; set; }
        public Country()
        {
            Name = Name;
            InternationalCode = InternationalCode;
            Population = Population;
            
        }
        public List<City> cities { get; set; } = new List<City>();
        public override string ToString()
        {
            return Name;
        }

    }
}
