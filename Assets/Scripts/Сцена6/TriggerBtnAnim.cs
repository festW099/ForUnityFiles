using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBtnAnim : MonoBehaviour
{
    public Animator animBtn;
    public GameObject colliderDialogue;
    public static bool dialogue = false;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && dialogue == true)
        {
            animBtn.SetBool("StartOpen", true);
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        animBtn.SetBool("StartOpen", false);
    }
    public void RemoveCollider()
    {
        Destroy(colliderDialogue);
    }
    public void dialogueTrue()
    {
        dialogue = true;
    }
}
