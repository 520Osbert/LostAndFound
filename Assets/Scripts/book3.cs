using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book3 : MonoBehaviour
{
    public float speed;
    public float degree;
    public bool pass;
    private float original;

    void Awake()
    {
        original = degree;
    }

    void OnMouseDown()
    {
        if (degree > 0)
        {
            while (degree > 0)
            {
                transform.Rotate(Vector3.forward * Time.deltaTime * speed);
                degree -= Time.deltaTime * speed;
            }
            pass = true;
        }
        else
        {
            /*while (degree < original)
            {
                transform.Rotate(Vector3.forward * Time.deltaTime * speed);
                degree += Time.deltaTime * speed;
            }*/
            pass = false;
        }
    }
}
