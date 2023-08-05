using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float playerSpeed = 5;
    
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 tempVector = (z * playerSpeed) * transform.forward;
        tempVector += (x * playerSpeed) * transform.right;
        tempVector.y = rb.velocity.y;
        rb.velocity = tempVector;
    }
}
