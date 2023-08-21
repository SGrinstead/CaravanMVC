namespace CaravanMVC.Models
{
	public class Wagon
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumWheels { get; set; }
        public bool Covered { get; set; }
        public List<Passenger> Passengers { get; set; } = new List<Passenger>();

        public Wagon()
        {
            
        }

        public Wagon(string name, int numWheels, bool covered)
        {
            Name = name;
            NumWheels = numWheels;
            Covered = covered;
        }
    }
}
