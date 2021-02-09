using System;

namespace ButtonDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var button = new Button
            {
                Width = 9,
                Height = 3,
                Text = "Click",
                hBorderColor = ConsoleColor.Red,
            };

            button.ButtonAction += Console.WriteLine;
            button.ButtonAction += data => Save(data);
            button.Draw();
        }

        private static void Save(string data)
        {

        }
    }
}
