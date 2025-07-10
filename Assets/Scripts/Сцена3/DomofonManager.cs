using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DomofonManager : MonoBehaviour
{
    public GameObject forTextObj;
    public Text DomofonCode;
    public AudioSource SoundBtn1;
    public AudioSource SoundBtn2;
    public AudioSource SoundBtn3;
    public int randomNumber;
    public AudioSource SoundOpenDoor;
    public GameObject ImageBlackForNextScene;
    public void RandomSoundsForButtons()
    {
        randomNumber = Random.Range(1, 3);
        Debug.Log(randomNumber);
        if (randomNumber == 1)
        {
            SoundBtn1.Play();
        }
        else if (randomNumber == 2)
        {
            SoundBtn2.Play();
        }
        else if (randomNumber == 3)
        {
            SoundBtn3.Play();
        }
    }
    private void Start()
    {
        DomofonCode.text = "";
        ImageBlackForNextScene.SetActive(false);
    }
    public void btn1()
    {
        DomofonCode.text = DomofonCode.text + "1";
        Debug.Log("Написана цифра 1");
        RandomSoundsForButtons();
    }
    public void btn2()
    {
        DomofonCode.text = DomofonCode.text + "2";
        Debug.Log("Написана цифра 2");
        RandomSoundsForButtons();
    }
    public void btn3()
    {
        DomofonCode.text = DomofonCode.text + "3";
        Debug.Log("Написана цифра 3");
        RandomSoundsForButtons();
    }
    public void btn4()
    {
        DomofonCode.text = DomofonCode.text + "4";
        Debug.Log("Написана цифра 4");
        RandomSoundsForButtons();
    }
    public void btn5()
    {
        DomofonCode.text = DomofonCode.text + "5";
        Debug.Log("Написана цифра 5");
        RandomSoundsForButtons();
    }
    public void btn6()
    {
        DomofonCode.text = DomofonCode.text + "6";
        Debug.Log("Написана цифра 6");
        RandomSoundsForButtons();
    }
    public void btn7()
    {
        DomofonCode.text = DomofonCode.text + "7";
        Debug.Log("Написана цифра 7");
        RandomSoundsForButtons();
    }
    public void btn8()
    {
        DomofonCode.text = DomofonCode.text + "8";
        Debug.Log("Написана цифра 8");
        RandomSoundsForButtons();
    }
    public void btn9()
    {
        DomofonCode.text = DomofonCode.text + "9";
        Debug.Log("Написана цифра 9");
        RandomSoundsForButtons();
    }
    public void btn0()
    {
        DomofonCode.text = DomofonCode.text + "0";
        Debug.Log("Написана цифра 0");
        RandomSoundsForButtons();
    }
    public void btnSbros()
    {
        DomofonCode.text = "";
        RandomSoundsForButtons();
    }
    public void HasTagProverka()
    {
        if (DomofonCode.text == "2406")
        {
            Debug.Log("Это правильный код!");
            SoundOpenDoor.Play();
            ImageBlackForNextScene.SetActive(true);
            Invoke("DeystviePotom", 2);
            //Здесь будет звук открытия двери, инвок с затемнением экрана и загрузкой на слкдующую сцену
        }
        else if (DomofonCode.text != "2406")
        {
            Debug.Log("Это неправильный код");
            DomofonCode.text = "ERROR";
            Invoke("NoError", 2);
            //Здесь будет звук неправильного кода, будет стираться весь код, мигать код ERROR 2 секунды
        }
    }
    public void DeystviePotom()
    {
        SceneManager.LoadScene(3);
    }
    public void NoError()
    {
        DomofonCode.text = "";
    }
}
