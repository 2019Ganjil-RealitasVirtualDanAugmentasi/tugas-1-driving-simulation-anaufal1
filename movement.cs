using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    private Rigidbody rb;
    [SerializeField] private float speed = 5f;
        [SerializeField] private float sensitivity = 2f;
    [SerializeField] private float mouseSensivity = 2f;
    [SerializeField] private GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float frontAxis = Input.GetAxis("Vertical");
        float horAxis = Input.GetAxis("Horizontal");

        //rb.velocity = transform.forward * frontAxis * speed;
        transform.Translate(new Vector3(horAxis * speed * Time.deltaTime, 0, frontAxis * speed * Time.deltaTime), Space.Self);

        float yRot = Input.GetAxisRaw("Mouse X");
        Vector3 rotation = new Vector3(0, yRot, 0) * mouseSensivity;

        float xRot = Input.GetAxisRaw("Mouse Y");
        Vector3 cameraRotation = new Vector3(xRot, 0, 0) * mouseSensivity;


        
        transform.Rotate(rotation);
        cam.transform.Rotate(-cameraRotation);

    }
    
}
