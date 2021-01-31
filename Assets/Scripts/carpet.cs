using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpet : MonoBehaviour
{
    public float newZRotatation;
    public float newXScale;
    public GameObject invisiableCarpet;
    public bool pass;

    void OnMouseDown()
    {
        Debug.Log("Trigger");
        gameObject.transform.rotation = new Quaternion(gameObject.transform.rotation.x, gameObject.transform.rotation.y, newZRotatation, 0);
        invisiableCarpet.SetActive(true);
        invisiableCarpet.transform.localScale = new Vector3(newXScale, invisiableCarpet.transform.localScale.y, invisiableCarpet.transform.localScale.z);
        pass = true;
    }
}
