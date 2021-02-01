using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sugar : MonoBehaviour
{
    private Transform myTransform;

    private void Start()
    {
        myTransform = GetComponent<Transform>();
    }
    public void OnMouseDown()
    {
        Vector2 ScaleUp = new Vector2(myTransform.localScale.x * 2f, myTransform.localScale.y * 2f);
        myTransform.localScale = ScaleUp;
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
