using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControls : MonoBehaviour
{

    [SerializeField] private Rigidbody characterBody;
    [SerializeField] private float speed = 2f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0) 
        {
            transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
        }

         if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
        }

         if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

    }

    private void Jump()
    {
        characterBody.AddForce(Vector3.up * 500f);
    }

}
