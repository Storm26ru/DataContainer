﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardList
{
	class ForwardList
	{
		Element Head;
		public uint Size { get; private set; }

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
			Console.WriteLine($"{Size}");
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

	}
}
