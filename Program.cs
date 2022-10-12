using System.Data.SqlTypes;

namespace ToDo
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Для запуска программы нажмите Пробел");
            Arrow(0);
        }

        static void Arrow(int DAY)
        {
            int position = 1;
            var key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        position--;
                        break;
                    case ConsoleKey.DownArrow:
                        position++;
                        break;
                    case ConsoleKey.LeftArrow:
                        DAY --;
                        break;
                    case ConsoleKey.RightArrow:
                        DAY ++;
                        break;
                }
                Console.Clear();

                switch(DAY)
                {
                    case 0:
                        Day0();
                        break;
                    case 1:
                        Day1();
                        break;
                    case -1:
                        Day_1();
                        break;
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();
            }
            Switch(position, DAY);
        }
        static void Switch(int position, int DAY)
        {
            switch (DAY)
            {
                case 0:
                    switch (position)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("я заебалась");
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Надо постараться выехать до 17:00, иначе поздно приеду");
                            break;
                    }
                    break;
                case 1:
                    switch (position)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Ахахахаха конечно");
                            break;
                    }
                    break;
                case -1:
                    switch (position)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Или нет");
                            break;
                    }
                    break;
            }

            Console.ReadKey();
            Arrow(0);

        }
        static void Day0()
        {
            Console.Clear();
            DateTime date = new(2022, 10, 15);
            Console.WriteLine(".................." + date.ToLongDateString() + "..................");

            List<string> notes = new() {"Сходить на пары", "Поехать к родителям" };
            foreach (var note in notes)
            {
                Console.WriteLine("  " + note);
            }

            //Add(notes);

        }
        static void Day1()
        {
            Console.Clear();
            DateTime date = new(2022, 10, 16);
            Console.WriteLine(".................." + date.ToLongDateString() + "..................");

            List<string> notes = new() { "Выспаться" };
            foreach (var note in notes)
            {
                Console.WriteLine("  " + note);
            }
        }
        static void Day_1()
        {
            Console.Clear();
            DateTime date = new(2022, 10, 14);
            Console.WriteLine(".................." + date.ToLongDateString() + "..................");

            List<string> notes = new() {"Что-нибудь придумаю"};
            foreach (var note in notes)
            {
                Console.WriteLine("  " + note);
            }
        }

        private static void Add(List<string> notes)
        {
            var key = Console.ReadKey();
            Console.Clear();
            switch (key.Key)
            {
                case ConsoleKey.OemPlus:
                    var newNote = Console.ReadLine();
                    if (newNote != null) notes.Add(newNote);
                    break;
            }
        }
    }
}
