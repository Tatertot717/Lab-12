namespace Lab_12
{
    internal class BlueRayCollection
    {
        private Node? head = null;
        
        public void add(string title, string director, int year, double cost) 
        {
            if (head == null )
            {
                head = new Node(new BlueRayDisk(title, director, year, cost));
            }
            if (head != null ) 
            {
                head.setNext
            }
        }

    }
}
