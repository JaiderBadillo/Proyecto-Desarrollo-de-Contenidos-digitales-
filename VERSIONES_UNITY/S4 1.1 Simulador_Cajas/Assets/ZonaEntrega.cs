using UnityEngine;
using System.Collections;

public class ZonaEntrega : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Caja"))
        {
            StartCoroutine(Desaparecer(other.gameObject));
        }
    }

    IEnumerator Desaparecer(GameObject caja)
    {
        float tiempo = 0.3f;

        while (tiempo > 0)
        {
            caja.transform.localScale *= 0.9f;
            tiempo -= Time.deltaTime;
            yield return null;
        }

        Destroy(caja);
    }
}