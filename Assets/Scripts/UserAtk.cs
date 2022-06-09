using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserAtk : MonoBehaviour
{
    public GameObject Weapon;
    private float CD;
    private float NextAtk;
    // Start is called before the first frame update
    void Start()
    {
        Weapon.SetActive(false);
        CD = 1;
        NextAtk = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (NextAtk < Time.time)
            {
                if (Weapon.activeSelf == false)
                {
                    Weapon.SetActive(true);
                }
                else
                {
                    Weapon.SetActive(false);
                    NextAtk = CD + Time.time;
                    Debug.Log("Attack used, Cooldown started");
                }
            
            }
            else
            {
                Debug.Log("CD didn't finish");
            }
        }
    }

}
