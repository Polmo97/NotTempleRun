using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace er06 {
    public class DetectorPorta : MonoBehaviour
    {
        [SerializeField] private string nomePuzzle;
        [SerializeField] private PortaManager puzzle;

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.gameObject.name);
            if (other.gameObject.name == nomePuzzle)
            {
                puzzle.PezzoGiusto();
                Debug.Log(other.gameObject.name);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.name == nomePuzzle)
            {
                puzzle.PezzoTolto();
            }
        }
    }
}

