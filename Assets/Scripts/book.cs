using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book : MonoBehaviour
{
    private Transform myTransform;
    private bool isClicked = false;
    public float degree;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isClicked && degree > 0){
            myTransform.Rotate(Vector3.forward * Time.deltaTime * speed);
            degree -= Time.deltaTime * speed;
        }
    }

    public void Rotate()
    {
        isClicked = true;
        TrapBoolTable.trap_D_is_on = true;
        Debug.Log("click");
    }
}
