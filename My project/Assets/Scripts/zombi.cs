using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombi : MonoBehaviour
{

    public Animator anim;
    public int hiz;
    private Vector3 yon;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
               // transform.position = new Vector3(transform.position.x,2,transform.position.z);
                anim.SetBool("ziplama", true);
            }
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                anim.SetBool("ziplama", false);
            }
        
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("kosma", true);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("kosma", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetBool("kosma", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetBool("kosma", false);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0f, 270f, 0f);
            yon = Vector3.left;
            transform.position += yon * Time.deltaTime * hiz;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            yon = Vector3.right;
            transform.position += yon * Time.deltaTime * hiz;
        }

    }
}
