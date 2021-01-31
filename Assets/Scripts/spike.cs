using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike : MonoBehaviour
{
    public float newZ;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger");
        if (other.tag == "pillow")
        {
            // gameObject.transform.Translate(new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, newZ));
            gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, newZ);
        }
    }
}
