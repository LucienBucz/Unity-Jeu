using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jeu_Unity2._0;


public class ScriptMairie : MonoBehaviour
{
    public GameObject baseUi;
    public GameObject closeButton;
    public GameObject greenUpgradeButton;
    public GameObject greyUpgradeButton;
    public GameObject batimentText;

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

            /*if (!greenUpgradeButton.activeSelf /*&& batiment améliorable/)
                greenUpgradeButton.SetActive(true);

            else if (!greyUpgradeButton.activeSelf)
                greyUpgradeButton.SetActive(true);*/
        }
    }
}
