using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vickluchatel : MonoBehaviour
{
    public Animator anim;
    // public Animator animTableText;
    public static int click;
    public bool svet;
    public GameObject LampaLight;
    public GameObject PanelWithTextLamp;
    public GameObject StartImage;

    void Start()
    {
        click = 1;
        anim = GetComponent<Animator>();
        svet = true; //свет включён
        LampaLight.SetActive(true);
        PanelWithTextLamp.SetActive(false);
        StartImage.SetActive(true);
        Invoke("d1", 1.5f);
    }
    public void d1()
    {
        Destroy(StartImage);
    }
    public void ClickOnButton()
    {
        click += 1;
        if ((click % 2) == 0 && click < 10)
        {
            anim.SetBool("Perehod", true);
            svet = false;//свет выключен
            LampaLight.SetActive(false);

        }
        if ((click % 2) == 1 && click < 10)
        {
            anim.SetBool("Perehod", false);
            svet = true; //свет включен
            LampaLight.SetActive(true);
        }
        if (click == 10)
        {
            anim.SetBool("Perehod", true);
            svet = false;//свет выключен - теперь уже навсегда
            LampaLight.SetActive(false);
            PanelWithTextLamp.SetActive(true);
        }
        if ((click % 2) == 0 && click > 10)
        {
            anim.SetBool("Perehod", true);
            svet = false;//свет выключен - теперь уже навсегда
            LampaLight.SetActive(false);
        }
        if ((click % 2) == 1 && click > 10)
        {
            anim.SetBool("Perehod", true);
            svet = false;//свет выключен - теперь уже навсегда
            LampaLight.SetActive(false);
        }
    }
}
