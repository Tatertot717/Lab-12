namespace Lab_12
{
    internal class BlueRayCollection
    {
        private Node? head = null;

        public void add(string title, string director, int year, double cost)
        {
            if (head == null)
            {
                head = new Node(new BlueRayDisk(title, director, year, cost));
            }
            if (head != null)
            {
                Node node = head;
                while (node.next != null)
                {
                    node = node.next;
                }
                node.setNext(new Node(new BlueRayDisk(title, director, year, cost)));
            }
        }

        public void show_all()
        {
            Node? node = head;
            if (node == null)
                return;
            while (node.next != null)
            {
                node = node.next;
                Console.WriteLine(node.current.ToString());
            }
        }

    }
}
