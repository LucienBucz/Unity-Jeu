using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jeu_Unity2._0;

public class ScriptProdMP : MonoBehaviour
{
    public GameObject baseUi;
    public GameObject closeButton;
    public GameObject greenUpgradeButton;
    public GameObject greyUpgradeButton;
    public GameObject batimentText;
    public GameObject greenBuildButton;
    public GameObject greyBuildButton;
    public GameObject textConstru;
    public GameObject textAme;
    public GameObject textPrix;

    public Environment nv;
    public ScriptEnvironnement scriptEnvironnement;
    // Start is called before the first frame update
    void Start()
    {
        nv = scriptEnvironnement.GiveE();
        Debug.Log(nv.LAtelier);
        //nv.LAtelier.LvlBatiment = 1;
        nv.LAtelier.PrixUp();
       // nv.BankMp = 3;
        Debug.Log(nv.LAtelier.PrixAmilioration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        if (!baseUi.activeSelf)
        {
            baseUi.SetActive(true);

            if (!closeButton.activeSelf)
                closeButton.SetActive(true);

            if (!batimentText.activeSelf)
                batimentText.SetActive(true);

            if (!textPrix.activeSelf)
                textPrix.SetActive(true);

            if (nv.LAtelier.LvlBatiment > 0)
            {
                if (!textAme.activeSelf)
                    textAme.SetActive(true);

                if (!greenUpgradeButton.activeSelf && nv.EstAmeliorableAtelier())
                    greenUpgradeButton.SetActive(true);

                else if (!greyUpgradeButton.activeSelf && !nv.EstAmeliorableAtelier())
                    greyUpgradeButton.SetActive(true);
            }

            else if (nv.LAtelier.LvlBatiment == 0)
            {
                if (!textConstru.activeSelf)
                    textConstru.SetActive(true);

                if (!greenBuildButton.activeSelf && nv.ConstructibleTier1())
                {
                    greenBuildButton.SetActive(true);
                }

                else if (!greyBuildButton.activeSelf && !nv.ConstructibleTier1())
                    greyBuildButton.SetActive(true);
            }
        } 
    }
}
