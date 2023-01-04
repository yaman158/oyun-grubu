using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class carpisma : MonoBehaviour
{

    public Image can;
    public float canan= 1.0f;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "karakter")
        {
            canan = canan - 0.34f;
            can.fillAmount = canan;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
