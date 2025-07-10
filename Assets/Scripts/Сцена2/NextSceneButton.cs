using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextSceneButton : MonoBehaviour
{
    public GameObject BlackImageNextScene;

    public void Click()
    {
        BlackImageNextScene.SetActive(true);
        Invoke("DeystviePotom", 2);
    } 
    void Start()
    {
        BlackImageNextScene.SetActive(false);
    }
    public void DeystviePotom()
    {
        SceneManager.LoadScene(2);
    }
}
