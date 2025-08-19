using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] private float speed = 15.0f;
  [SerializeField] private float turnSpeed = 50.0f;
  
  // Private variables
  private float horizontalInput;
  private float verticalInput;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // We get player input
    horizontalInput = Input.GetAxis("Horizontal");
    verticalInput = Input.GetAxis("Vertical");

    // Moves the car forward based on vertical input
    transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

    // Rotates the car based on horizontal input
    transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

  }
}
