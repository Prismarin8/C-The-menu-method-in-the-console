using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КНБ
{
    internal class Menu
    {
        class buttons
        {
            public bool active;
            public string text;

        }
        //Метод выводящий текст по центру
        //The method that displays the text in the center
        static void center(string a)
        {
            for (int i = 0; i < (Console.WindowWidth - a.Length) / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write(a);
            Console.WriteLine();
        }
        //Метод создающий горизонтальную линию
        //A method that creates a horizontal line
        static void border()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
        }
        public static void Menushka()
        {
            //Оформление заголовка
            //Header design
            border();
            Console.WriteLine();
            center("Header");
            border();
            //Отступ от заголовка
            //Indentation from the title
            for (int i = 0; i < Console.WindowHeight / 6; i++)
            {
                Console.WriteLine(" ");
            }
            Console.WriteLine("   Button1");
            Console.WriteLine("   Button2");
            Console.WriteLine("   Button3");
            Console.WriteLine("   Button4");
            //Создание объектов класса кнопки
            //Creating Button class objects
            buttons start = new buttons();
            start.active = false;
            start.text = "Button1";
            buttons profile = new buttons();
            profile.active = false;
            profile.text = "Button2";
            buttons leaderboard = new buttons();
            leaderboard.active = false;
            leaderboard.text = "Button3";
            buttons exit = new buttons();
            exit.active = false;
            exit.text = "Button4";
            //Объект регистрирования клавиш
            //Key registration object
            ConsoleKey key;
            key = Console.ReadKey(true).Key;
            //Выбор в меню по кнопкам
            //Button selection in the menu
            int change_menu = 0;
            do
            {
                while (true == true)
                {
                    //Button1
                    if (key == ConsoleKey.W && change_menu == 0)
                    {
                        change_menu = 1;
                        key = 0f;
                        key = Console.ReadKey(true).Key;
                    }
                    //При нажатии W
                    //When pressing W
                    if (key == ConsoleKey.W && change_menu != 0)
                    {
                        change_menu--;
                        if (change_menu == 0)
                        {
                            change_menu = 4;
                        }
                        key = 0f;
                        key = Console.ReadKey(true).Key;

                    }
                    //При нажатии S
                    //When pressing S
                    if (key == ConsoleKey.S)
                    {
                        change_menu++;
                        if (change_menu == 5)
                        {
                            change_menu = 1;
                        }
                        key = 0f;
                        key = Console.ReadKey(true).Key;
                    }
                    //Выбеление элементов меню
                    //Highlighting menu items
                    //Выделение Button1
                    //Highlighting Button1
                    if (change_menu == 1)
                    {
                        key = Console.ReadKey(true).Key;
                        if (key == ConsoleKey.Spacebar)
                        {
                            //Метод, запускаемый при нажатии кнопки
                            //The method that is triggered when the button is pressed
                        }
                        Console.SetCursorPosition(3, 11);
                        //Проверка повторяемости действия
                        //Checking the repeatability of an action
                        if (start.active == true)
                        {
                            break;
                        }
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(start.text);
                        start.active = true;
                        profile.active = false;
                        leaderboard.active = false;
                        exit.active = false;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(3, 14);
                        Console.WriteLine(exit.text);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(3, 12);
                        Console.WriteLine(profile.text);
                    };
                    //Выделение Button2
                    //Highlighting Button2
                    if (change_menu == 2)
                    {
                        key = Console.ReadKey(true).Key;
                        if (key == ConsoleKey.Spacebar)
                        {
                            //Метод, запускаемый при нажатии кнопки
                            //The method that is triggered when the button is pressed
                        }

                        Console.SetCursorPosition(3, 12);
                        //Проверка повторяемости действия
                        //Checking the repeatability of an action
                        if (profile.active == true)
                        {
                            break;
                        }
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(profile.text);
                        start.active = false;
                        profile.active = true;
                        leaderboard.active = false;
                        exit.active = false;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(3, 11);
                        Console.WriteLine(start.text);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(3, 13);
                        Console.WriteLine(leaderboard.text);
                    };
                    //Выделение Button3
                    //Highlighting Button3
                    if (change_menu == 3)
                    {
                        key = Console.ReadKey(true).Key;
                        if (key == ConsoleKey.Spacebar)
                        {
                            //Метод, запускаемый при нажатии кнопки
                            //The method that is triggered when the button is pressed
                        }

                        Console.SetCursorPosition(3, 13);
                        //Проверка повторяемости действия
                        //Checking the repeatability of an action
                        if (leaderboard.active == true)
                        {
                            break;
                        }
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(leaderboard.text);
                        start.active = false;
                        profile.active = false;
                        leaderboard.active = true;
                        exit.active = false;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(3, 12);
                        Console.WriteLine(profile.text);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(3, 14);
                        Console.WriteLine(exit.text);


                    };
                    //Выделение Button4
                    //Highlighting Button4
                    if (change_menu == 4)
                    {
                        key = Console.ReadKey(true).Key;
                        if (key == ConsoleKey.Spacebar)
                        {
                            //Метод, запускаемый при нажатии кнопки
                            //The method that is triggered when the button is pressed
                        }

                        Console.SetCursorPosition(3, 14);
                        //Проверка повторяемости действия
                        //Checking the repeatability of an action
                        if (exit.active == true)
                        {
                            break;
                        }
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(exit.text);
                        start.active = false;
                        profile.active = false;
                        leaderboard.active = false;
                        exit.active = true;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(3, 13);
                        Console.WriteLine(leaderboard.text);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(3, 11);
                        Console.WriteLine(start.text);
                    };
                }
            }
            while (true == true); 
        }
    }
}
