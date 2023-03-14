using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VectorMat
{
    public class ScoreManager : MonoBehaviour
    {
        public static int _life;
        

        // Start is called before the first frame update
        void Start()
        {
            _life = 5;
            Debug.Log("Score Manager Life = " + _life);
        }
       
        // Update is called once per frame
        void Update()
        {
            if (_life <= 0) { Debug.Log("GameOver"); }

        }
    }
}
