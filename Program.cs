using static System.Console;
using static System.ConsoleKey;
using static System.ConsoleColor;

namespace ToDo
{
    internal class Program
    {
        static void Main()
        {
            BackgroundColor = DarkGreen;
            ForegroundColor = DarkRed;
            WriteLine( "\r\n .----------------.  .----------------.  .----------------.  .-----------------. .-----------------. .----------------.  .----------------. \r\n| .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |\r\n| |   ______     | || |   _____      | || |      __      | || | ____  _____  | || | ____  _____  | || |  _________   | || |  _______     | |\r\n| |  |_   __ \\   | || |  |_   _|     | || |     /  \\     | || ||_   \\|_   _| | || ||_   \\|_   _| | || | |_   ___  |  | || | |_   __ \\    | |\r\n| |    | |__) |  | || |    | |       | || |    / /\\ \\    | || |  |   \\ | |   | || |  |   \\ | |   | || |   | |_  \\_|  | || |   | |__) |   | |\r\n| |    |  ___/   | || |    | |   _   | || |   / ____ \\   | || |  | |\\ \\| |   | || |  | |\\ \\| |   | || |   |  _|  _   | || |   |  __ /    | |\r\n| |   _| |_      | || |   _| |__/ |  | || | _/ /    \\ \\_ | || | _| |_\\   |_  | || | _| |_\\   |_  | || |  _| |___/ |  | || |  _| |  \\ \\_  | |\r\n| |  |_____|     | || |  |________|  | || ||____|  |____|| || ||_____|\\____| | || ||_____|\\____| | || | |_________|  | || | |____| |___| | |\r\n| |              | || |              | || |              | || |              | || |              | || |              | || |              | |\r\n| '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |\r\n '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------' \r\n");
            BackgroundColor = Black;
            WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "ДЛЯ ЗАПУСКА ПРОГРАММЫ НАЖМИТЕ ПРОБЕЛ");
            Arrow(0);
        }

        static void Arrow(int DAY)
        {
            int position = 1;
            var key = ReadKey();
            while (key.Key != Enter)
            {
                switch (key.Key)
                {
                    case UpArrow:
                        position--;
                        break;
                    case DownArrow:
                        position++;
                        break;
                    case LeftArrow:
                        DAY --;
                        break;
                    case RightArrow:
                        DAY ++;
                        break;
                }
                Clear();

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

                SetCursorPosition(0, position); 
                WriteLine("->");

                key = ReadKey();
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
                            Clear();
                            WriteLine(".................." + "Сходить на пары" + "..................");
                            WriteLine("я устала");
                            DateTime date = new(2022, 10, 15);
                            WriteLine("----------" + "\n" + date.ToLongDateString());
                            break;
                        case 2:
                            Clear();
                            WriteLine(".................." + "Поехать к родителям" + "..................");
                            WriteLine("Надо постараться выехать до 17:00, иначе поздно приеду");
                            DateTime date1 = new(2022, 10, 15);
                            WriteLine("----------" + "\n" + date1.ToLongDateString());
                            break;
                    }
                    break;
                case 1:
                    switch (position)
                    {
                        case 1:
                            Clear();
                            WriteLine(".................." + "Выспаться" + "..................");
                            WriteLine("Ахахахаха конечно");
                            DateTime date = new(2022, 10, 16);
                            WriteLine("----------" + "\n" + date.ToLongDateString());
                            break;
                        case 2:
                            Clear();
                            WriteLine(".................." + "Переделать этот код" + "..................");
                            WriteLine("Так как этот мне очень ненравится");
                            DateTime date1 = new(2022, 10, 16);
                            WriteLine("----------" + "\n" + date1.ToLongDateString());
                            break;
                    }
                    break;
                case -1:
                    switch (position)
                    {
                        case 1:
                            Clear();
                            WriteLine(".................." + "Что-нибудь придумаю" + "..................");
                            WriteLine("Или нет");
                            DateTime date = new(2022, 10, 14);
                            WriteLine("----------" + "\n" + date.ToLongDateString());
                            break;
                    }
                    break;
            }
            
            ReadKey();
            Arrow(0);

        }
        static void Day0()
        {
            Clear();
            ForegroundColor = Green;
            DateTime date = new(2022, 10, 15);
            WriteLine(".................." + date.ToLongDateString() + "..................");

            List<string> notes = new() {"Сходить на пары", "Поехать к родителям" };
            foreach (var note in notes)
            {
                WriteLine("  " + note);
            }

            //Add(notes);

        }
        static void Day1()
        {
            Clear();
            ForegroundColor = Yellow;
            DateTime date = new(2022, 10, 16);
            WriteLine(".................." + date.ToLongDateString() + "..................");

            List<string> notes = new() { "Выспаться", "Переделать этот код" };
            foreach (var note in notes)
            {
                WriteLine("  " + note);
            }
        }
        static void Day_1()
        {
            Clear();
            ForegroundColor = DarkCyan;
            DateTime date = new(2022, 10, 14);
            WriteLine(".................." + date.ToLongDateString() + "..................");

            List<string> notes = new() {"Что-нибудь придумаю"};
            foreach (var note in notes)
            {
                WriteLine("  " + note);
            }
        }









        private static void Add(List<string> notes)
        {
            var key = ReadKey();
            Clear();
            switch (key.Key)
            {
                case OemPlus:
                    var newNote = ReadLine();
                    if (newNote != null) notes.Add(newNote);
                    break;
            }
        }
    }
}