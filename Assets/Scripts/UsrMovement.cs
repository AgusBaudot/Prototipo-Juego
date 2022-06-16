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

    // UI
    public Transform life1;
    public Transform life2;
    public Transform life3;

    private SpriteRenderer life1vis;
    private SpriteRenderer life2vis;
    private SpriteRenderer life3vis;

    //Black Out
    public GameObject Blackout;

    public bool Died = false;
    // Start is called before the first frame update
    void Start()
    {
        InitialPos = player.transform.position;
        //InitialPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        currJumps = jumpAmount;
        RB = GetComponent<Rigidbody>();
        Debug.Log("Current health:" + HP);
        life1vis = life1.GetComponent<SpriteRenderer>();
        life2vis = life2.GetComponent<SpriteRenderer>();
        life3vis = life3.GetComponent<SpriteRenderer>();
        Blackout.SetActive(false);
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
        if (HP == 3)
        {
            life1vis.enabled = true;
            life2vis.enabled = true;
            life3vis.enabled = true;
        }
        if (HP == 2)
        {
            life1vis.enabled = true;
            life2vis.enabled = true;
            life3vis.enabled = false;
        }
        if (HP == 1)
        {
            life1vis.enabled = true;
            life2vis.enabled = false;
            life3vis.enabled = false;
        }
        if (HP == 0)
        {
            life1vis.enabled = false;
            life2vis.enabled = false;
            life3vis.enabled = false;
        }
        if (Died)
        {
            Debug.Log("Died is true");
        }
    }
    void FixedUpdate()
    {
        Died = false;
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
                Died = true;
            }
            else
            {
                Debug.Log("You Died");
                Blackout.SetActive(true);
                Destroy(gameObject);
            }
        }
        currJumps = jumpAmount;
    }
}
