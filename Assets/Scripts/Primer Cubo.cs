using UnityEngine;

public class PrimerCubo : MonoBehaviour
{
    public GameObject Cubo;
    private void Awake()
    {
        GameObject CuboAwake = Instantiate<GameObject>(Cubo);
        CuboAwake.name = "PrimerCubo";
        CuboAwake.GetComponent<MeshRenderer>().material.color = Color.green;
        CuboAwake.transform.position = new Vector3(-7,5,-10);

    }
}
