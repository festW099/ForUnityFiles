using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetZapiskaText : MonoBehaviour
{
    public GameObject Page;
    public GameObject Text;
    private bool PageAndText;
    private void Start()
    {
        PageAndText = false;
        Page.SetActive(false);
        Text.SetActive(false);
    }
    public void Click()
    {
        if (PageAndText == false)
        {
            PageAndText = true;
            Page.SetActive(true);
            Text.SetActive(true);
        }
        else if (PageAndText == true)
        {
            PageAndText = false;
            Page.SetActive(false);
            Text.SetActive(false);
            
        }
    }
}
