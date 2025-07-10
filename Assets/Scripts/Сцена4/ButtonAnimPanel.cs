using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimPanel : MonoBehaviour
{
    public Animator Panel;
    public void Click()
    {
        Panel.SetBool("boolAnim", true);
    }
}
