using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptProdFish : MonoBehaviour
{
    public GameObject baseUi;
    public GameObject closeButton;
    public GameObject greenUpgradeButton;
    public GameObject greyUpgradeButton;
    public GameObject greenBuildButton;
    public GameObject greyBuildButton;
    public GameObject batimentText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseUp()
    {
        if (!baseUi.activeSelf)
            baseUi.SetActive(true);

        if (!closeButton.activeSelf)
            closeButton.SetActive(true);

        if (!batimentText.activeSelf)
            batimentText.SetActive(true);

        if (!greenUpgradeButton.activeSelf /*&& batiment améliorable*/)
            greenUpgradeButton.SetActive(true);

        else if (!greyUpgradeButton.activeSelf /*&& batiment construit*/)
            greyUpgradeButton.SetActive(true);

        else if (!greenBuildButton.activeSelf /*&&batiment constructible*/)
            greenBuildButton.SetActive(true);

        else if (!greyBuildButton.activeSelf)
            greyBuildButton.SetActive(true);

    }
}
