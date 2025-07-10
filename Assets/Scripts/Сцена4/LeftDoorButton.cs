using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LeftDoorButton : MonoBehaviour
{
    public GameObject OpenLeftDoor;
    public GameObject VhodButton;
    public bool objects;
    void Start()
    {
        OpenLeftDoor.SetActive(false);
        VhodButton.SetActive(false);
        objects = false;
    }
    public void OnButtonClick()
    {
        if (objects == false)
        {
            OpenLeftDoor.SetActive(true);
            VhodButton.SetActive(true);
            objects = true;
        }
        else if (objects == true)
        {
            OpenLeftDoor.SetActive(false);
            VhodButton.SetActive(false);
            objects = false;
        }
    }
}
