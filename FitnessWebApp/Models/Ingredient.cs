using FitnessWebApp.Data;

namespace FitnessWebApp.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public MeasurementUnit Unit { get; set; }   
        public int Calories { get; set; } //per 100 [Unit]
        public decimal Protein { get; set; }//per 100 [Unit]
    }
}
