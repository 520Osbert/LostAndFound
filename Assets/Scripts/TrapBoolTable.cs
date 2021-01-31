using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBoolTable : MonoBehaviour
{
    public static bool trap_A_is_on = false;
    public static bool trap_B_is_on = false;
    public static bool trap_C_is_on = false;
    public static bool trap_D_is_on = false;
    public static bool trap_E_is_on = false;
    public static bool trap_F_is_on = false;

    public static bool[] all_traps = {trap_A_is_on,trap_B_is_on,trap_C_is_on,trap_D_is_on,trap_E_is_on,trap_F_is_on};

    public void UpdateStatus(){
        all_traps = new bool[] {trap_A_is_on,trap_B_is_on,trap_C_is_on,trap_D_is_on,trap_E_is_on,trap_F_is_on};
    }
}
