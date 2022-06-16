using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class KillCounter : MonoBehaviour
{
    public Text counterText;
    public Text comboText;
    public int kills;
    public string combo;
    public int killcombo;
    public int HighCombo;

    UsrMovement playerdied;
    bool Isdead;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        killcombo = 0;
        HighCombo = killcombo;
        playerdied = GameObject.Find("Player").GetComponent<UsrMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        ShowKills();
        Isdead = playerdied.Died;
        if (Isdead)
        {
            killcombo = 0;
        }
        if (killcombo<3 && killcombo >= 0)
        {
            combo = "F";
        } else if (killcombo<6 && killcombo > 3)
        {
            combo = "D";
        } else if (killcombo<9 && killcombo > 6)
        {
            combo = "C";
        } else if (killcombo<12 && killcombo > 9)
        {
            combo = "B";
        } else if  (killcombo<18 && killcombo > 12)
        {
            combo = "A";
        } else if (killcombo > 18)
        {
            combo = "SS";
        }
        if (killcombo > HighCombo)
        {
            HighCombo = killcombo;
        }
    }
    private void ShowKills()
    {
        counterText.text = "Enemies killed: " + kills.ToString();
        comboText.text = "Combo: " + combo;

    }
    public void AddKill()
    {
        kills++;
        killcombo++;
    }
}
