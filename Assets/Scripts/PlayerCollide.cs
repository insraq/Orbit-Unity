using UnityEngine;
using DG.Tweening;

public class PlayerCollide : MonoBehaviour
{
    public bool hasCollided;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (hasCollided)
        {
            return;
        }
        hasCollided = true;
        transform.DOScale(10, 0.5f);
        GetComponent<SpriteRenderer>().DOFade(0, 0.5f);
    }
}