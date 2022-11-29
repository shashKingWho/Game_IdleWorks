using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //create 2 public static int to be accessed from all over
    public static float float_oxygen;
    public static int int_oxygenMultiplier;

    private void Awake()
    {
        //initialize int_oxygen
        float_oxygen = 0;

        // intitialize int_oxygenMultiplier
        int_oxygenMultiplier = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
