using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    public Transform SpawnPoint;

    //Tengo que crear un array con los posibles spawns.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private void OnCollisionEnter(Collision col)
    {
        int n = Random.Range(0, positions.Length);
        Instantiate(Enemy, positions[n].transform.position, positions[n].transform.rotation);
    }*/
}
