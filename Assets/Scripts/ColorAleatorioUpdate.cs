using UnityEngine;

public class ColorAleatorioUpdate : MonoBehaviour
{
    //Definimos el valor incial de nuestro cronometro
    float contador = 0f;
    //Establecemos el tiempo (segundos) entre cada cambio de color
    public float tiempoParaCambio = 3f;

    //Unity lo ejecuta cada frame
    private void Update()
    {
        //Sumamos el tiempo transcurrido desde el ultimo frame (tiempo entre frames)
        contador += Time.deltaTime;

        //Obtenemos el componente render del objeto
        Renderer esfera = GetComponent<Renderer>();

        //Si el cronometro es mayor o igual al que se establece en el parametro "Tiempo para cambio" en inspector
        if (contador >= tiempoParaCambio)
        {
            //Se aplica un nuevo color al material
            Color colorNuevo = new Color(Random.value, Random.value, Random.value);
            esfera.material.color = colorNuevo;

            //Reiniciamos contador
            contador = 0f;
        }
    }
}