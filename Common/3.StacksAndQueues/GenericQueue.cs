using System.Collections.Generic;

namespace Common

{

    public class GenericQueue<T> : IPushPop<T>
    {
        //TODO #1: Declare a List inside this object class to store the objects. Choose the most appropriate object class
        private List<T> queueList = new List<T>();
        public string AsString()
        {
            //TODO #2: Return the list as a string. Use the method already implemented in your list
            return string.Join(", ", queueList);
        }

        public int Count()
        {
            //TODO #3: Return the number of objects
            return queueList.Count;
        }

        public void Clear()
        {
            //TODO #4: Remove all objects stored
            queueList.Clear();
        }

        public void Push(T value)
        {
            //TODO #5: Add a new object to the list (at the end of it)
            queueList.Add(value);
        }

        public T Pop()
        {
            //TODO #6: Remove the first object of the list and return it
            T item = queueList[0]; // Obtener el primer objeto de la cola
            queueList.RemoveAt(0); // Eliminar el primer objeto de la cola
            return item;           // Devolver el objeto eliminado
        }
    }
}