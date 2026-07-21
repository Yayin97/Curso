using UnityEngine;

public class SegundoCubo : MonoBehaviour
{
    public bool estado = true;
    private Renderer rend;

    public GameObject Cubo2;
    //public int numCubos = 0;
    //void Update()
    //{
        //numCubos++;
        //GameObject CuboUpdate = Instantiate<GameObject>(Cubo2);
        //if (numCubos == 1)
        //{
        //    CuboUpdate.GetComponent<MeshRenderer>().material.color = Color.white;
        //}
        //else { Color c = new Color(Random.value, Random.value, Random.value);
        //    CuboUpdate.GetComponent<MeshRenderer>().material.color = c; }

        //CuboUpdate.name = "CuboNumero" +numCubos;
        //CuboUpdate.transform.position = new Vector3(0, 3 + numCubos *2, -10);
    //}

    private void Start()
    {
        GameObject segundocubo = Instantiate<GameObject>(Cubo2);
        segundocubo.name = "SegundoCubo";
        rend = segundocubo.GetComponent<MeshRenderer>();
        segundocubo.transform.position = new Vector3(-10, 5, -10);
    }

    private void FixedUpdate()
    {
        estado = !estado;
        if (estado)
        {
            rend.material.color = Color.white;
        }
        else
        {
            rend.material.color = Color.black;
        }
    }
}
