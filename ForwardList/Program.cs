//#define BASE_CHECK
#define HOME_WORK
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardList
{
	class Program
	{
		static void Main(string[] args)
		{
#if BASE_CHECK
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
#endif


#if HOME_WORK
            ForwardList List = new ForwardList() { 3, 5, 8, 13, 21 };
            foreach (int i in List)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine(); 
#endif
        }
	}
}
