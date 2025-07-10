
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCloseWindow : MonoBehaviour
{
    public GameObject OpenWindow;
    public GameObject CloseWindow;
    private bool OpenWindowTriggerTrue;
    public GameObject OtmichkaPredmet;
    public GameObject KnopkaKlick;
    public AudioSource OtchSound;
    private bool Kasanie; //отвечает за нахождение игрока в зоне триггера и касание отмычки окна
    private void OnTriggerEnter2D(Collider2D other)
    {
        // KnopkaKlick.SetActive(true);
        if(other.CompareTag("Otmichka"))
        {
            GameObject[]  objectsWithTagOtmichka = GameObject.FindGameObjectsWithTag("Otmichka");

            foreach (GameObject obj in objectsWithTagOtmichka)
            {
                Destroy(obj);
            }
            OpenWindowTriggerTrue = true;
            Debug.Log("Объект с тегом отмычка коснулся триггера, должно появиться открытое окно!!!");
            Destroy(OtmichkaPredmet);            // Kasanie = true;
            Kasanie = true;           
        }
    }
    private void Update() 
    {
        if (OpenWindowTriggerTrue)
        {
            OpenWindow.SetActive(true);
            CloseWindow.SetActive(false);
            OtchSound.Play();
        }
        if(Kasanie)
        {
            KnopkaKlick.SetActive(true);
        }   
    }
    private void Start()
    {
        KnopkaKlick.SetActive(false);
        OpenWindow.SetActive(false);
        Kasanie = false;
    }
}
