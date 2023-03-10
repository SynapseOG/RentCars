using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.ModelsDto
{
    public class CreateCarDto
    {
       
        public string Brand { get; set; }
        
        public string Model { get; set; }
       
        public decimal Price { get; set; }
       
        public int MaxSpeed { get; set; }
        
        public int Milage { get; set; }
       
        public string Transmisson { get; set; }
        
        public int Year { get; set; }
        
        public int NumberOfSeats { get; set; }
      
        public string CarPlate { get; set; }
        
        public string Vin { get; set; }

       
        public IFormFile Image { get; set; } = null!;
    }
}
