using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoorButton : MonoBehaviour
{
    public GameObject OpenMainDoor;
    public GameObject VhodButton;
    public bool objects;
    void Start()
    {
        OpenMainDoor.SetActive(false);
        VhodButton.SetActive(false);
        objects = false;
    }
    public void OnButtonClick()
    {
        if (objects == false)
        {
            OpenMainDoor.SetActive(true);
            VhodButton.SetActive(true);
            objects = true;
        }
        else if (objects == true)
        {
            OpenMainDoor.SetActive(false);
            VhodButton.SetActive(false);
            objects = false;
        }
    }
}
