using Unity.VisualScripting;
using UnityEngine;

public class QuintoCubo : MonoBehaviour
{
    public PrimerCubo cubo1;
    public SegundoCubo cubo2;
    public TercerCubo cubo3;
    public CuartoCubo cubo4;

    private Renderer rend;

    public GameObject Cubo5;

    private void Start()
    {
        GameObject quintocubo = Instantiate(Cubo5);
        quintocubo.name = "QuintoCubo";
        rend = quintocubo.GetComponent<Renderer>();
        quintocubo.transform.position = new Vector3(20, 5, -10);
    }

    private void FixedUpdate()
    {
        int total = 0;

        if (cubo1.estado) total++;
        if (cubo2.estado) total++;
        if (cubo3.estado) total++;
        if (cubo4.estado) total++;

        Debug.Log("C1:" + cubo1.estado + "C2:" + cubo2.estado + "C3:" + cubo3.estado + "C4:" + cubo4.estado + "Total:" + total);

        switch (total)
        {
            case 0:
                rend.material.color = Color.black;
                break;

            case 1:
                rend.material.color = Color.red;
                break;

            case 2:
                rend.material.color = Color.yellow;
                break;

            case 3:
                rend.material.color = Color.green;
                break;

            case 4:
                rend.material.color = Color.white;
                break;

            default:
                rend.material.color = Color.magenta;
                break;
        }
    }
}
