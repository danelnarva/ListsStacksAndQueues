using Common;

public class GenericListNode<T>
{
    public T Value;
    public GenericListNode<T> Next = null;

    public GenericListNode(T value)
    {
      Value = value;
    }

    public override string ToString()
    {
      return Value.ToString();
    }
}

public class GenericList<T> : IGenericList<T>
{
    GenericListNode<T> First = null;

    public string AsString()
    {
      GenericListNode<T> node = First;
      string output = "[";

      while (node != null)
      {
        output += node.ToString() + ",";
        node = node.Next;
      }
      output = output.TrimEnd(',') + "] " + Count() + " elements";
      
      return output;
    }

    public void Add(T value)
    {
        //TODO #1: add a new element to the end of the list
        GenericListNode<T> nuevoNode = new GenericListNode<T>(value);
        if(First == null) 
        {
            First = nuevoNode;
        }
        else
        {
            GenericListNode<T> ultimoNode = FindNode(Count() - 1);
            ultimoNode.Next = nuevoNode;
        }
    }

    public GenericListNode<T> FindNode(int index)
    {
        //TODO #2: Return the element in position 'index'
        if(index < 0)
        {
            return null;
        }
        GenericListNode<T> node = First;
        for(int i = 0;i<index && node != null;i++)
        {
            node = node.Next;
        }

        return node;
    }

    public T Get(int index)
    {
        //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). Return the default value for object class T if the position is out of bounds
        GenericListNode<T> node = FindNode(index);
        if(node != null)
        {
            return node.Value;
        }
        else
        {
            return default(T);
        }
    }
    public int Count()
    {
        //TODO #4: return the number of elements on the list
        int contador = 0;
        GenericListNode<T> node = First;
        while(node != null)
        {
            contador++;
            node = node.Next;
        }

        return contador;
    }


    public void Remove(int index)
    {
        //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
        if(index < 0  || index >= Count())
        {
            return;
        }
        if(index ==0)
        {
            First = First.Next;
        }
        else
        {
            GenericListNode<T> anteriorNodo = FindNode(index -1);
            anteriorNodo.Next= anteriorNodo.Next.Next;
        }
    }

    public void Clear()
    {
        //TODO #6: remove all the elements on the list
        First = null;
    }
}