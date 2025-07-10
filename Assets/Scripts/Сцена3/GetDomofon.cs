using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDomofon : MonoBehaviour
{
    public GameObject Domofon;
    private bool DomofonAndButtons;
    private void Start()
    {
        Domofon.SetActive(false);
        DomofonAndButtons = false;
    }
    public void Click()
    {
        if (DomofonAndButtons == false)
        {
            Domofon.SetActive(true);
            DomofonAndButtons = true;
        }
        else if (DomofonAndButtons == true)
        {
            Domofon.SetActive(false);
            DomofonAndButtons = false;
        }
    }
}
