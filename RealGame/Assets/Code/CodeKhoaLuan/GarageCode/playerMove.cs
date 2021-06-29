using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    float x, z;

    [SerializeField] GameObject vision;

    [SerializeField] float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        transform.position += (vision.transform.forward * z + vision.transform.right * x) * speed * Time.deltaTime;
    }
}
