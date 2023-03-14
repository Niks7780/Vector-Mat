using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

namespace VectorMat
{
    public class ControlPlayer1 : MonoBehaviour
    {
        public float movementSpeed;
        private float horizontalBoundary = 8f;
        private float verticalBoundary = 8f;
        private Rigidbody _rb;
        
        void Start()
        {
            _rb = gameObject.GetComponent<Rigidbody>();
        }
        
        private void FixedUpdate()
        {
            UpdateMovement();
        }
        void UpdateMovement()
        {
            var translate = new Vector3();

            if (Input.GetKey(KeyCode.W) && (transform.position.z < horizontalBoundary)) 
            {
                translate.z += 1f;
                _rb.AddForce(translate * movementSpeed);
                
            }

            if (Input.GetKey(KeyCode.S) && (transform.position.z > -horizontalBoundary)) 
            { 
                translate.z -= 1f;
                _rb.AddForce(translate * movementSpeed);
                
            }

            if (Input.GetKey(KeyCode.D) && (transform.position.x < verticalBoundary)) 
            {
                translate.x += 1f;
                _rb.AddForce(translate * movementSpeed);
                
            }

            if (Input.GetKey(KeyCode.A) && (transform.position.x > -verticalBoundary)) 
            { 
                translate.x -= 1f;
                _rb.AddForce(translate * movementSpeed);
                
            }

        }  
       
    }
}

