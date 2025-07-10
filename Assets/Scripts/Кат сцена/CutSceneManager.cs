using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.SceneManagement;

public class CutSceneManager : MonoBehaviour
{
    public GameObject[] slides;
    public GameObject Perexod;
    [SerializeField] private NPCConversation CutSceneConversation;
    void Start()
    {
        Perexod.SetActive(false);
        slides[10].SetActive(false);
        slides[0].SetActive(true);
        //m1
        ConversationManager.Instance.StartConversation(CutSceneConversation);
    }
    public void M2()
    {
        slides[1].SetActive(true);
    }
    public void M3()
    {
        slides[2].SetActive(true);
    }
    public void M4()
    {
        slides[3].SetActive(true);
    }
    public void M5()
    {
        slides[4].SetActive(true);
    }
    public void M6()
    {
        slides[5].SetActive(true);
    }
    public void M7()
    {
        slides[6].SetActive(true);
    }
    public void M8()
    {
        slides[7].SetActive(true);
    }
    public void M9()
    {
        slides[8].SetActive(true);
    }
    public void M10()
    {
        slides[9].SetActive(true);
    }
    public void M11()
    {
        slides[10].SetActive(true);
        Invoke("MethodAfter", 38);
        Invoke("MethodAfter2",35);
    }
    public void MethodAfter()
    {
        SceneManager.LoadScene(8);
    }
    public void MethodAfter2()
    {
        Perexod.SetActive(true);
    }
}
