namespace to_do
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Для запуска программы нажмите Пробел");
            Arrow();
        }

        static void Arrow()
        {
            int position = 0;
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
                }
                Console.Clear();

                Damn();

                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();
                Switch(position);
            }
        }

        static void Switch(int position)
        {
            switch (position)
            {
                case 0:
                    Notes();
                    break;
                case 1:
                    Guide();
                    break;
            }
        }
        static void Damn()
        {
            Console.WriteLine(" " + " " + "Записи" + "\n" +
                              " " + " " + "Инструкция");
        }

        static void Notes()
        {
            Console.Clear();
            DateTime date = new(2022, 10, 14);
            Console.WriteLine(".................." +
                              date.ToLongDateString() +
                              "..................");

            List<string> notes = new() { "Выспаться", "Сходить на пары", "Сходить в магаз за едой" };
            foreach (var note in notes)
            {
                Console.WriteLine(note);
            }

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

        static void Guide()
        {
            Console.Clear();
            Console.WriteLine("Здесь я напишу назначение клавиш");
        }
    }
}