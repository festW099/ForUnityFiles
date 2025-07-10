using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LRvhodButton : MonoBehaviour
{
    public GameObject ImageEnd;
    void Start()
    {
        ImageEnd.SetActive(false);
    }
    public void ClickOnButton()
    {
        ImageEnd.SetActive(true);
        Invoke("d1", 2);
    }
    public void d1()
    {
        SceneManager.LoadScene(4);
    }
}
