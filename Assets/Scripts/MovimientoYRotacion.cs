using UnityEngine;

public class MovimientoYRotacion : MonoBehaviour
{
    public float velocidadMovimiento = 1f;
    public Transform target = null;
    public float rotacion = 10f; // Ajust� el valor de rotaci�n, puedes cambiarlo seg�n tus necesidades

    void Update()
    {
        // Movimiento
        if (Input.GetKey(KeyCode.W))
        {
            target.Translate(Vector3.up * velocidadMovimiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            target.Translate(Vector3.down * velocidadMovimiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            target.Translate(Vector3.left * velocidadMovimiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            target.Translate(Vector3.right * velocidadMovimiento * Time.deltaTime);
        }

        // Rotaci�n
        if (Input.GetKey(KeyCode.R))
        {
            target.Rotate(0, 0, 90f); // Ajust� el c�lculo de rotaci�n
        }
    }
}
