namespace Interface.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vechile Vechile { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vechile vechile)
        {
            Start = start;
            Finish = finish;
            Vechile = vechile;
            Invoice = null;
        }
    }
}
