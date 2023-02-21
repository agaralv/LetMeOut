using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AperturaPuerta : MonoBehaviour
{
    private Animator anim;
    private bool PuertaAbierta = false;
    GameObject Light;

    void Start()
    {
        anim = GetComponent<Animator>();
        Light = GameObject.FindWithTag("Light");
    }

    private void Update()
    {
        if (PuertaAbierta == true)
        {
            Light.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            anim.Play("Puerta 0");
            PuertaAbierta = true;
        }
    }
}
