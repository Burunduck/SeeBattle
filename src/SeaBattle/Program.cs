using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeaBattle
{
	class Program
	{
		static void Main(string[] args)
		{
			//ConsoleGame.Start();
			ConsoleBoardRendererTests.Start();
			Console.ReadKey();
		}




	}
}


//        static void Main2(string[] args)
//        {
//            MyPole Pole = new MyPole();
//            Console.WriteLine("Игрок 1");
//            MyPole.Write(Pole.pole);
//            Console.WriteLine("Разместите на поле корабли : 1 однопалубных");
//            GAME.SetSheep(Pole.pole);
//            MyPole Pole2 = new MyPole();
//            Console.WriteLine("Игрок 2");
//            MyPole.Write(Pole2.pole);
//            Console.WriteLine("Разместите на поле корабли : 1 однопалубных");
//            GAME.SetSheep(Pole2.pole);
//            MyPole Close1 = new MyPole();
//            MyPole Close2 = new MyPole();
//            bool Move = true;
//            bool end = true;
//            do
//            {
//                if (Move)
//                {
//                    Console.WriteLine("Ходит игрок 1");
//                    MyPole.Write(Pole.pole);
//                    Console.WriteLine("Поле врага");
//                    MyPole.Write(Close2.pole);
//                    Move = GAME.Shot(Pole2.pole, Close2.pole);
//                    end = GAME.IsEnd(Pole2.pole);
//                    if (!end)
//                    {
//                        Console.WriteLine(" Игрок 1 победил");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Ходит игрок 2");
//                    MyPole.Write(Pole2.pole);
//                    Console.WriteLine("Поле врага");
//                    MyPole.Write(Close1.pole);
//                    Move = !GAME.Shot(Pole.pole, Close1.pole);
//                    end = GAME.IsEnd(Pole.pole);
//                    if (!end)
//                    {
//                        Console.WriteLine(" Игрок 2 победил");
//                    }
//                }

//            }
//            while (end);

//            Console.ReadKey();
//        }
//    }
//}

//public class MyPole
//{
//    public int[,] pole = new int[10, 10];

//    public MyPole()
//    {
//        Fill(pole);

//    }


//    public void Fill(int[,] a)
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                a[i, j] = 0;
//            }
//        }


//    }

//    public static void Write(int[,] a)
//    {

//        Console.WriteLine("    1 2 3 4 5 6 7 8 9 10 ");
//        Console.WriteLine();
//        for (int i = 0; i < 10; i++)
//        {
//            if (i + 1 != 10)
//            {
//                Console.Write(i + 1 + "   ");
//            }
//            else
//            {
//                Console.Write(i + 1 + "  ");
//            }
//            for (int j = 0; j < 10; j++)
//            {
//                Console.Write(a[i, j] + " ");

//            }
//            Console.WriteLine();
//        }


//    }
//}
//public static class GAME
//{
//    static bool Move;


//    public static void SetSheep(int[,] A)
//    {
//        int x, y;
//        int count = 1;
//        do
//        {
//            Console.WriteLine("Установи x");
//            x = GAME.ReadPos();
//            Console.WriteLine("Установи y");
//            y = GAME.ReadPos();
//            //Проверка на соседнии клетки
//            A[x - 1, y - 1] = 2;
//            count++;
//            Console.WriteLine("Текущее состояние:");
//            MyPole.Write(A);
//        } while (count <= 1);

//    }

//    public static bool Shot(int[,] osn, int[,] pokaz)
//    {
//        bool flag = false;
//        Console.WriteLine("Установи x");
//        int x = GAME.ReadPos();
//        Console.WriteLine("Установи y");
//        int y = GAME.ReadPos();
//        osn[x - 1, y - 1]--;
//        pokaz[x - 1, y - 1]--;
//        if (osn[x - 1, y - 1] == 1)
//        {
//            flag = true;
//        }
//        return flag;
//    }


//    public static int ReadPos(int min = 0, int max = 10)
//    {
//        while (true)
//        {
//            string str = Console.ReadLine();
//            if (!int.TryParse(str, out int num))
//            {
//                Console.WriteLine("Введите цифру");
//                continue;
//            }

//            if (num < min)
//            {
//                Console.WriteLine("Минимальное значение " + min);
//                continue;
//            }

//            if (num > max)
//            {
//                Console.WriteLine("Максимальное значение " + max);
//                continue;
//            }

//            return num;
//        }
//    }

//    public static bool IsEnd(int[,] a)
//    {
//        bool k = false;
//        for (int i = 0; i < 10; i++)
//        {
//            if (k)
//            {
//                break;
//            }
//            for (int j = 0; j < 10; j++)
//            {
//                if (a[i, j] == 2)
//                {
//                    k = true;
//                    break;
//                }
//            }
//        }
//        return k;
//    }
//}