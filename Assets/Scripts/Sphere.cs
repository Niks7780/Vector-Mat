using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace VectorMat
{
    public class Sphere : MonoBehaviour
    {
        [SerializeField]
        private GameObject _sphere;

        [SerializeField]
        private GameObject _player1;

        [SerializeField]
        private GameObject _player2;

        public bool _boolPlayer1;
        public bool _boolPlayer2;
        
        public void Start()
        {
            _boolPlayer2 = true;
            
        }
        public void Update()
        {
            UpdateShooting();
        }
        
        private void Go()
        {
            
        }
        private void UpdateShooting()
        {
            
            if (GameObject.FindWithTag("Sphere") == false)
            {
                
                if (Input.GetKey(KeyCode.Space) && _boolPlayer1 == false)
                {
                    Vector3 _p1 = new Vector3(_player1.transform.position.x, _player1.transform.position.y - 1, _player1.transform.position.z); 
                    Instantiate(_sphere, _p1, _player1.transform.rotation);
                    _boolPlayer1 = true;
                    _boolPlayer2 = false;
                    Debug.Log("Player1Fire");
                }
                if (Input.GetKey(KeyCode.E) && _boolPlayer2 == false)
                {
                    Vector3 _p2 = new Vector3(_player2.transform.position.x, _player2.transform.position.y + 1, _player2.transform.position.z);
                    Instantiate(_sphere, _p2, _player2.transform.rotation);
                    _boolPlayer1 = false;
                    _boolPlayer2 = true;
                    Debug.Log("Player2Fire");
                }
            }
        }
    }
}
