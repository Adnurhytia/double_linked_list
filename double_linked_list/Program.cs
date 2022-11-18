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
}