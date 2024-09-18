using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardList
{
	class ForwardList
	{
		Element Head;
		public ForwardList()
		{
			Head = null;
			Console.WriteLine($"LConstructor:\t{GetHashCode()}");
		}
		~ForwardList()
		{
			Console.WriteLine($"LDestructor:\t{GetHashCode()}");
		}
		public void push_front(int Data)
		{
			Head = new Element(Data) { pNext = Head };
		}
		public void push_back(int Data)
        {
			if (Head == null) push_front(Data);
			else
			{
				Element Temp = Head;
				while (Temp.pNext != null) Temp = Temp.pNext;
			    Temp.pNext = new Element(Data);
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
	}
}
