using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    [SerializeField] Transform LastRespawnPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {
        LastRespawnPoint = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetKey(KeyCode.F))
        {

        }
    }

    public Transform GetLastRespawnPoint()
    {
        return LastRespawnPoint;
    }
}
