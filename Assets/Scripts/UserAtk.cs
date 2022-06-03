using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserAtk : MonoBehaviour
{
    public GameObject Weapon;
    private float CD;

    // Start is called before the first frame update
    void Start()
    {
        Weapon.SetActive(false);
        CD = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && CD <= 0)
        {
            Weapon.SetActive(true);
            
        }
    }

}
