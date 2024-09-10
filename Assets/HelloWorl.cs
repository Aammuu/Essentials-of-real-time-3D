using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorl : MonoBehaviour
{
    public string myMessage; 
    // The Start function runs once at the beginning of the game, 
    // and the Update function runs at every frame of the game (more about frames later). 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(myMessage);
    }
}
