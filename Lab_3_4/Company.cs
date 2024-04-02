using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_4
{
    internal class Company
    {
        [Key]
        public int Id { get; set; }
        public required bool isValid { get; set; }
        public required string name { get; set; }
        public required string address { get; set; }
        public required string vatNumber { get; set; }

        public override string ToString()
        {
            return $"Nazwa: {name}\nAdres: {address}\nNumer VAT: {vatNumber}";
        }
    }
}
