using gregslist_cs.Interfaces;

namespace gregslist_cs.Models
{
    public class Truck : Automobile, IPurchasable
    {

        public double BedLength { get; set; }
        public string DriveTrain { get; set; }


        public Truck(string title, string description, double price, int mileage, string make, string model, double bedLength, string drivetrain) : base(title, description, price, mileage, make, model)
        {
            BedLength = bedLength;
            DriveTrain = drivetrain;
        }

        public double CalculateTax(double rate)
        {
            throw new System.NotImplementedException();
        }
    }
}