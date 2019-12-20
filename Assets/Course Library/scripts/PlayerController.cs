using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed = 10f;

    public float xRange = 20f;

    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //pizza moet afgevuurd worden
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(x: xRange, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(x: -xRange, transform.position.y, transform.position.z);
        }        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
