using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceBatiments : MonoBehaviour
{

    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Toggle();
    }

    void Toggle()
    {
        ui.SetActive(!ui.activeSelf);
    }
}
