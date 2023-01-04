using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class zaman : MonoBehaviour
{
    int saniye = 0;

    public carpisma canlar;

    public GameObject panel;

    public GameObject kaybetti;

    public GameObject kazan;

    public Image cant;

    public GameObject engel1;

    public GameObject engel2;

    public TextMeshProUGUI sayac;
    // Start is called before the first frame update
    public void tekraroyna()
    {
        saniye = 0;
        Time.timeScale = 1.0f;
        canlar.canan = 1.0f;
        kaybetti.SetActive(false);
        kazan.SetActive(false);
        panel.SetActive(false);
        CancelInvoke("saya");
        InvokeRepeating("saya", 0.0f, 1.0f);
        Time.timeScale = 1.0f;
        cant.fillAmount = canlar.canan;

        engel1.transform.position = new Vector3(-8.9f,0.75f,-0.5f);
        engel2.transform.position = new Vector3(8.9f, 0.75f, -0.5f);

    }
    
    
    
    
    void Start()
    {
        InvokeRepeating("saya", 0.0f, 1.0f);    
    }

    // Update is called once per frame
    void Update()
    {
        if (canlar.canan < 0)
        {
            panel.SetActive(true);
            kaybetti.SetActive(true);
            Time.timeScale= 0.0f;

        }
        if (saniye == 60)
        {
            panel.SetActive(true);
            kazan.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }

    void saya()
    {
        saniye++;
        sayac.text = saniye.ToString();
        if (saniye == 60)
        {
            CancelInvoke("saya");
        }
    }
}
