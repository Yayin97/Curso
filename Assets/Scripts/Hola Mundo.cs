using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Algo paso");
        Debug.LogWarning("Algo esta pasando");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogError("Algo Salio Mal");
    }
}
