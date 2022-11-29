using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class GameUIUpdate : MonoBehaviour
{
    [SerializeField] TMP_Text txtTMP_Oxygen;
    ///<summary>
    ///woh ajnabi
    ///</summary>
    [SerializeField] TMP_Text txtTMP_OxygenMultiplier;


    // Start is called before the first frame update
    void Start()
    {
        func_UpdateOxygenMultiplier();
    }

    // Update is called once per frame
    void Update()
    {
        // Use floatValue.ToString("0") to show non decimal value
        txtTMP_Oxygen.text = "O2 is: " + GameManager.float_oxygen.ToString("0");

    }

    // Update UI: Oxygen
    public void func_UpdateOxygenMultiplier(int int_whatAmount) {
        txtTMP_OxygenMultiplier.text = int_whatAmount.ToString();
    }

  
    /// <summary>
    /// <b>Obj Summary:</b> Call this to update the Oxygen Multiplier in the UI
    /// </summary>
    public void func_UpdateOxygenMultiplier() { 
        txtTMP_OxygenMultiplier.text = "O2 Multiplayer is: " + GameManager.int_oxygenMultiplier.ToString();

    }
}
