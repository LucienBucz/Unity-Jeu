using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jeu_Unity2._0;

public class ScriptConstruireValide : MonoBehaviour
{
    public GameObject ProdMP;
    public GameObject ProdFish;
    public GameObject Maison;

    public ScriptEnvironnement scriptEnvironnement;
    public Environment nv;

    public CloseButton cl;
    // Start is called before the first frame update
    void Start()
    {
        nv = scriptEnvironnement.GiveE();
        Debug.Log(nv);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BtContruire()
    {
        Debug.Log("on est dedans");

        if (ProdMP.activeSelf)
            nv.ConstructionAtelier();

        else if (ProdFish.activeSelf)
            nv.ConstructionCabane();

        else if (Maison.activeSelf)
            nv.ConstructionMaison();

        cl.Close();
    }
}
