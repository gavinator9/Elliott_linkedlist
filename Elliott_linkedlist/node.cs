using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elliott_linkedlist
{
    internal class node
    {
        public string data { get; set; }
        public node next;

        public node(string data)
        {
            this.data = data;

        }

        public node(string payload, node Next)
        {
            data = payload;
            next = Next;
        }
    }
}


