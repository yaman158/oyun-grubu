using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int hit;

    private Vector3 yon;
    
    // Start is called before the first frame update
    void Start()
    {
        yon = Vector3.right;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -9)
        {
            yon = Vector3.right;
        }
        if(transform.position.x > 9)
        {
            yon = Vector3.left;
        }
        transform.position += yon * Time.deltaTime * hit;
    }
}
