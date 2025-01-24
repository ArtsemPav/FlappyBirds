using UnityEngine;

public class Pipe : MonoBehaviour
{
    public GameObject PointSound;
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent<Player>(out _))
        {
            ScoreManager.Instance.SetScore(1);
            PointSound.SetActive(true);
        }
    }
}
