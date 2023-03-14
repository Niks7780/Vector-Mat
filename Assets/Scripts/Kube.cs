using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace VectorMat
{


    public class Kube : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] objects;
        private GameObject inst_obj;
        public static int _scoreKube;
        void Start()
        {

            int rand = Random.Range(0, objects.Length - 1);
            for (int i = 0; i < objects.Length; i++)
                inst_obj = Instantiate(objects[i], new Vector3(Random.Range(-3, 3), Random.Range(15, 25), Random.Range(-3, 3)), Quaternion.Euler(Random.Range(0f, 180f), Random.Range(0f, 180f), Random.Range(0f, 180f))) as GameObject;
            _scoreKube = objects.Length;
            Debug.Log("Kube ScoreKube = " + _scoreKube);
        }
        
        void Update()
        {
            if (_scoreKube <= 0) { Debug.Log("YOU WIN"); }
        }
    }
}
