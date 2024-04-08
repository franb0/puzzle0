using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    public MovimientoYRotacion movimiento;

    void Update()
    {
        // Detectar clic izquierdo del mouse
        if (Input.GetMouseButtonDown(0))
        {   
            // Obtener posición del clic del mouse en el mundo
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Realizar un raycast para detectar el objeto clickeado
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            // Verificar si el rayo golpeó un collider
            if (hit.collider != null)
            {
                //toma el click y se lo pasa al script de movimiento
                movimiento.target = hit.collider.transform;

                // Mostrar el nombre del objeto clickeado en la consola
                Debug.Log("Objeto clickeado: " + hit.collider.gameObject.name);
            }
        }
    }
}

