using UnityEngine;

public class ArrastrarCaja : MonoBehaviour
{
    private bool arrastrando = false;
    private Vector3 offset;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                arrastrando = true;
                offset = transform.position - (Vector3)mousePos;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            arrastrando = false;
        }

        if (arrastrando)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            transform.position = mousePos + offset;
        }
    }
}