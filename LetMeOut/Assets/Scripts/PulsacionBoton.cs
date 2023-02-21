using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulsacionBoton : MonoBehaviour
{
    private Animator anim;
    private bool Pulsado = false;
    GameObject Text;

    void Start()
    {
        anim = GetComponent<Animator>();
        Text = GameObject.FindWithTag("Victoria");
    }

    private void Update()
    {
        if (Pulsado == true)
        {
            Text.SetActive(true);
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.Play("Pulsacion");
            Pulsado = true;
        }
    }
}
