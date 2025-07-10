using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKnopkaDomofon : MonoBehaviour
{
    public GameObject ImageOnPerehodScene;
    public Animator ForDomofonButton;
    void OnTriggerEnter2D(Collider2D other)
    {
        ForDomofonButton.SetBool("StartOpen", true);
    }
    void OnTriggerExit2D(Collider2D other)
    {
        ForDomofonButton.SetBool("StartOpen", false);
    }
    void Start()
    {
        ImageOnPerehodScene.SetActive(true);
        Invoke("D2", 2);
    }
    public void D2()
    {
        Destroy(ImageOnPerehodScene);
    }
}
