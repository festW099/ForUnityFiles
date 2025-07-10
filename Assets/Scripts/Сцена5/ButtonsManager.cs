using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsManager : MonoBehaviour
{
    public GameObject ImageStart;
    public GameObject ImageEnd;
    void Start()
    {
        ImageStart.SetActive(true);
        Invoke("d2", 1.5f);
        ImageEnd.SetActive(false);
    }
    public void BackToMenu()
    {
        ImageEnd.SetActive(true);
        Invoke("d1", 2);
    }
    public void BackToGame()
    {
        ImageEnd.SetActive(true);
        Invoke("d3",2);
    }
    public void d2()
    {
        Destroy(ImageStart);
    }
    public void d1()
    {
        SceneManager.LoadScene(0);
    }
    public void d3()
    {
        SceneManager.LoadScene(3);
    }
}
