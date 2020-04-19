using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitWhenActive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (this.enabled == true)
        {
            Debug.Log("We quit");
            print("we quit");
            Application.Quit();
        }
    }

    
}
