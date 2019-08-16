using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Window : MonoBehaviour 
{

    public int windowID;
    private int currentWindowIndex;

    protected virtual void Awake()
    {
        
        currentWindowIndex = windowID;
        Debug.Log("Opening window Index: "+currentWindowIndex);
    }

    protected abstract void Open();


    protected abstract void Close();

	
}
