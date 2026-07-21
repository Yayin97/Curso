using UnityEngine;

public class CuartoCubo : MonoBehaviour
{
    public PrimerCubo cubo1;

    public bool estado;

    private Renderer rend;
    public GameObject Cubo4;

    private void Start()
    {
        GameObject cuartocubo = Instantiate(Cubo4);
        cuartocubo.name = "CuartoCubo";
        rend = cuartocubo.GetComponent<Renderer>();
        cuartocubo.transform.position = new Vector3(10, 5, -10);
    }

    private void FixedUpdate()
    {
        estado = !cubo1.estado;

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
