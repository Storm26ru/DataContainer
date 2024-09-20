using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ForwardList
{
	class ForwardList : IEnumerable, IEnumerator
	{
		Element Head;
		public uint Size { get; private set; }
		int index = -1;
		public object Current { get => Data(index); }
		
		public ForwardList()
		{
			Head = null;
			Size = 0;
			Console.WriteLine($"LConstructor:\t{GetHashCode()}");
		}
		~ForwardList()
		{
			Console.WriteLine($"LDestructor:\t{GetHashCode()}");
		}
		public IEnumerator GetEnumerator()
        {
			return this;
        }
		public bool MoveNext()
        {
			if(index == Size-1)
			{
				Reset();
				return false;
			}
			index++;
			return true;
        }
		public void Reset()
        {
			index = -1;
        }
		int Data(int Index)
		{
			Element Temp = Head;
			if (Index == 0) return Temp.Data; 
			else
			{
				for (int i = 0; i < Index; i++) Temp = Temp.pNext;
				return Temp.Data;
			}
		}
		
		public void push_front(int Data)
		{
			Head = new Element(Data) { pNext = Head };
			Size++;
		}
		public void push_back(int Data)
        {
			if (Head == null) push_front(Data);
			else
			{
				Element Temp = Head;
				while (Temp.pNext != null) Temp = Temp.pNext;
			    Temp.pNext = new Element(Data);
				Size++;
			}
        }
		public void insert(int Data,int Index)
		{
			if (Index > Size) return;
			if (Index == 0) push_front(Data);
			else 
			{
				Element Temp = Head;
				for (int i = 0; i < Index - 1; i++) Temp = Temp.pNext;
				Temp.pNext = new Element(Data) { pNext = Temp.pNext};
				Size++;
			}
		}
		public void Print()
		{
			Element Temp = Head; // Temp это итератор.
			while (Temp != null)
			{
				Console.Write($"{Temp.Data}\t");
				Temp = Temp.pNext; // Переход на следующий элемент.
			}
			Console.WriteLine();
		}
		public void pop_front()
		{
			Element Temp = Head;
			Head = Temp.pNext;
			Size--;
		}
		public void pop_back()
		{
			if (Head == null) return;
			if (Head.pNext == null) pop_front();
			else
			{
			    Element Temp = Head;
			    while (Temp.pNext.pNext != null) Temp = Temp.pNext;
			    Temp.pNext = null;
			    Size--;

			}
		}
		public void erase(int Index)
        {
			if (Head == null) return;
			if (Index==0) pop_front();
			else
            {
				Element Temp = Head;
				for (int i = 0; i < Index - 1; i++) Temp = Temp.pNext;
				if (Temp.pNext == null) pop_back();
				else Temp.pNext = Temp.pNext.pNext;
				Size--;
            }
        }

	}
}
