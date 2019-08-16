using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuWindow : Window 
{


	protected override void Awake()
	{
        windowID = 0;
        base.Awake();
	}

	protected override void Open()
	{
        
	}

	protected override void Close()
	{
        
	}

	public void Quit()
    {
        Debug.Log("Quitting");
       
        Application.Quit();
    }

}
