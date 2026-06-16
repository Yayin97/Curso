using UnityEngine;

public class ColorAleatorioFixedupdate : MonoBehaviour
{
    //Definimos el valor incial de nuestro cronometro
    float tiempo = 0f;
    //Establecemos el tiempo (segundos) entre cada cambio de color
    public float tiempoParaCambio = 3f;

    //Unity lo ejecuta cada .02 segundos por defecto
    private void FixedUpdate()
    {
        //Sumamos el tiempo transcurrido desde la ultima actualizacion de fisica
        tiempo += Time.fixedDeltaTime;

        //Obtenemos el componente render del objeto
        Renderer capsula = GetComponent<Renderer>();

        //Si el tiempo es mayor o igual al que se establece en el parametro "Tiempo para cambio" en inspector
        if (tiempo >= tiempoParaCambio)
        {
            //Se aplica un nuevo color al material
            Color colorNuevo = new Color(Random.value, Random.value, Random.value);
            capsula.material.color = colorNuevo;

            //Reiniciamos cronometro
            tiempo = 0f;
        }
    }
}