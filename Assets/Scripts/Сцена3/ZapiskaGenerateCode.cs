using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ZapiskaGenerateCode : MonoBehaviour
{
    public Animator forButtonZapiska;
    public static Text RandText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        forButtonZapiska.SetBool("StartOpen", true);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        forButtonZapiska.SetBool("StartOpen", false);
    }
}
