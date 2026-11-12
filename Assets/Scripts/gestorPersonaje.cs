using UnityEngine;

public class gestorPersonajes : MonoBehaviour
{
   

    public Personaje Hattori;
    public Personaje Ragnar;
    public Personaje Ricardo;

    // VARIABLES BOOLEANAS

    public bool mostrarAtributosPersonajes;

    public bool ataqueHattori;
    public bool ataqueRagnar;
    public bool ataqueRicardo;

    void Update()
    {

//=======================================================================================================//
        // MOSTRAR ATRIBUTOS

        if (mostrarAtributosPersonajes)
        {
            print("ESTADO DE LOS PERSONAJES");

            Hattori.MostrarCaracteristicas();
            Ragnar.MostrarCaracteristicas();
            Ricardo.MostrarCaracteristicas();

            mostrarAtributosPersonajes = false;
        }
//=======================================================================================================//
        // ATAQUE DE HATTORI

        if (ataqueHattori)
        {
            print("Hattori ataca a Ragnar y le quita " + Hattori.daño + " puntos de vida");

            Hattori.Atacar(Hattori.objetivo);

            ataqueHattori = false;
        }
//=======================================================================================================//
        // ATAQUE DE RAGNAR

        if (ataqueRagnar)
        {
            print("Ragnar ataca a Ricardo y le quita " + Ragnar.daño + " puntos de vida");

            Ragnar.Atacar(Ragnar.objetivo);

            ataqueRagnar = false;
        }
//=======================================================================================================//
        // ATAQUE DE RICARDO

        if (ataqueRicardo)
        {
            print("Ricardo ataca a Hattori y le quita " + Ricardo.daño + " puntos de vida");

            Ricardo.Atacar(Ricardo.objetivo);

            ataqueRicardo = false;
        }
    }
}