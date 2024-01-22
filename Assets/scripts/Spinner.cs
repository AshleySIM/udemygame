using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRotation = 2f;
    [SerializeField] float yRotation = 2f;
    [SerializeField] float zRotation = 2f;


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotation,yRotation,zRotation);
    }
}
