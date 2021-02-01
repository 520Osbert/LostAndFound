using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sugar : MonoBehaviour
{
    private Transform myTransform;
    private bool enlarged;

    private void Start()
    {
        myTransform = GetComponent<Transform>();
        enlarged = false;
    }
    public void OnMouseDown()
    {
        if (!enlarged)
        {
            Vector2 ScaleUp = new Vector2(myTransform.localScale.x * 2f, myTransform.localScale.y * 2f);
            myTransform.localScale = ScaleUp;
            enlarged = true;
        }
        
        changeState();
        Debug.Log("change state");
        Debug.Log("current:" + babyMove.babyState);
        /*Destroy(this.gameObject);*/
    }

    public void changeState()
    {
        babyMove.babyState += 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
