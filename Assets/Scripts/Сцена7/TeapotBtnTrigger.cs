using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeapotBtnTrigger : MonoBehaviour
{
    public Animator animBtnTeapot;
    [SerializeField] public static bool Teapot = false;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Teapot == true)
        {
            animBtnTeapot.SetBool("StartOpen", true);
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Teapot == true)
        {
            animBtnTeapot.SetBool("StartOpen", false);
        }
    }
    public void TeapotStart()
    {
        Teapot = true;
    }
}