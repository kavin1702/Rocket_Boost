using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float throtlleSpeed = 10f;
    [SerializeField] private float rotationSpeed = 5f;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void U()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {

        }
    }
}
