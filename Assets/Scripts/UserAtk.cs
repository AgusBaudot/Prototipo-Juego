using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserAtk : MonoBehaviour
{
    public GameObject Weapon;
    private float CDAtk;
    private float NextAtk;

    private float CDVanish;
    private float TotalCDVanish = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        Weapon.SetActive(false);
        CDAtk = 1;
        NextAtk = 0;
        CDVanish = TotalCDVanish;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Weapon.activeSelf == false && NextAtk <= Time.time)
            {
                Attack();
            } else if (Weapon.activeSelf == true || NextAtk > Time.time)
            {
                Debug.Log("CD is active, wait!");
            }
        }
        if (CDVanish <= Time.time)
        {
            Weapon.SetActive(false);
            NextAtk = CDAtk + Time.time;
        }
    }
    void Attack ()
    {
        Weapon.SetActive(true);
        CDVanish = Time.time + TotalCDVanish;
    }

}

/*
if (Input.GetKeyDown(KeyCode.E))
        {
            if (Weapon.activeSelf)
            {
                CDVanish -= Time.deltaTime;
                if (CDVanish <= 0)
                {
                    Weapon.SetActive(false);
                    CDVanish = TotalCDVanish;
                }
            }
        }
        if (!Weapon.activeSelf)
        {
            CD -= Time.deltaTime;
        }
if(NextAtk <= Time.time)
        {
            if (!Weapon.activeSelf)
            {
                Weapon.SetActive(true);
                //pasan unos segundos.
                //se desactiva.
            }
            else
            {
                NextAtk = CD + Time.time;
                Debug.Log("Attack used, Cooldown started");
                Weapon.SetActive(false);
            }
        }
        else
        {
            Debug.Log("CD didn't finish");
        }
*/