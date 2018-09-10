using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    //Game configuration data
    string[] level1Passwords = { "conor", "darragh", "saoirse", "rachel", "lee" };
    string[] level2Passwords = { "jemmy", "kayo", "sadie", "demi", "graham" };
    const string menuHint = " Type 'menu' to return to main menu";


    //Game State
    int level;
    enum Screen { MainMenu, PasswordScreen, WinScreen}
    Screen currentScreen;
    string password;
 
    

	
    // Use this for initialization
	void Start () {
       showMainMenu();  
	}

    void showMainMenu()
    {
        Terminal.ClearScreen();
        currentScreen = Screen.MainMenu;
        Terminal.WriteLine(" Select from one of the following to hack into.");
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

        else if(currentScreen == Screen.PasswordScreen)
        {
            checkPasswords(input);
        }
    } 

        void RunMainMenu(string userInput) { 
        {
            bool isValidLevelNumber = (userInput == "1" || userInput == "2" || userInput =="3");
            if (isValidLevelNumber)
            {
                level = int.Parse(userInput);
                startGame();
            }
            
            else if (userInput == "Conor") //easter egg
            {
                Terminal.WriteLine("Welcome Master Conor");
            }
            else
            {
                Terminal.WriteLine("Select a valid level");
            }
        }
    }

    void checkPasswords(string passwordInput)
    {
     
        if(passwordInput == password)
        {
            win();
        }

        else if(passwordInput == "d")
        {
            showMainMenu();
        }
        else
        {
        
            Terminal.ClearScreen();
            tryAgain();
        }

    }

    void startGame()
    {
        currentScreen = Screen.PasswordScreen;
        Terminal.ClearScreen();
        switch (level)
        {
            case 1:
                int index = Random.Range(0, level1Passwords.Length);
                password = level1Passwords[index];
                break;

            case 2:
                int index2 = Random.Range(0, level2Passwords.Length);
                password = level2Passwords[index2];
                break;

            case 3:
                int index3 = Random.Range(0, level2Passwords.Length);
                password = level2Passwords[index3];
                break;

            default:
                Debug.LogError(" Inavlid level Number" );
                break;
                
                
        }
        Terminal.WriteLine(" Please Enter a Password, hint: " +password.Anagram());
        Terminal.WriteLine(menuHint);
    }

    void tryAgain()
    {
        currentScreen = Screen.PasswordScreen;
        Terminal.WriteLine(menuHint);
        Terminal.WriteLine(" Please Enter a Password, hint: " +password.Anagram());

    }

    void win()
    {
        Terminal.ClearScreen();
        currentScreen = Screen.WinScreen;
        rewardScreen();   
    }

    void rewardScreen()
    {
       switch (level)
        {

            case 1:
                Terminal.WriteLine("Correct you Win!");
                Terminal.WriteLine("Have a book.....");
                Terminal.WriteLine(menuHint);
                Terminal.WriteLine(@"
    _________        
   /        /| 
  /        / /   
 /________/ /
(_________(/
");
                break;

            case 2:
                Terminal.WriteLine("Correct you Win!");
                Terminal.WriteLine("Your into Facebook");
                Terminal.WriteLine(menuHint);   Terminal.WriteLine(@"
  ____________ 
 |    _________|
 |   |
 |   |_____
 |   ______| 
 |  |
 |  |
 |__|
");
                break;

            case 3:
                Terminal.WriteLine("Correct you Win!");
                Terminal.WriteLine(menuHint);
                break;

        }
    }
}
