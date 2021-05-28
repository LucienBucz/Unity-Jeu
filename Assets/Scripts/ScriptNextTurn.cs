using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jeu_Unity2._0;

public class ScriptNextTurn : MonoBehaviour
{
    public GameObject baseInterface;
    public GameObject winPanel;
    public GameObject losePanel;
    public GameObject restartButton;

    public ScriptEnvironnement scriptEnvironnement;
    public Environment nv;
    // Start is called before the first frame update
    void Start()
    {
        nv = scriptEnvironnement.GiveE();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextTurn()
    {
        Debug.Log("yolo");
        nv.EndTurn();
        Debug.Log(nv);

        if (nv.Lose)
        {
            if (!baseInterface.activeSelf)
                baseInterface.SetActive(true);

            if (!losePanel.activeSelf)
                losePanel.SetActive(true);

            if (!restartButton.activeSelf)
                restartButton.SetActive(true);
        }

        else if (nv.Win)
        {
            if (!baseInterface.activeSelf)
                baseInterface.SetActive(true);

            if (!winPanel.activeSelf)
                winPanel.SetActive(true);

            if (!restartButton.activeSelf)
                restartButton.SetActive(true);
        }
    }


}
