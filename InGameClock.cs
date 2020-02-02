using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameClock : MonoBehaviour
{
    /* Script should be running the entire game from hitting start until the end.
     * This function should be applied to something that will be in the scene upon starting the game and destroyed when restarting.
     * It updates a clock that will be rendered onscreen. How often the clock increments can be modified using the SPEED variable.
     * 
     * The only change that will need to be made is on line 42, in which it should output to the GUI instead of the debug log.
     */

    double speed = 1.0; //The lower this number is, the faster the clock will update ingame.
    
    int hour = 0;
    int min = 0; //tens place of the minutes
    double lastChange = 0.0;

    void Start()
    {
        hour = 8;
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastChange > speed) 
        {
            min += 1;
            lastChange = 0;
            if (min >= 6)
            {
                min = 0;
                hour++;
            }
            lastChange = Time.time;
        }
      
        //in the game, change the below code from printing to the debug menu to updating on the GUI
        Debug.Log(hour.ToString() + ":" + min.ToString() + "0");
    }
}
