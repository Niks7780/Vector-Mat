using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;
namespace VectorMat
{
    public class ContrrolPlayer2 : MonoBehaviour
    {

        public float movementSpeed;
        private float horizontalBoundary = 8f;
        private float verticalBoundary = 8f;
        private Rigidbody _rb;

        void Start()
        {
            _rb = gameObject.GetComponent<Rigidbody>();
        }
        void FixedUpdate()
        {
            UpdateMovement();
        }
        void UpdateMovement()
        {
            var translate = new Vector3();

            if (Input.GetKey(KeyCode.UpArrow) && (transform.position.z < horizontalBoundary))
            {
                translate.z += 1f;
                _rb.AddForce(translate * movementSpeed);
                
            }

            if (Input.GetKey(KeyCode.DownArrow) && (transform.position.z > -horizontalBoundary))
            {
                translate.z -= 1f;
                _rb.AddForce(translate * movementSpeed);
                
            }

            if (Input.GetKey(KeyCode.RightArrow) && (transform.position.x < verticalBoundary))
            {
                translate.x += 1f;
                _rb.AddForce(translate * movementSpeed);
                
            }

            if (Input.GetKey(KeyCode.LeftArrow) && (transform.position.x > -verticalBoundary))
            {
                translate.x -= 1f;
                _rb.AddForce(translate * movementSpeed);
                
            }

        }
    }
}
