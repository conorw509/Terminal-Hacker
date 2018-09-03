using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    
    //Game State
    int level;
    enum Screen { MainMenu, PasswordScreen, WinScreen}
    Screen currentScreen;

	
    // Use this for initialization
	void Start () {
       showMainMenu();  
	}

    void showMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.WriteLine("Select from one of the following to hack into.");
        Terminal.WriteLine(" ");
        Terminal.WriteLine(" 1. State Exams Commission ");
        Terminal.WriteLine(" 2. Facebook ");
        Terminal.WriteLine(" 3. The Pentagon ");
        Terminal.WriteLine(" Enter Selection: ");
     }

    void OnUserInput(string input)
    {

        if (input == "menu")
        {
         
            showMainMenu();
            
        }

        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

        void RunMainMenu(string userInput) { 
        {

            if (userInput == "1")
            {

                level = 1;
                startGame();
            }

            else if (userInput == "2")
            {

                level = 2;
                startGame();
            }

            else if (userInput == "3")
            {

                level = 3;
                startGame();
            }
            else if (userInput == "Conor")
            {
                Terminal.WriteLine("Welcome Master Conor");
            }
            else
            {
                Terminal.WriteLine("Select a valid input");
            }
        }
    }

    void startGame()
    {
        currentScreen = Screen.PasswordScreen;
        Terminal.WriteLine(" You have chosen level: " +level);
        Terminal.WriteLine(" Please Enter a Password: ");
        

    }
    
	
	// Update is called once per frame
	void Update () {
		
	}
}
