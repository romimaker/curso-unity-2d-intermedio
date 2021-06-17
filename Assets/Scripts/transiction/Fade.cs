using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Fade : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer spriteRenderer;

    [ContextMenu("FadeIn")]
    public void FadeIn()
    {
        spriteRenderer.DOFade(1,2);
    }
    
    [ContextMenu("FadeOut")]
    public void FadeOut()
    {
        spriteRenderer.DOFade(0,2);
    }

    private void Start()
    {
        FadeOut();
    }
}
