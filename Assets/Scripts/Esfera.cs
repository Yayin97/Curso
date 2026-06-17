using UnityEngine;

public class Esfera : MonoBehaviour
{
    private void Update()
    {
        //Obtenemos el render de nuestro componente
        Renderer esfera = GetComponent<Renderer>();

        //Creamos el color aleatorio
        Color c = new Color(Random.value, Random.value, Random.value);

        //Se lo aplicamos
        esfera.material.color = c;
    }
}
