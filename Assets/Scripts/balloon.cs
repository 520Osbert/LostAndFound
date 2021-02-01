using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour
{
    public GameObject aniObj;

    private Animator anim;

    private void Awake()
    {
        anim = aniObj.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetInteger("baby_up", 1);
    }
}
