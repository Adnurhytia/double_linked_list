using System;

namespace double_linked_list
{
    class Node
    {
        /*Node class representn the node of doubly linked list
         * It consist of the information part and links to
         * Its succeding and preceeding
         * In terms of next and previous */
        public int noMhs;
        public string name;
        //point to the succeding node
        public Node next;
        //point to the preceeding node
        public Node prev;
    }
    class DoubleLinkedList
    {
        Node START;

        //Constructor
        public void addNote()
        {
            int nim;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the name of student: ");
            nm= Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;

            //Check if the list empty
            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDuplicate number not allowed");
                    return;
                }
                newNode.next = START;
                if (START!=null)
                    START.prev = newNode;
                newNode.next = null;
                START = newNode;
                return;
            }
            /*If the node is to be inserted at between two node*/
            Node previous, current;
            for (current = previous = START;
                current != null && nim >= current.noMhs;
            previous = current, current = current.next)
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return ;
                }
            }
            /*On the execution of the above for loop, prev and 
             * Current will point to those nodes
            * between which the new node is to be inserted*/

            newNode.next = current;
            newNode.prev = previous;
            
        }
        public bool Search(int rollNo, ref Node previous, ref Node current)
        {
            previous = current = START;
            while (current != null &&
                rollNo != current.noMhs)
            {
                previous = current;
                current = current.next;
            }
            return (current != null);
        }
        public bool dellNode(int rollNo)
        {
            Node previous, current;
            previous = current = null;
            if (Search(rollNo, ref previous, ref current) == false)
                return false;
            //The beginning of Data
            if (current.next == null)
            {
                previous.next = null;
                return true;
            }
            //Node between two nodes in the list
            if (current == START)
            {
                START = START.next;
                if (START != null)
                    START.prev = null;
                return true;
            }
            
            //*If the to be deleted is in between the list then the following lines of is execute. */
            previous.next = current.next;
            current.next.prev = previous;
            return true;
        }

    }
}