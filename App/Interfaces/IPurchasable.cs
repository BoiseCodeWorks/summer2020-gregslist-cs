namespace gregslist_cs.Interfaces
{
    public interface IPurchasable
    {
        double Price { get; set; }
        // double DealerDockFee { get; set; }
        // double PublishingFee { get; set; }

        double CalculateTax(double rate);
    }
}