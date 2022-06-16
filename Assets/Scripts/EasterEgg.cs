using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg : MonoBehaviour
{
    public string player;
    public bool IsActivated = false;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        IsActivated = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == player)
        {
            IsActivated = true;
        }
    }
}
