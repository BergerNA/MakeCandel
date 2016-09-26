using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandelMaker
{
    internal class Queue<T> where T : class

{
    private int outputIndex;
    private int inputIndex;
    private int size;
    private int pushLength;
    private T[] List;

    public Queue(int size)
    {
        List = new T[size];
        this.size = size; 
        inputIndex = 0;
        outputIndex = 0;
        pushLength = 0;
    }

    public bool Push(T tick)
    {
        if (pushLength != size)
        {
            List[inputIndex] = tick;
            if (++inputIndex >= size)
                inputIndex = 0;
            pushLength++;
            return true;
        }
        return false;
    }

    public T Pop()
    {
        if (pushLength != 0)
        {
            T result = List[outputIndex];
            if (++outputIndex >= size)
                outputIndex = 0;
            pushLength--;
            return result;
        }
        return null;
    }

    public bool IsEmpty()
    {
        if (pushLength == size)
            return true;
        return false;
    }

    public int Length()
    {
        return pushLength;
    }
}
}
