using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributesExample : MonoBehaviour
{

    [Space]
    [Header("numbers")]
    public int score;
    [SerializeField]
    private int money;

    [Space]
    [Header("Other values")]
    [SerializeField]
    private string password;
    [HideInInspector]
    public int numbersRand;

    [Space]
    [Header("Slides")]
    [Range(0,5)]
    public int lifes;
    [SerializeField]
    [Min(0)]
    private int numberRan;

    [Space]
    [Header("Texts")]
    public string name;
    [TextArea]
    public string dialogue;

    [Header("Tools")]
    [Tooltip("Esta es la id del jugador, cambiar con cuidad")]
    [SerializeField]
    private string id;

    [ContextMenu("Call Function")]
    public void Myfunction()
    {
        Debug.Log("MyFunction fue ejecutada");
    }

    public Player player;

}

[System.Serializable]
public class Player
{
    public int idPlayer;
    public string namePlayer;
}
