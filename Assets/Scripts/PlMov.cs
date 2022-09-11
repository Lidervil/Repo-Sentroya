using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlMov : MonoBehaviour
{
    private float n4speed = 8f;
    public float MouseSensibility = 200;
    private float xRotacion;
    private float yRotacion;
    public Transform cam;
    
    // Start is called before the first frame update
    void Start()
    {
/*         public bool right = Input.GetKey(KeyCode.("D");
        public bool left = Input.GetKey("a");
        public bool forw = Input.GetKey("w");
        public bool backw = Input.GetKey("s"); */
    }
    // Update is called once per frame
    void Update()
    {
        Move();
        MovimChoto();
    }
    
    void MovimChoto()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 diuca = new Vector3(hor, 0, ver);

        transform.Translate(diuca * n4speed * Time.deltaTime);
        /* if (right)
        {
            transform.Translate(new Vector3(1f, 0f, 0f) * n4speed * Time.deltaTime);
        }
        if (left)
        {
            transform.Translate(new Vector3(-1f, 0f, 0f) * n4speed * Time.deltaTime);
        }
        if (forw)
        {
            transform.Translate(new Vector3(0f, 0f, 1f) * n4speed * Time.deltaTime);
        }
        if (backw)
        {
            transform.Translate(new Vector3(0f, 0f, -1f) * n4speed * Time.deltaTime);
        } */
    }

    /* private void Movem() {
        transform.Translate(new Vector3(1f, 0f, 0f) * n4speed * Time.deltaTime); // derecha
        transform.Translate(new Vector3(-1f, 0f, 0f) * n4speed * Time.deltaTime); // izquierda
        transform.Translate(new Vector3(0f, 0f, 1f) * n4speed * Time.deltaTime); // adelante
        transform.Translate(new Vector3(0f, 0f, -1f) * n4speed * Time.deltaTime); // atras
    } */

    void Move()
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSensibility * Time.deltaTime; 
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensibility * Time.deltaTime;

        xRotacion -= mouseY;
        xRotacion = Mathf.Clamp(xRotacion, -70,70);

        yRotacion += mouseX;
        cam.localRotation= Quaternion.Euler(xRotacion,0,0);
        transform.localRotation = Quaternion.Euler(0,yRotacion,0);
    }

}