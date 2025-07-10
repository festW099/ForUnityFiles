using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDoorButton : MonoBehaviour
{
    public GameObject OpenRightButton;
    public GameObject VhodButton;
    public bool objects;
    void Start()
    {
        OpenRightButton.SetActive(false);
        VhodButton.SetActive(false);
        objects = false;
    }
    public void OnButtonClick()
    {
        if (objects == false)
        {
            OpenRightButton.SetActive(true);
            VhodButton.SetActive(true);
            objects = true;
        }
        else if (objects == true)
        {
            OpenRightButton.SetActive(false);
            VhodButton.SetActive(false);
            objects = false;
        }
    }
}
