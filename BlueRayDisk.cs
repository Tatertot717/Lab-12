namespace Lab_12
{
    internal class BlueRayDisk
    {
        public string title;
        public string director;
        public int year;
        public double cost;

        public BlueRayDisk(string title, string director, int year, double cost)
        {
            this.title = title;
            this.director = director;
            this.year = year;
            this.cost = cost;
        }

        public override string ToString()
        {
            return ("$"+cost+" "+year+" "+title+" "+director);
        }
        
    }
}
