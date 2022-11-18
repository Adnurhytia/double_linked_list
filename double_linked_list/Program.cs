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
            Console.ReadLine();
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
        }
        /*On the execution of the above for loop, prev and 
         * Current will point to those nodes
         * between which the new node is to be inserted*/
    }
}