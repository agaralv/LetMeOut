using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHelperUser : MonoBehaviour
{
    GameObject line;
    private void Start()
    {
        line = transform.GetChild(0).gameObject;
    }
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
            line.SetActive(true);
        else
            line.SetActive(false);
    }
}
