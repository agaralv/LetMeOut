using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulsacionBoton : MonoBehaviour
{
    private Animator anim;
    private GameObject Panel;

    void Start()
    {
        anim = GetComponent<Animator>();
        Panel = GameObject.FindWithTag("Victoria");
        Panel.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.Play("Pulsacion");
            Panel.SetActive(true);
        }
    }
}
