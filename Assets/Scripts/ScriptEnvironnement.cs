using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jeu_Unity2._0;

public class ScriptEnvironnement : MonoBehaviour
{
    public Cabane cabane;
    public Atelier atelier;
    public Maison maison;
    public Hdv hdv;
    public Environment e;
    public Environment stockE;

    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log("env");
        Cabane cabane = new Cabane();
        Atelier atelier = new Atelier();
        Maison maison = new Maison();
        Hdv hdv = new Hdv();
        Environment e = new Environment(cabane, atelier, hdv, maison);
        Debug.Log(e);
        stockE = e;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Environment GiveE() 
    {
        return stockE;
    }
}
