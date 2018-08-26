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
	
	// Update is called once per frame
	void Update () {
		
	}
}
