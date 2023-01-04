using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class carpisma2 : MonoBehaviour
{

    public Image cana;
    public carpisma canana;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "karakter")
        {
            canana.canan = canana.canan - 0.34f;
            cana.fillAmount = canana.canan;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
 
}