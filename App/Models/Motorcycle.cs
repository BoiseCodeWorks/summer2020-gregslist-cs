namespace gregslist_cs.Models
{
    public class Motorcycle : Automobile
    {
        public Motorcycle(bool kickstart, BrakeSystem brakes, string title, string description, double price, int mileage, string make, string model) : base(title, description, price, mileage, make, model)
        {
            KickStart = kickstart;
            Brakes = brakes;

            Title += " (MotorCycle)";

        }

        public bool KickStart { get; set; }
        public BrakeSystem Brakes { get; set; }

        public override string Start()
        {
            return "Putt, Putt";
        }

    }



    public enum BrakeSystem
    {
        mechanical,
        flinstone,
        airbrake,
        chute,
        stick,
        antilock
    }



}


