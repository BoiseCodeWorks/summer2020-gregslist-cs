namespace gregslist_cs.Models
{
    public abstract class Automobile // Base Class
    {
        public Automobile(string title, string description, double price, int mileage, string make, string model)
        {
            Title = title;
            Description = description;
            Price = price;
            Mileage = mileage;
            Make = make;
            Model = model;

        }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Mileage { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public virtual string Start()
        {
            return "vroom vroom";
        }
    }
}