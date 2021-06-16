using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Hola soy un mensaje");
        // Debug.LogWarning("Me estoy acercando al final");
        // Debug.LogError("HAY UN ERROR");

        for (int i = 0; i < 10; i++)
        {
            Debug.LogFormat($"<color=blue> {i} </color>");
        }
    }


}
