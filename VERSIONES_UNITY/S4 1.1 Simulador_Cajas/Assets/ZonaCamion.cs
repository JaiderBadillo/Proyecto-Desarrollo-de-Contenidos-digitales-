using UnityEngine;

public class ZonaCamion : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Caja"))
        {
            Destroy(other.gameObject);
        }
    }
}