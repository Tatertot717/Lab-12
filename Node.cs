using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    internal class Node
    {
        BlueRayDisk current;
        Node? next = null;
        public Node(BlueRayDisk current) 
        {
            this.current = current;
        }
        public void setNext(Node next) 
        {
        this.next = next;
        }
    }
}
