using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainDoorNextScene : MonoBehaviour
{
    public GameObject ImageEnd;

    public void Start()
    {
        ImageEnd.SetActive(false);
    }
    public void OnClickButton()
    {
        ImageEnd.SetActive(true);
        Invoke("d1", 2);
    }
    public void d1()
    {
        SceneManager.LoadScene(5);       
    }
}
