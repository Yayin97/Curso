using Unity.VisualScripting;
using UnityEngine;

public class TercerCubo : MonoBehaviour
{
    public PrimerCubo cubo1;
    public SegundoCubo cubo2;

    public bool estado;

    private Renderer rend;

    public GameObject Cubo3;
    //private void OnEnable()
    //{
    //    GameObject CuboOnEnable = Instantiate<GameObject>(Cubo3);
    //    CuboOnEnable.name = "CuboOnEnable";
    //    CuboOnEnable.GetComponent<MeshRenderer>().material.color = Color.red;
    //    CuboOnEnable.transform.position = new Vector3(7, 5, -10);
    //}
    //private void OnDisable()
    //{
    //    GameObject CuboOnDisable = Instantiate<GameObject>(Cubo3);
    //    CuboOnDisable.name = "CuboOnDisable";
    //    CuboOnDisable.GetComponent<MeshRenderer>().material.color = Color.blue;
    //    CuboOnDisable.transform.position = new Vector3(9, 5, -10);
    //}

    private void Start()
    {
        GameObject tercercubo = Instantiate<GameObject>(Cubo3);
        tercercubo.name = "TercerCubo";
        rend = tercercubo.GetComponent<MeshRenderer>();
        tercercubo.transform.position = new Vector3(0, 5, -10);
    }

    private void FixedUpdate()
    {
        estado = cubo1.estado && cubo2.estado;

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