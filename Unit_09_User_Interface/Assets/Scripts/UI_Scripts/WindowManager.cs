using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour 
{

    public Window[] windows;

    private Window _window;
    public Window Window
    {
        get {return _window; }
        set {_window = value; }
    }



    public static WindowManager instance;

	// Use this for initialization
	void Awake () 
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }


	}
	
	




}
