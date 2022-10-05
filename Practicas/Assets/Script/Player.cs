using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float vida = 200f;
    [SerializeField] float velocidad = 1f;
    [SerializeField] Vector3 direccion;
    

    void Start()
    {

    }

    void Update()
    {
        Movimiento();
        CuraJugador();
        //Da�oJugador();

    }

    public void Movimiento()
    {
        transform.position += direccion * velocidad * Time.deltaTime;
    }

    public void CuraJugador()
    {
        vida += 1 * Time.deltaTime;
    }

    public void Da�oJugador()
    {
        vida -= 1 * Time.deltaTime;
    }
}
