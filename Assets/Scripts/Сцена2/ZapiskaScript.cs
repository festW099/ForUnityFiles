using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZapiskaScript : MonoBehaviour
{
    public GameObject page;
    private bool pageOn;
    private void Start()
    {
        pageOn = false;
    }

    public void PushTheButton()
    {
        if (pageOn == false)
        {
            pageOn = true;
            page.SetActive(true);
        }
        else if (pageOn == true)
        {
            pageOn = false;
            page.SetActive(false);
        }
    }
}
