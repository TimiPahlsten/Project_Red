using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour
{
    Rigidbody rb;
    public float m_Thrust = 5f;

    public bool rightPressed;
    public bool leftPressed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && rightPressed)
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            rb.AddForce(-transform.right * m_Thrust);
            leftPressed = true;
            rightPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.D) && leftPressed)
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            rb.AddForce(transform.right * m_Thrust);
            rightPressed = true;
            leftPressed = false;
        }
    }
}
