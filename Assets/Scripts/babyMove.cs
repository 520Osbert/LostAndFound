using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class babyMove : MonoBehaviour
{
    public static int babyState = 0;
    public GameObject aniObj1;
    public GameObject carpet;
    public GameObject pillow;
    public GameObject seesaw;

    private Animator anim1;

    private void Awake()
    {
        anim1 = aniObj1.GetComponent<Animator>();
    }
    private void Update()
    {
        if (babyState == 1 && pillow.GetComponent<pillow>().pass == true)
        {
            anim1.SetInteger("baby_move",1);
        }
        else if (babyState == 2 && carpet.GetComponent<carpet>().pass == true)
        {
            anim1.SetInteger("baby_move", 2);
        }
        else if (babyState == 3 && seesaw.GetComponent<seesaw>().pass == true)
        {
            anim1.SetInteger("baby_move", 3);
        }
        else if (babyState == 4)
        {
            anim1.SetInteger("baby_move", 4);
        }
        else if (babyState == 5)
        {
            anim1.SetInteger("baby_move", 5);
        }
        else if (babyState == 6)
        {
            anim1.SetInteger("baby_move", 6);
        }
        else if (babyState == 7)
        {
            anim1.SetInteger("baby_move", 7);
        }
 
    }

   
}
