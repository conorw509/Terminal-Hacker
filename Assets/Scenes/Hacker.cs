using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {

        showMainMenu();  
	}

    void showMainMenu()
    {

        Terminal.WriteLine("Select from one of the following to hack into.");
        Terminal.WriteLine(" ");
        Terminal.WriteLine(" 1. State Exams Commission ");
        Terminal.WriteLine(" 2. Facebook ");
        Terminal.WriteLine(" 3. The Pentagon ");

        Terminal.WriteLine(" Enter Selection: ");
     }

    void OnUserInput(string input)
    {
        //Terminal.WriteLine (" User entered: " + input);
        if (input == "menu")
        {
            Terminal.ClearScreen();
             showMainMenu();
        }
        else if (input == "Conor")
        {
            Terminal.WriteLine("Welcome Master Conor");
        }

        else
        {
            Terminal.WriteLine("Select a valid input");
        }
    }
    
	
	// Update is called once per frame
	void Update () {
		
	}
}
