using UnityEngine;

public class PrimerCubo : MonoBehaviour
{
    public bool estado = false;
    private Renderer rend;

    public GameObject Cubo;
    //private void Awake()
    //{
    //    GameObject CuboAwake = Instantiate<GameObject>(Cubo);
    //    CuboAwake.name = "PrimerCubo";
    //    rend = CuboAwake.GetComponent<MeshRenderer>();
    //    CuboAwake.transform.position = new Vector3(-20,5,-10);

    //}

    private void Start()
    {
        GameObject primercubo = Instantiate<GameObject>(Cubo);
        primercubo.name = "PrimerCubo";
        rend = primercubo.GetComponent<MeshRenderer>();
        primercubo.transform.position = new Vector3(-20, 5, -10);
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
            rend.material.color= Color.black;
        }
    }
}
