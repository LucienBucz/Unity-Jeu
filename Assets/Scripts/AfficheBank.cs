using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jeu_Unity2._0;

public class AfficheBank : MonoBehaviour
{
    public ScriptEnvironnement scriptEnvironnement;

    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log("Je suis bank");
        Environment nv = scriptEnvironnement.GiveE();
        Debug.Log(nv);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
