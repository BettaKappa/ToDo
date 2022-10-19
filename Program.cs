using static System.Console;
using static System.ConsoleKey;
using static System.ConsoleColor;

namespace ToD0
{
    internal class Program
    {
        static void Main()
        {
            WriteLine("Нажмите пробел");
            Arrow();
        }
        public static void Arrow()
        {
            Note note1 = new()
            {
                Name = "A",
                Description = "AA",
                EndDate = new DateTime(2022, 10, 14)
            };

            Note note2 = new()
            {
                Name = "B",
                Description = "BB",
                EndDate = new DateTime(2022, 10, 16)
            };

            Note note3 = new()
            {
                Name = "C",
                Description = "CC",
                EndDate = new DateTime(2022, 10, 16)
            };

            Note note4 = new()
            {
                Name = "D",
                Description = "DD",
                EndDate = new DateTime(2022, 10, 15)
            };

            Note note5 = new()
            {
                Name = "E",
                Description = "EE",
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
                      "-----------------------------------" + "\n" + "\n" +
                      sortedNotes[position - 1].Description);
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
