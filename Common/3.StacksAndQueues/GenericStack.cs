
using System.Collections.Generic;

namespace Common
{
    public class GenericStack<T> : IPushPop<T>
    {
        //TODO #1: Declare a List inside this object class to store the objects. Choose the most appropriate object class
        private List<T> stackList = new List<T>();
        public string AsString()
        {
            //TODO #2: Return the list as a string. Use the method already implemented in your list
            return string.Join(", ", stackList);
        }

        public int Count()
        {
            //TODO #3: Return the number of objects
            return stackList.Count;
        }

        public void Clear()
        {
            //TODO #4: Remove all objects stored
            stackList.Clear();
        }

        public void Push(T value)
        {
            //TODO #5: Add a new object to the list (at the end of it)
            stackList.Add(value);
        }

        public T Pop()
        {
            //TODO #6: Remove the first object of the list and return it
            T item = stackList[stackList.Count - 1];  // Obtener el último objeto de la pila
            stackList.RemoveAt(stackList.Count - 1);  // Eliminar el último objeto de la pila
            return item;                              // Devolver el objeto eliminado
        }
    }
}