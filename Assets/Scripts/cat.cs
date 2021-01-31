using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    private Transform myTransform;
    private bool isClicked = false;
    public Vector3 direction;
    public float distant;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isClicked && distant > 0){
            myTransform.position += direction * Time.deltaTime * speed;
            distant -= Time.deltaTime * speed;
        }
    }

    public void Move()
    {
        isClicked = true;
        TrapBoolTable.trap_E_is_on = true;
        Debug.Log("click");
    }
}
