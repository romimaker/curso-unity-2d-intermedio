using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    delegate void SimpleMessage();
    SimpleMessage simpleMessage;

    private void Start()
    {
        simpleMessage += SendConsoleMessage;
        simpleMessage?.Invoke();
    }

    private void SendConsoleMessage()
    {
        Debug.Log("Mensaje Enviado a consola");
    }
}
