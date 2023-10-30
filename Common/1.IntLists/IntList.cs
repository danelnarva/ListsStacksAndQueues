using System;

namespace Common
{
    public class IntListNode
    {
        public int Value;
        public IntListNode Next = null;

        public IntListNode(int value)
        {
            Value = value;
        }
    }

    public class IntList : IList
    {
        IntListNode First = null;

        //This method returns all the elements on the list as a string
        //Use it as an example on how to access all the elements on the list
        public string AsString()
        {
            IntListNode node = First;
            string output = "[";

            while (node != null)
            {
                output += node.Value + ",";
                node = node.Next;
            }
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        
        public void Add(int value)
        {
            //TODO #1: add a new integer to the end of the list
            IntListNode newNode = new IntListNode(value);
            if(First == null) 
            {
                First = newNode;
            }
            else
            {
                IntListNode lastNode = GetNode(Count() -1);
                lastNode.Next = newNode;
            }
        }

        private IntListNode GetNode(int index)
        {
            //TODO #2: Return the element in position 'index'
            if(index < 0)
            {
                return null;
            }
            IntListNode temporal = First;
            for (int i = 0; i < index && temporal != null; i++)
            {
                temporal = temporal.Next;
            }
            return temporal;
        }

        
        public int Get(int index)
        {
            //TODO #3: return the element on the index-th position
            if(index < 0 && index >= Count()) 
            { 
                return 0;
            }
            IntListNode temporal = First;
            for(int i = 0; i < index; i++)
            {
                temporal = temporal.Next;
            }
            return temporal.Value; 
        }

        
        public int Count()
        {
            //TODO #4: return the number of elements on the list
            int count = 0;
            IntListNode temporal = First;
           while(temporal != null)
            {
                count++;
                temporal = temporal.Next;
            }
            return count;
        }
        
        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
            if(index < 0 && index >= Count())
            {
                return;
            }
            if(index == 0)
            {
                First = First.Next;
            }
            else
            {
                IntListNode previoNode = GetNode(index - 1);
                previoNode.Next = previoNode.Next.Next;
            }
        }

        
        public void Clear()
        {
            //TODO #6: remove all the elements on the list
            First = null;
        }
    }
}