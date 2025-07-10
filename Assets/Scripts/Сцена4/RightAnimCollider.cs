using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightAnimCollider : MonoBehaviour
{
    public Animator animButton;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (Vickluchatel.click >= 10)
        {
            animButton.SetBool("bool", true);
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (Vickluchatel.click >= 10)
        {
            animButton.SetBool("bool", false);
        }
    }
}
