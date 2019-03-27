using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public GameObject target;
    public Rigidbody2D rigidBody;
    public float rotatingSpeed;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += movementSpeed * Time.deltaTime;
        transform.position = pos;
    }
}
