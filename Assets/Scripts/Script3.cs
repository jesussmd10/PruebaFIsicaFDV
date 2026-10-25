using UnityEngine;

public class Script3 : MonoBehaviour
{
    
    private Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisión entre " + gameObject.name + " y " + collision.gameObject.name);

        if(rend != null)
        {
            rend.material.color = Random.ColorHSV();
        }
    }

}