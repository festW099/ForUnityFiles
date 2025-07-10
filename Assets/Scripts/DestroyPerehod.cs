using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DestroyPerehod : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(true);
        Destroy(gameObject, 1.5f);   
        Debug.Log($"Объект удалён");
    }
}
