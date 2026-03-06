using UnityEngine;
using System.Collections.Generic;

public class SpawnerCajas : MonoBehaviour
{
    public GameObject cajaPrefab;
    public int maxCajas = 3;

    private List<GameObject> cajas = new List<GameObject>();

    void Update()
    {
        cajas.RemoveAll(item => item == null);

        if (cajas.Count < maxCajas)
        {
            CrearCaja();
        }
    }

    void CrearCaja()
    {
        GameObject nuevaCaja = Instantiate(cajaPrefab, transform.position, Quaternion.identity);
        cajas.Add(nuevaCaja);
    }
}