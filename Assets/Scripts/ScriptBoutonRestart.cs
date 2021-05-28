using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jeu_Unity2._0;
using UnityEngine.SceneManagement;

public class ScriptBoutonRestart : MonoBehaviour
{
    public ScriptEnvironnement scriptEnvironnement;
    public Environment nv;

    public CloseButton cl;
    // Start is called before the first frame update
    void Start()
    {
        nv = scriptEnvironnement.GiveE();
        nv.LaCabane.LvlBatiment++;
        Debug.Log(nv);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
