using System.Runtime.CompilerServices;
using UnityEngine;

public class EncajarImagen : MonoBehaviour
{
    public Vector3 Rompecabezas;

    private void Awake()
    {
        Rompecabezas = transform.position;  
    }


    private void Start()
    {
        transform.position = new Vector3(Random.Range(1, 10), Random.Range(1, 7), 0);

    }
    void Update()
    {   

        // Calcular la distancia entre la imagen y el fondo del rompecabezas
        float distancia = Vector3.Distance(transform.position, Rompecabezas);

        // Si la distancia es menor que un cierto umbral, alinear la imagen al fondo
        if (distancia < 0.5f)
        {
            transform.position = Rompecabezas;
            //transform.rotation = Rompecabezas;
        }
    }
}
