using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardList
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random(0);
			Console.Write("Введите размер списка ");
			int n = Convert.ToInt32(Console.ReadLine());
			ForwardList List = new ForwardList();
			for (int i = 0; i < n; i++)
			{
				List.push_front(rand.Next(100));
			}
			List.Print();

			Console.Write("Введите индекс добавляемого элемента: ");
			int index = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите значение добавляемого элемента: ");
			int value = Convert.ToInt32(Console.ReadLine());
			List.insert(value, index);
			List.Print();
			Console.Write("Введите индекс удоляемого элемента: ");
			index = Convert.ToInt32(Console.ReadLine());
			List.erase(index);
			List.Print();

			
		}
	}
}
