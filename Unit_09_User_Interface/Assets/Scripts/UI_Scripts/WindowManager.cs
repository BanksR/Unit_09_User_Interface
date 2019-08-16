using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour 
{

    public Window[] windows;


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


        Open(0);

	}

    public void Open(int index)
    {
        foreach(var win in windows)
        {
            win.gameObject.SetActive(false);
        }

        windows[index].gameObject.SetActive(true);

    }
	
	




}
