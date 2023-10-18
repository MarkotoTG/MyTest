using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguimientocamara : MonoBehaviour
{

    private Vector3 offset = new Vector3(0f,0f,-5f);//nueva posicion de la camara
    private Vector3 Velocidad = Vector3.zero;//Velocidad a la que se mueve la camara
    private float cameraMovementSmooth = 0.25f;//variacion de velocidad

    [SerializeField] private Transform Target; //el transform del personaje

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Target != null)
        {
            Vector3 posicionObjetivo = Target.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, posicionObjetivo, ref Velocidad, cameraMovementSmooth);
        }
    }
}
