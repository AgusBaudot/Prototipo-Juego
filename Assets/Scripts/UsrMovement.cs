using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsrMovement : MonoBehaviour
{
    public float Speed = 0.1f;
    public float rotationSpeed = 3;

    public string enemies;

    Rigidbody RB;
    public float jumpForce;
    public float jumpAmount;
    float currJumps;

    //SpawnPoints
    //Conseguir la posicion original del player en el start, cada vez que muere teletransportarlo hacia la posicion original
    private Transform InitialPos;
    private UsrMovement script;
    // Start is called before the first frame update
    void Start()
    {
        InitialPos = gameObject.transform.position;
        currJumps = jumpAmount;
        RB = GetComponent<Rigidbody>();
        script = GetComponent<UsrMovement>();
        script.enabled = true;
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
            Instantiate(gameObject, new Vector3(0, 0.5f, 0), Quaternion.identity);
            script.enabled = true;
            Destroy(gameObject);
        }
        currJumps = jumpAmount;
    }
}
