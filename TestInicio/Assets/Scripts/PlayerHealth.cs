using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    private int vida;
    [SerializeField] private int Maxvida;
    public RespawnPoint respawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        vida = Maxvida;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void damagepersonaje(int damageCantidad)
    {
        vida -= damageCantidad;
        if (vida <= 0) 
        {
            // Destroy(gameObject);
            Respawn();
        }
        Debug.Log(vida);
    }

    private void Respawn()
    {
        transform.position = respawnPoint.GetLastRespawnPoint().position;

    }
}
