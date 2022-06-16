using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EndSceneValues : MonoBehaviour
{

    KillCounter KillAmount;
    public Text AmountofKills;
    int counter;

    // Start is called before the first frame update
    void Start()
    {
        KillAmount = GameObject.Find("KCO").GetComponent<KillCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        counter = KillAmount.kills;
        AmountofKills.text = "Enemies killed: " + counter.ToString();
    }
}
