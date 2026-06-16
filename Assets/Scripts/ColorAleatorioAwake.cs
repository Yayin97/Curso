using UnityEngine;

public class ColorAleatorioAwake : MonoBehaviour
{
    //Cambia el color una solo una vez al iniciar
    private void Awake()
    {
        //Buscamos el componente render del objeto
        Renderer cubo = GetComponent<Renderer>();
        //Verificamos si existe o no un render
        if (cubo != null)
        {
            //Creamos un color aleatorio y lo aplicamos al material
            Color colorNuevo = new Color(Random.value, Random.value, Random.value);
            cubo.material.color = colorNuevo;
        }
    }
}