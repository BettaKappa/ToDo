using static System.Console;
using static System.ConsoleKey;
using static System.ConsoleColor;

namespace ToD0
{
    internal class Program
    {
        static void Main()
        {
            ForegroundColor = DarkCyan;
            WriteLine("\r\n               ,--,                                                                       \r\n,-.----.    ,---.'|                             ,--.          ,--.                        \r\n\\    /  \\   |   | :       ,---,               ,--.'|        ,--.'|     ,---,. ,-.----.    \r\n|   :    \\  :   : |      '  .' \\          ,--,:  : |    ,--,:  : |   ,'  .' | \\    /  \\   \r\n|   |  .\\ : |   ' :     /  ;    '.     ,`--.'`|  ' : ,`--.'`|  ' : ,---.'   | ;   :    \\  \r\n.   :  |: | ;   ; '    :  :       \\    |   :  :  | | |   :  :  | | |   |   .' |   | .\\ :  \r\n|   |   \\ : '   | |__  :  |   /\\   \\   :   |   \\ | : :   |   \\ | : :   :  |-, .   : |: |  \r\n|   : .   / |   | :.'| |  :  ' ;.   :  |   : '  '; | |   : '  '; | :   |  ;/| |   |  \\ :  \r\n;   | |`-'  '   :    ; |  |  ;/  \\   \\ '   ' ;.    ; '   ' ;.    ; |   :   .' |   : .  /  \r\n|   | ;     |   |  ./  '  :  | \\  \\ ,' |   | | \\   | |   | | \\   | |   |  |-, ;   | |  \\  \r\n:   ' |     ;   : ;    |  |  '  '--'   '   : |  ; .' '   : |  ; .' '   :  ;/| |   | ;\\  \\ \r\n:   : :     |   ,/     |  :  :         |   | '`--'   |   | '`--'   |   |    \\ :   ' | \\.' \r\n|   | :     '---'      |  | ,'         '   : |       '   : |       |   :   .' :   : :-'   \r\n`---'.|                `--''           ;   |.'       ;   |.'       |   | ,'   |   |.'     \r\n  `---`                                '---'         '---'         `----'     `---'       \r\n                                                                                          \r\n");
            WriteLine("\t" + "\t" + "\t" + "ДЛЯ ЗАПУСКА ПРОГРАММЫ НАЖМИТЕ ПРОБЕЛ");
            Arrow();
        }
        public static void Arrow()
        {
            Note note1 = new()
            {
                Name = "Что-нибудь придумаю",
                Description = "Или нет",
                EndDate = new DateTime(2022, 10, 14)
            };

            Note note2 = new()
            {
                Name = "Выспаться",
                Description = "Ахахахаха конечно",
                EndDate = new DateTime(2022, 10, 16)
            };

            Note note3 = new()
            {
                Name = "Сходить на пары",
                Description = "Не заснуть на БЖД",
                EndDate = new DateTime(2022, 10, 16)
            };

            Note note4 = new()
            {
                Name = "Сходить на пары",
                Description = "Я обязательно выживу",
                EndDate = new DateTime(2022, 10, 15)
            };

            Note note5 = new()
            {
                Name = "Поехать к родакам",
                Description = "Хоть бы без пробок",
                EndDate = new DateTime(2022, 10, 15)
            };

            List<Note> allNotes = new()
            {
                note1,
                note2,
                note3,
                note4,
                note5
            };

            DateTime dayNow = new (2022, 10, 15);
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
                        dayNow = dayNow.AddDays(-1);
                        break;
                    case RightArrow:
                        dayNow = dayNow.AddDays(1);
                        break;
                    case Escape:
                        Clear();
                        WriteLine("\r\n ____  _  _  ____ \r\n(  _ \\( \\/ )( ___)\r\n ) _ < \\  /  )__) \r\n(____/ (__) (____)\r\n");
                        Environment.Exit(0);
                        break;
                }

                Clear();

                ShowDate(dayNow, allNotes);

                SetCursorPosition(0, position);
                WriteLine("->");

                key = ReadKey();
            }

            Clear();
            ShowInfo(position, dayNow, allNotes);
            Arrow();
        }

        private static void ShowInfo(int position, DateTime date, List<Note> myNotes)
        {
            List<Note> sortedNotes = myNotes.Where(note => note.EndDate.Date == date.Date).ToList();
            WriteLine(sortedNotes[position - 1].Name +
                      "\t" + "|" + "\t" + 
                      sortedNotes[position - 1].EndDate.Date + "\n" +
                      "------------------------------------------------" + "\n" + "\n" +
                      " " + sortedNotes[position - 1].Description);
        }

        private static void ShowDate(DateTime date, List<Note> myNotes )
        {
            Clear();
            ForegroundColor = DarkCyan;
            WriteLine(".................." + date.ToLongDateString() + "..................");

            List<Note> sortedNotes = myNotes.Where(note => note.EndDate.Date == date.Date).ToList();
            foreach (Note note in sortedNotes)
            {
                    WriteLine("  " + note.Name);
            }
        }   
    }
}
