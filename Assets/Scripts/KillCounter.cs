using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class KillCounter : MonoBehaviour
{
    public Text counterText;
    public int kills;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowKills();
    }
    private void ShowKills()
    {
        counterText.text = "Enemies killed: " + kills.ToString();
    }
    public void AddKill()
    {
        kills++;
    }
}
