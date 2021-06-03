using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    public class RoverList<T> : RoverListBase<T>
    {
        private int count;
        public RoverList()
        {
            count = 0;
        }
        public int wordNum()
        {
            current = head;
            int wordCounter = 0;

            while (current.Next != null)
            {
                wordCounter = wordCounter + 1;
                current = current.Next;
            }

            wordCounter = wordCounter + 1;
            return count;
        }

        public override int Count
        {
            get
            {
                return count;
            }
        }
        public override void Add(T data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
            }
            else
            {
                current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = n;
            }
            count++;
        }

        public override void Add(int Position, T data)
        {

            Node temp = new Node(data);
            current = head;
            int pos = 0;
            if (Position == 0)
            {
                head = temp;
                temp.Next = current;
                return;
            }
            while (pos != Position && current != null)
            {
                if (pos == Position - 1)
                {
                    temp.Next = current.Next;
                    current.Next = temp;
                }
                current = current.Next;
                pos++;
            }


        }
        public override void Clear()
        {
            head = null;

        }

        public override T ElementAt(int Position)
        {

            if (Position < 0 || Position >= this.wordNum())
            {
                return default(T);
            }
            current = head;
            if (Position == 0)
            {
                return current.Data;
            }
            for (int i = 0; i < Position; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public override void ListNodes()
        {
            current = head;
            while (current != null)
            {
                Console.WriteLine("-" + current.Data);
                current = current.Next;
            }
        }

        public override bool RemoveAt(int Position)
        {
            current = head;
            if (Position == 0)
            {
                head = current.Next;
                return true;
            }
            else
            {
                for (int i = 0; i < Position - 1; i++)
                    current = current.Next;
                current.Next = current.Next.Next;
            }
            return true;
        }
    }
}