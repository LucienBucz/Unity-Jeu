using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public GameObject baseUi;

    public GameObject closeButton;
    public GameObject greenUpgradeButton;
    public GameObject greyUpgradeButton;
    public GameObject greenBuildButton;
    public GameObject greyBuildButton;

    public GameObject mairieText;
    public GameObject marcheText;
    public GameObject prodFishText;
    public GameObject prodMPText;
    public GameObject cimeteryText;
    public GameObject amphiText;
    public GameObject hostoText;
    public GameObject habitationsText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Clic()
    {


        if (baseUi.activeSelf)
            baseUi.SetActive(false);

        if (closeButton.activeSelf)
            closeButton.SetActive(false);

        if (greenUpgradeButton.activeSelf)
            greenUpgradeButton.SetActive(false);

        if (greyUpgradeButton.activeSelf)
            greyUpgradeButton.SetActive(false);

        if (greenBuildButton.activeSelf)
            greenBuildButton.SetActive(false);

        if (greyBuildButton.activeSelf)
            greyBuildButton.SetActive(false);

        if (mairieText.activeSelf)
            mairieText.SetActive(false);

        if (marcheText.activeSelf)
            marcheText.SetActive(false);

        if (prodFishText.activeSelf)
            prodFishText.SetActive(false);

        if (prodMPText.activeSelf)
            prodMPText.SetActive(false);

        if (cimeteryText.activeSelf)
            cimeteryText.SetActive(false);

        if (amphiText.activeSelf)
            amphiText.SetActive(false);

        if (hostoText.activeSelf)
            hostoText.SetActive(false);

        if (habitationsText.activeSelf)
            habitationsText.SetActive(false);
    }
       
}
