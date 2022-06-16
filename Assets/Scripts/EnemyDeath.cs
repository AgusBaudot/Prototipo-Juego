using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    //public Text Score;
    public string Stick;
    
    KillCounter KillCounterScript;

    // Start is called before the first frame update
    void Start()
    {
        KillCounterScript = GameObject.Find("KCO").GetComponent<KillCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        //Score.text = "Enemies killed: " + counter.ToString();
    }
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == Stick)
        {
            Debug.Log("Enemy died!");
            Destroy(gameObject);
            KillCounterScript.AddKill();
        }
    }
}
