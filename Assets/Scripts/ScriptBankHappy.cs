using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Jeu_Unity2._0;

public class ScriptBankHappy : MonoBehaviour
{
    public Environment nv;
    public ScriptEnvironnement scriptEnvironnement;

    // Start is called before the first frame update
    void Start()
    {
        nv = scriptEnvironnement.GiveE();
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.gameObject.GetComponent<Text>().text = nv.BankHappy.ToString();
    }
}
