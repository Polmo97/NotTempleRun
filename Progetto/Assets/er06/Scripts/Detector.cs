using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace er06 {
    public class Detector : MonoBehaviour
    {
        [SerializeField] private string nomePuzzle;
        [SerializeField] private PuzzleManager puzzle;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == nomePuzzle)
            {
                puzzle.PezzoGiusto();
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

