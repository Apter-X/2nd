using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace GCB.Modules.Consoletop
{
    class Menu
    {
        public string Logo;
        private string _prompt;
        private string[] _options;

        private int _selectedIndex;

        public Menu(string prompt, string[] options)
        {
            this.Logo = @"
                 _______                       __       
                /       \                     /  |      
                $$$$$$$  |  ______   _______  $$ |   __ 
                $$ |__$$ | /      \ /       \ $$ |  /  |
                $$    $$<  $$$$$$  |$$$$$$$  |$$ |_/$$/ 
                $$$$$$$  | /    $$ |$$ |  $$ |$$   $$<  
                $$ |__$$ |/$$$$$$$ |$$ |  $$ |$$$$$$  \ 
                $$    $$/ $$    $$ |$$ |  $$ |$$ | $$  |
                $$$$$$$/   $$$$$$$/ $$/   $$/ $$/   $$/ 
            ";
            this._prompt = "\n\n\t\t" + prompt + "\n\n";
            this._options = options;

            this._selectedIndex = 0;
        }

        /// <summary>
        /// Display screen
        /// </summary>
        /// <param name="prompt"></param>
        /// <return>oid</return>
        public void DisplayOption()
        {
            Clear();
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine(Logo + _prompt);

            for (int i = 0;i < _options.Length; i++)
            {
                string currentOption = _options[i];
                string prefix;
                
                if (i == _selectedIndex)
                {
                    prefix  = ">";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix =  " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black; 
                }

                WriteLine($" {prefix} {currentOption}");
            }
            ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;

            do
            {
                Clear();
                DisplayOption();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                  
                if(keyPressed == ConsoleKey.UpArrow)
                {
                    _selectedIndex--;

                    if(_selectedIndex == -1)
                    {
                        _selectedIndex = _options.Length - 1;
                    }
                }

                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    _selectedIndex++;

                    if(_selectedIndex == _options.Length)
                    {
                        _selectedIndex = 0;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);

            return _selectedIndex;
        }

        public string Read()
        {
            Clear();
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine(Logo + _prompt);

            string input = ReadLine();
            return input;
        }

    }
}
