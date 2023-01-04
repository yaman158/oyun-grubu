using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karehrkt : MonoBehaviour
{

    public bool isGrounded;

    public Rigidbody rb;

    public int ziplama;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("platform"))
        {
            isGrounded= true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.CompareTag("platform"))
        {
            isGrounded = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            if (isGrounded == true)
            {
                rb.AddForce(new Vector3(0f, ziplama, 0f), ForceMode.Impulse);
            }
        }
    }
}
