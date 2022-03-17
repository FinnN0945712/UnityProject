using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (GunController))]
public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 10;
    public float turningSpeed = 60;
    private Rigidbody rbody;
    GunController gunController;


    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        gunController = GetComponent<GunController>();

      
        


 
    }

    // Update is called once per frame
    
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal") * turningSpeed * Time.deltaTime;
        rbody.transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime;
        rbody.transform.Translate(0, 0, vertical);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            gunController.Shoot();
        }
    }
}
