using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.SceneManagement;
public class TriggerGrannyNPC : MonoBehaviour
{
    [SerializeField] private NPCConversation GrannyConversation;
    public Animator btnAnim;
    public Animator btnAnim2;
    public Animator TeapotAnim;
    public static bool TwoButton = false;
    public GameObject ForButtonOne;
    public GameObject Perexod;
    public GameObject ButtonChaynik;
    public void Start()
    {
        Perexod.SetActive(false);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && TwoButton == false)
        {
            btnAnim.SetBool("StartOpen", true);
        }
        else if (other.CompareTag("Player") && TwoButton == true)
        {
            btnAnim2.SetBool("StartOpen", true);
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && TwoButton == false)
        {
            btnAnim.SetBool("StartOpen", false);
        }
        else if (other.CompareTag("Player") && TwoButton == true)
        {
            btnAnim2.SetBool("StartOpen", false);
        }
    }
    public void DialogueStart()
    {
        ConversationManager.Instance.StartConversation(GrannyConversation);
        btnAnim.SetBool("StartOpen", true);
    }
    public void TwoButtonStart()
    {
        TwoButton = true;
    }
    public void TeapotButton()
    {
        TeapotAnim.SetBool("StartOpen", true);
        Destroy(ForButtonOne);
        Destroy(ButtonChaynik);
    }
    public void NextSCene()
    {
        Debug.Log("АЙМНОТГОННАКРЕК");
        Perexod.SetActive(true);
        Invoke("d1", 2);
    }
    public void d1()
    {
        SceneManager.LoadScene(7);
    }
}
