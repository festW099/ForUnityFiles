using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampaScript : MonoBehaviour
{
    public GameObject Light;
    private bool LightOn;
    private void Start()
    {
        LightOn = false;
    }
    public void Click()
    {
        if (LightOn == false)
        {
            LightOn = true;
            Light.SetActive(true);
        }
        else if (LightOn == true)
        {
            LightOn = false;
            Light.SetActive(false);
        }
    }
}
