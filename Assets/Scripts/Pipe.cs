using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        transform.Translate (Vector2.left*speed*Time.deltaTime);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent<Player>(out _))
        {
            ScoreManager.Instance.SetScore(1);
        }
    }
}
