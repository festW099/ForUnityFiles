using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerTumbaForButtons : MonoBehaviour
{
    public Animator ForLightAnim;
    public Animator ForPageAnim;
    public GameObject BlackImageToScene;
    private void Start()
    {
        BlackImageToScene.SetActive(true);
        Invoke("DeystviePotom", 2);
    }
    public void DeystviePotom()
    {
        Destroy(BlackImageToScene);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Кнопки должны появиться!!!");
        ForLightAnim.SetBool("StartOpen", true);
        ForPageAnim.SetBool("StartOpen", true);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Кнопки должны исчезунть!!!");
        ForLightAnim.SetBool("StartOpen", false);
        ForPageAnim.SetBool("StartOpen", false);
    }
}
