using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace VectorMat
{
    public class Attack : MonoBehaviour
    {
        Vector3 _direction;
        public float _position;
        public float _ballSpeed;

        void Start()
        {
            _direction = transform.up;
            _position = 0.2f;
            _ballSpeed = 0.2f;
            if (gameObject.transform.position.y > 0)
            {
                _direction = transform.up;
                Debug.Log("Start Player1");
            }
            if (gameObject.transform.position.y < 0)
            {
                _direction = -transform.up;
                Debug.Log("Start Player2");
            }
            //_score = _scoreKube;
            Debug.Log("Score = " + Kube._scoreKube);
            
        }
        private void OnCollisionEnter(Collision col)
        {
            
            if (col.gameObject.layer == 6)
            {

                var direction = _direction;
                direction = Vector3.Reflect(direction, col.GetContact(0).normal);
                _direction = direction;
                _ballSpeed = _ballSpeed - 0.01f;
                Debug.Log("RefluxWalls");
            }
            if (col.gameObject.layer == 9)
            {
                var direction = _direction;
                direction = Vector3.Reflect(direction, col.GetContact(0).normal);
                _direction = direction;
                Debug.Log("RefluxPlatform");
            }
            if (col.gameObject.layer == 10)
            {
               
                Debug.Log("DestroyBall");
                ScoreManager._life = ScoreManager._life -1;
                Debug.Log(ScoreManager._life);
                Destroy(gameObject);
                


            }
            if (col.gameObject.layer == 7)
            {
                var direction = _direction;
                direction = Vector3.Reflect(direction, col.GetContact(0).normal);
                _direction = direction;
                _ballSpeed = _ballSpeed - 0.01f;
                Kube._scoreKube = Kube._scoreKube - 1;
                Debug.Log("Kube = " + Kube._scoreKube);
                Destroy(col.gameObject);
            }

            #region
            /*
            if (col.gameObject.layer == 6)
            {
                Vector3 dir = (gameObject.transform.position - col.gameObject.transform.position).normalized;
                gameObject.GetComponent<Rigidbody>().AddForce(dir * 20.0f, ForceMode.Impulse);
                Debug.Log("RefluxWalls");
            }
            if (col.gameObject.layer == 9)
            {
                Vector3 dir = (gameObject.transform.position - col.gameObject.transform.position).normalized;
                gameObject.GetComponent<Rigidbody>().AddForce(dir * 20.0f, ForceMode.VelocityChange);
                Debug.Log("RefluxPlatform");
            }
            if (col.gameObject.layer == 10)
            {
                Destroy(gameObject);
                Debug.Log("Damage");
            }
            if (col.gameObject.layer == 7)
            {
                Vector3 dir = (gameObject.transform.position - col.gameObject.transform.position).normalized;
                gameObject.GetComponent<Rigidbody>().AddForce(dir * 30.0f, ForceMode.VelocityChange);
                Destroy(col.gameObject);
                Debug.Log("RefluxCube");
            }
            */
            #endregion
        }
        void FixedUpdate()
        {
            transform.Translate(-_direction * _position * _ballSpeed);
            
        }
        
    }
}
