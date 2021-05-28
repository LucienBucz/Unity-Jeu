using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jeu_Unity2._0;
using UnityEngine.UI;

public class ScriptValeurBuild : MonoBehaviour
{
    public GameObject prodMP;
    public GameObject prodFish;
    public GameObject habitations;

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
        int prixConstruct = Environment.BANK_START * 60 / 100;

        if (prodMP.activeSelf)
        {
            if (nv.LAtelier.LvlBatiment >= 1)
                transform.gameObject.GetComponent<Text>().text = nv.LAtelier.PrixAmilioration.ToString();

            else if (nv.LAtelier.LvlBatiment == 0)
                transform.gameObject.GetComponent<Text>().text = prixConstruct.ToString();
        }

        else if (prodFish.activeSelf)
        {
            if (nv.LaCabane.LvlBatiment >= 1)
                transform.gameObject.GetComponent<Text>().text = nv.LaCabane.PrixAmilioration.ToString();

            else if (nv.LaCabane.LvlBatiment == 0)
                transform.gameObject.GetComponent<Text>().text = prixConstruct.ToString();
        }

        else if (habitations.activeSelf)
        {
            if (nv.LaMaison.LvlBatiment >= 1)
                transform.gameObject.GetComponent<Text>().text = nv.LaMaison.PrixAmilioration.ToString();

            else if (nv.LaMaison.LvlBatiment == 0)
                transform.gameObject.GetComponent<Text>().text = prixConstruct.ToString();
        }
    }

    /*public void Valeur()
    {
        int prixConstruct = Environment.BANK_START * 60 / 100;

        if (prodMP.activeSelf)
        {
            if (nv.LAtelier.LvlBatiment >= 1)
                transform.gameObject.GetComponent<Text>().text = nv.LAtelier.PrixAmilioration.ToString();

            else if (nv.LAtelier.LvlBatiment == 0)
                transform.gameObject.GetComponent<Text>().text = prixConstruct.ToString();
        }

        else if (prodFish.activeSelf)
        {
            if (nv.LaCabane.LvlBatiment >= 1)
                transform.gameObject.GetComponent<Text>().text = nv.LaCabane.PrixAmilioration.ToString();

            else if (nv.LaCabane.LvlBatiment == 0)
                transform.gameObject.GetComponent<Text>().text = prixConstruct.ToString();
        }

        else if (habitations.activeSelf)
        {
            if (nv.LaMaison.LvlBatiment >= 1)
                transform.gameObject.GetComponent<Text>().text = nv.LaMaison.PrixAmilioration.ToString();

            else if (nv.LaMaison.LvlBatiment == 0)
                transform.gameObject.GetComponent<Text>().text = prixConstruct.ToString();
        }
    }*/
}
