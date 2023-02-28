using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material SeafoamGreen;
    public Material color002;
    public float r;  // red component
    public float g;  // green component
    public float b;  // blue component
    Color myColor;

    // Use this for initialization
    void Start()
    {
        myColor = new Color(r, g, b);
    }

    // Update is called once per frame
    void Update()
    {
        {
            // This will get the OBJECT to CHANGE COLOR on KEY PRESS
            if (Input.GetKeyDown(KeyCode.R))
            {
                GetComponent<Renderer>().material.color = Color.red;
                Debug.Log("R Key Press For RED");

                // This will get the OBJECT to CHANGE MATERIAL on KEY PRESS
            }

            else if (Input.GetKeyDown(KeyCode.P))
            {
                GetComponent<Renderer>().material = color002;
                Debug.Log("P Key Press For Pink Material (color002)");

            }
        }

        // This will get the OBJECT to CHANGE COLOR if the FPS Controller collides with Cube GameObject

        //void OnTriggerEnter(Collider other)
        void OnCollisionEnter(Collider other)
        {
            Debug.Log("Collision Detected");
            print(other.name);

            if (other.gameObject.CompareTag("BathBomb"))
            {
                GetComponent<Renderer>().material = color002;
            }
        }
    }
}
