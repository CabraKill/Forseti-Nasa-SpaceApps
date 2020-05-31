using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaseCounter : MonoBehaviour
{
    public int susceptible;
    public int infected;
    public int cured;
    public int deaths;

    Text text;


    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Susceptible: " + susceptible.ToString() + "\nInfected: " + infected.ToString() + "\nCured: " + cured.ToString() + "\nDeaths: " + deaths.ToString();
    }


}
