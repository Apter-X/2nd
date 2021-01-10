using System;
using static System.Console;
using GCB.Modules.Consoletop;

namespace GCB.Modules.Consoletop
{
    public static class Navigate
    {
        public static void Start()
        {
            Title = "Account";
            RunNavigate();
        }

        public static void RunNavigate()
        {
            string prompt = "Choose an option";
            string[] options = { "Add account", "Search account", "Delete account", "Exit" };

            //Loader load = new Loader();
            Menu mainMenu = new Menu(prompt, options);

            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0 :
                    TypeAccount();
                    break;
                case 1:
                    SearchProfile();
                    break;
                case 2:
                    DeleteAccount();
                    break;
                case 3:
                    Exit();
                    break;
                default:
                    RunNavigate();
                    break;
            }
        }

        public static bool TypeAccount()
        {
            string prompt = "Add account";
            string[] options = { "Check account", "Notebook account", "Back" };

            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Register("check");
                    break;
                case 1:
                    Register("notebook");
                    break;
                default:
                    RunNavigate();
                    break;
            }

            return true;
        }

        public static bool Register(string type)
        {
            string prompt = "Insert a name";
            string[] options = { "Validate", "Back" };

            Menu menu = new Menu(prompt, options);

            string name = menu.Read();

            string prompt1 = $"Are you sur you ?";
            Menu menu2 = new Menu(prompt1, options);

            int index = menu2.Run();

            switch (index)
            {
                case 0:
                    string prompt2 = "Succeed !";
                    string[] options2 = { "Back" };
                    Menu menu3 = new Menu(prompt2, options2);

                    int index2 = menu3.Run();
                    RunNavigate();
                    break;
                case 1:
                    RunNavigate();
                    break;
                default:
                    RunNavigate();
                    break;
            }
            return true;
        }

        public static bool SearchProfile()
        {
            string prompt = "Searching";
            string[] options = { "Back" };

            Menu menu = new Menu(prompt, options);

            string id = menu.Read();

            string table = @"
            +---------+----------------------------------+-----------------+----------------+
            |   Id    |               Name               |       Type      |     Credit     |
            +---------+----------------------------------+-----------------+----------------+
            |    4    | Mikasa Rouah                     |     Notebook    |       1.00 DH  |
            +---------+----------------------------------+-----------------+----------------+
            ";

            Console.WriteLine(table, id);

            Menu menu2 = new Menu("Profile" + table, options);
            int index = menu2.Run();

            RunNavigate();
            return true;
        }

        public static bool DeleteAccount()
        {
            Register("");

            string prompt = "Delete account";
            string[] options = { "Check account", "Notebook account", "Back" };

            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();

            return true;
        }

        public static bool Exit()
        {
            string byeAsci = @"
             $$$$$$\                            $$\ $$$$$$$\                      
            $$  __$$\                           $$ |$$  __$$\                     
            $$ /  \__| $$$$$$\   $$$$$$\   $$$$$$$ |$$ |  $$ |$$\   $$\  $$$$$$\  
            $$ |$$$$\ $$  __$$\ $$  __$$\ $$  __$$ |$$$$$$$\ |$$ |  $$ |$$  __$$\ 
            $$ |\_$$ |$$ /  $$ |$$ /  $$ |$$ /  $$ |$$  __$$\ $$ |  $$ |$$$$$$$$ |
            $$ |  $$ |$$ |  $$ |$$ |  $$ |$$ |  $$ |$$ |  $$ |$$ |  $$ |$$   ____|
            \$$$$$$  |\$$$$$$  |\$$$$$$  |\$$$$$$$ |$$$$$$$  |\$$$$$$$ |\$$$$$$$\ 
             \______/  \______/  \______/  \_______|\_______/  \____$$ | \_______|
                                                              $$\   $$ |          
                                                              \$$$$$$  |          
                                                               \______/           
            ";
            Clear();
            WriteLine(byeAsci);
            Environment.Exit(0);

            return true;
        }

    }
}
