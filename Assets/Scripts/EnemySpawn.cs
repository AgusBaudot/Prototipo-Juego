using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    public Transform[] SpawnPoint;
    private float NextSpawn;
    public float CDSpawn = 2f;

    // Start is called before the first frame update
    void Start()
    {
        NextSpawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (NextSpawn <= Time.time)
        {
            int n = Random.Range(0, SpawnPoint.Length);
            Instantiate(Enemy, SpawnPoint[n].transform.position, SpawnPoint[n].transform.rotation);
            NextSpawn = Time.time + CDSpawn;
        }
    }
}
