using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePowerUps : MonoBehaviour
{
    // Class Objective: to provide functions for powerups
    // Use GameUIUpdate to update UI

    [SerializeField] GameUIUpdate class_gameUIUpdate;
    [SerializeField] bool bool_enabledAutoIncrease = false;

    [SerializeField] int int_AutoClickerDuration = 5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bool_enabledAutoIncrease) {
            func_AutoClicker();
        }
    }

    public void Func_IncreaseOnClick()
    {
        GameManager.float_oxygen+= GameManager.int_oxygenMultiplier;
    }


    ///<summary>
    ///<para> <b>Object summary:</b> </para>
    /// Condition check for 
    ///<para>Int number of the button </para>
    ///<para>Cost to compare with current amount </para>
    ///<para>    How much to increase the multiplier </para>
    ///<para>    Subtract the cost with the oxygen </para>
    ///<para>    Increase the cost </para>
    ///</summary>       
    public void funct_PurchasePowerUp(int int_WhichPurchaseButton) {

        // function for 1st button
        if (int_WhichPurchaseButton == 1 && GameManager.float_oxygen >= 5){ //25) {
            // Increase the multiplier
            GameManager.int_oxygenMultiplier += 1;
            // Update Multiplier in UI
            class_gameUIUpdate.func_UpdateOxygenMultiplier();

            // minus the Oxygen after purchase
            GameManager.float_oxygen -= 5;

            //increase the value for purchase
        }

        // function for 2nd button
        if (int_WhichPurchaseButton ==2 && GameManager.float_oxygen >= 12){  //125) {
            // Increase the multiplier
            GameManager.int_oxygenMultiplier += 10;
            // Update Multiplier in UI
            class_gameUIUpdate.func_UpdateOxygenMultiplier();


            // minus the Oxygen after purchase
            GameManager.float_oxygen -= 12;

            //increase the value for purchase
        }

        // function for 3rd button
        if (int_WhichPurchaseButton == 3 && GameManager.float_oxygen >= 20){ // 1500){       
            // Increase the multiplier
            GameManager.int_oxygenMultiplier += 100;
            // Update Multiplier in UI
            class_gameUIUpdate.func_UpdateOxygenMultiplier();

            // minus the Oxygen after purchase
            GameManager.float_oxygen -= 20;

            //increase the value for purchase
        }


    }

    public void func_autoIncreaser() {
        if (!bool_enabledAutoIncrease && GameManager.float_oxygen >= 5) {
            // enable the bool so that function runs in the Update
            bool_enabledAutoIncrease = true;

            // subtract the amount after purchasing
            GameManager.float_oxygen -= 5;

            //increase the value for purchase
        }
    }

    public void func_AutoClicker() {
        //int int_time = Mathf.RoundToInt(int_AutoClickerDuration * Time.deltaTime);
        //print(int_time);

        GameManager.float_oxygen += int_AutoClickerDuration * Time.deltaTime;

       

    }
}
