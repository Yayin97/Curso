using UnityEngine;

public class Capsula : MonoBehaviour
{
    private void FixedUpdate()
    {
        //Obtenemos el render de nuestro componente
        Renderer capsula = GetComponent<Renderer>();

        //Creamos el color aleatorio
        Color a =new Color(Random.value, Random.value, Random.value);

        //Se lo aplicamos
        capsula.material.color= a;
    }
}
