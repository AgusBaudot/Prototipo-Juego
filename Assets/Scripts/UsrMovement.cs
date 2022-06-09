using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsrMovement : MonoBehaviour
{
    //Speed of movement
    public float Speed = 0.1f;
    public float rotationSpeed = 3;

    //Health bar
    public int HP = 3;

    //Enemy tag
    public string enemies;

    //Jumps
    Rigidbody RB;
    public float jumpForce;
    public float jumpAmount;
    float currJumps;

    //SpawnPoints
    private Vector3 InitialPos;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        InitialPos = player.transform.position;
        //InitialPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        currJumps = jumpAmount;
        RB = GetComponent<Rigidbody>();
        Debug.Log("Current health:" + HP);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, Speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -Speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && currJumps > 0)
        {
            RB.velocity = new Vector3(RB.velocity.x, 0, RB.velocity.z);
            RB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            currJumps--;
        }
    }
    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == enemies)
        {
            if (HP > 1)
            {
            transform.position = InitialPos;
            HP--;
            Debug.Log("Life lost! Current health:" + HP);
            }
            else
            {
                Debug.Log("You Died");
                Destroy(gameObject);
            }
        }
        currJumps = jumpAmount;
    }
}
