using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curtains : MonoBehaviour
{
    private Transform myTransform;
    private bool isClicked = false;
    public float scale;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isClicked && scale > 0){
            myTransform.localScale += Vector3.up * Time.deltaTime * speed;
            myTransform.position -= Vector3.up * Time.deltaTime * speed;
            scale -= Time.deltaTime * speed;
        }
    }

    public void enlarge()
    {
        isClicked = true;
        Debug.Log("click");
    }
}
