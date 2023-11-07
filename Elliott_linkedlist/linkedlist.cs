using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elliott_linkedlist
{
    internal class linkedlist
    {

        private node _head;
        public void add(string payload)
        {
            node newnode = new node(payload);
            if (_head == null)
            {
                _head = newnode;
                return;
            }
            //original example conditional for int based sortings are left for reference
            //if (_head.data > newnode.data)
            if (String.Compare(_head.data, newnode.data, true)==1)
            {
                node temp = _head;
                _head = newnode;
                _head.next = temp;
                return;
            }

            node current = _head;

            while (current.next != null)
            {
                //if (current.next.data > newnode.data)
                if (String.Compare(current.next.data, newnode.data, true)==1)
                {
                    //node temp = current;
                    //current = newnode;
                    //current.next = temp;
                    newnode.next = current.next;
                    current.next = newnode;
                    return;
                }


                current = current.next;
            }
            current.next = newnode;
        }

        public bool remove(string payload)
        {
            if (_head==null)
            {
                return false;
            }
            if (_head.data==payload)
            {
                _head = _head.next;
                return true;
            }
            node current = _head;
            while (current.next != null)
            {

                if(current.next.data==payload)
                {
                    node temp= current.next.next;
                    current.next = temp; 
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public node contains(string payload)
        {
            if (_head== null)
            {
                return null;
            }
            if (_head.data == payload)
            {
                return _head;
            }
            node current= _head;
            while (current.next != null)
            {
                current = current.next;
                if(current.data==payload)
                {
                    return current;
                }
            }
            return null;
        }

        public void printallnodes()
        {
            node current = _head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
