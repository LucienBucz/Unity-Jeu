using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jeu_Unity2._0;

public class ScriptAmeliorerValide : MonoBehaviour
{
    public GameObject Mairie;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BtAmeliorer()
    {
        if (ProdMP.activeSelf)
        {
            nv.BankMp -= nv.LAtelier.MonterDeNiveau();
            nv.LAtelier.PrixUp();

        }
        else if (ProdFish.activeSelf)
        {

            nv.BankMp -= nv.LaCabane.MonterDeNiveau();
            nv.LaCabane.PrixUp();
        }
        else if (Maison.activeSelf)
        {
            nv.BankMp -= nv.LaMaison.MonterDeNiveau();
            nv.LaMaison.PrixUp();
        }
        Debug.Log(nv);
        Debug.Log(nv.DétailBatiment());

        cl.Close();
    }
}
