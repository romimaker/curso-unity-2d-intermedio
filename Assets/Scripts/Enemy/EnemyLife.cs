using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.OnUpdateScore += Deactivate;
    }

    private void OnDisable()
    {
        GameManager.OnUpdateScore.Invoke();
        GameManager.OnUpdateScore -= Deactivate;   
    }

    public GameObject explosion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject go = Instantiate(explosion);
            go.transform.position = transform.position;
            Deactivate();
        }

        if (collision.CompareTag("Bullet"))
        {
            Deactivate();
            //Desactivarlo y agregarlo a la lista del oject pool
        }
    }

    private void Deactivate()
    {
        //destroy
        gameObject.SetActive(false);
    }
}
