using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confetti : MonoBehaviour
{

    public GameObject sphere;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i<= 10; i++)
        {
            Instantiate(sphere);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        
    }
}
