using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillow : MonoBehaviour
{
    public float speed;
    public Vector3 targetPosition;
    public bool pass;

    void OnMouseDown()
    {
        float step = speed * Time.deltaTime;
        while (gameObject.transform.localPosition != targetPosition)
        {
            gameObject.transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition, targetPosition, step);
        }
        pass = true;
    }
    
}

