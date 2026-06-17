using UnityEngine;

public class SegundoCubo : MonoBehaviour
{

    public GameObject Cubo2;
    void Update()
    {
        GameObject CuboAwake = Instantiate<GameObject>(Cubo2);
        CuboAwake.name = "SegundoCubo";
        CuboAwake.GetComponent<MeshRenderer>().material.color = Color.white;
        CuboAwake.transform.position = new Vector3(0, 5, -10);
    }
}
