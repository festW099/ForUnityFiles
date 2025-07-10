using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TrNsc : MonoBehaviour
{
    public GameObject BlackImage;
    void Start()
    {
        BlackImage.SetActive(false);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        BlackImage.SetActive(true);
        Invoke("d1", 2);
    }
    public void d1()
    {
        SceneManager.LoadScene(6);
    }
}
