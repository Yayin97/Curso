using UnityEngine;

public class TercerCubo : MonoBehaviour
{
    public GameObject Cubo3;
    private void OnEnable()
    {
        GameObject CuboOnEnable = Instantiate<GameObject>(Cubo3);
        CuboOnEnable.name = "CuboOnEnable";
        CuboOnEnable.GetComponent<MeshRenderer>().material.color = Color.red;
        CuboOnEnable.transform.position = new Vector3(7, 5, -10);
    }
    private void OnDisable()
    {
        GameObject CuboOnDisable = Instantiate<GameObject>(Cubo3);
        CuboOnDisable.name = "CuboOnDisable";
        CuboOnDisable.GetComponent<MeshRenderer>().material.color = Color.blue;
        CuboOnDisable.transform.position = new Vector3(9, 5, -10);
    }
}
