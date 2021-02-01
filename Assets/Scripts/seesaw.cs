using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seesaw : MonoBehaviour
{
    
    public float speed;
    public float degree;
    public bool pass;
    private float original;

    void Awake()
    {
        original = degree;
    }
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Debug.Log("click");
        if (degree > 0)
        {
            while (degree > 0)
            {
                transform.Rotate(Vector3.back * Time.deltaTime * speed);
                degree -= Time.deltaTime * speed;
            }
            pass = true;
        }
        else
        {
            while (degree < original)
            {
                transform.Rotate(Vector3.forward * Time.deltaTime * speed);
                degree += Time.deltaTime * speed;
            }
            pass = false;
        }
            

        //gameObject.transform.rotation = new Quaternion(gameObject.transform.rotation.x, gameObject.transform.rotation.y, newZRotatation, 0);
        //if (gameObject.transform.rotation.z == newZRotatation)
        //{
        //    gameObject.transform.rotation = new Quaternion(gameObject.transform.rotation.x, gameObject.transform.rotation.y, -newZRotatation, 0);
        //    pass = false;
        //}
        //else
        //{
        //    gameObject.transform.rotation = new Quaternion(gameObject.transform.rotation.x, gameObject.transform.rotation.y, newZRotatation, 0);
        //    pass = true;
        //}

    }
}
