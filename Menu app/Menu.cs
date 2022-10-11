using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_app
{
    internal class Menu:IMenuItem
    {
        public Menu(string title)
        {
            Title = title;
        }
        public string Title { get; set; }
        private bool _running { get; set; }
        private int CurrentSelected { get; set; } 

        List<IMenuItem> MenuItemList = new List<IMenuItem>();

        public void Add(IMenuItem i)
        {
            MenuItemList.Add(i);
        }

        public void Select()
        {
            this.Start();
        }

        public void Start()
        {
            Console.WriteLine($"[[{Title}]]");
            _running = true;
            do
            {
                DrawMenu();
                HandleInput();
            } while (_running);
        }

        //Draws a menu and handles which is highlighted because it is selected
        private void DrawMenu()
        {
            Console.Clear();
            Console.WriteLine(this.Title);

            foreach (IMenuItem item in MenuItemList)
            {
                if (CurrentSelected == MenuItemList.IndexOf(item))
                {
                    Console.WriteLine("->"+item.Title);
                    if (item is MenuItem menuItem)
                    {
                        Console.WriteLine("\t" + menuItem.Content);
                    }
                }
                else
                {
                     Console.WriteLine(item.Title);
                }
               
            }
        }

        private void HandleInput()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.Escape:
                    _running = false;
                    break;
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;

                default:
                    break;
            }
        }

        private void MoveUp()
        {
            if (CurrentSelected > 0)
            {
                CurrentSelected -= 1;
            }
        }
        private void MoveDown()
        {
            if (CurrentSelected < MenuItemList.Count - 1)
            {
                CurrentSelected += 1;
            }
        }

    }
}
