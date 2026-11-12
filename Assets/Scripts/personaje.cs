using UnityEngine;

public class Personaje : MonoBehaviour
{
//=======================================================================================================//
    //ATRIBUTOS DEL PERSONAJE

    public int vida;
    public string nombre;
    public int nivel;
    public string tipo;
    public int daño;
    public Personaje objetivo;
//=======================================================================================================//
    //METODOS DEL PERSONAJE
    public void MostrarCaracteristicas()
    {
        print("Nombre: " + nombre 
            + "  Vida: " + vida 
            + "  Nivel de poder: " + nivel
            + "  Tipo de personaje: " + tipo
            + "  Daño: " + daño);
    }

    public void Atacar(Personaje objetivo)
    {
        objetivo.vida -= daño;
    }
}
