using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserAtk : MonoBehaviour
{
    public GameObject Weapon;
    private float CDAtk;
    private float NextAtk;

    private bool CanAtk = true;

    private float CDVanish;
    private float TotalCDVanish = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        Weapon.SetActive(false);
        CDAtk = 1;
        CDVanish = TotalCDVanish;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Weapon.activeSelf == false && CanAtk == true)
            {
                Attack();
            } else if (Weapon.activeSelf == true || CanAtk == false)
            {
                Debug.Log("CD is active, wait!");
            }
        }
        if (CDVanish <= 0)
        {
            if (Weapon.activeSelf == true)
            {
            Weapon.SetActive(false);
            NextAtk = 0;
            NextAtk = CDAtk;
            CanAtk = false;
            Debug.Log("Attack used, CD started");
            }
            NextAtk -= Time.deltaTime;
        }
        if (CDVanish > 0)
        {
            CDVanish -= Time.deltaTime;
        }
        if (NextAtk <= 0)
        {
            CanAtk = true;
        }
    }
    void Attack ()
    {
        Weapon.SetActive(true);
        CDVanish = 0;
        CDVanish = TotalCDVanish;
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