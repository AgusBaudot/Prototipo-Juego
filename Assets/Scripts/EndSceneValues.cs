using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EndSceneValues : MonoBehaviour
{
    //Kills
    KillCounter KillAmount;
    public Text AmountofKills;
    int counter;

    //Easter Egg
    EasterEgg easteregg;
    bool Eggtrue;
    public Text EasterActivated;

    //Combo
    string combo;
    public Text MaxCombo;
    int highcombo;

    //public GameObject confetti;

    // Start is called before the first frame update
    void Start()
    {
        KillAmount = GameObject.Find("KCO").GetComponent<KillCounter>();
        easteregg = GameObject.Find("Piso invisible").GetComponent<EasterEgg>();
        /*if (Eggtrue)
        {
            while (counter <= 10)
            {
                Instantiate(confetti, new Vector3(0, 0.5f, 0), Quaternion.identity);
                counter++;
            }
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        counter = KillAmount.kills;
        AmountofKills.text = "Enemies killed: " + counter.ToString();
        MaxCombo.text = "Highest combo: " + combo;
        Eggtrue = easteregg.IsActivated;
        highcombo = KillAmount.HighCombo;
        
        if (Eggtrue == true)
        {
            EasterActivated.text = "You found easter egg! Confetti!";
        }
        if (Eggtrue == false)
        {
            EasterActivated.text = "??? not found";
        }
        if (highcombo < 3 && highcombo >= 0)
        {
            combo = "F";
        }
        else if (highcombo < 6 && highcombo > 3)
        {
            combo = "D";
        }
        else if (highcombo < 9 && highcombo > 6)
        {
            combo = "C";
        }
        else if (highcombo < 12 && highcombo > 9)
        {
            combo = "B";
        }
        else if (highcombo < 18 && highcombo > 12)
        {
            combo = "A";
        }
        else if (highcombo > 18)
        {
            combo = "SS";
        }

    }
}
