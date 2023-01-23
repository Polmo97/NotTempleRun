using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace er06 {
    public class PuzzleManager : MonoBehaviour
    {
        [SerializeField] private Animator cassetto;
        [SerializeField] private GameObject chiave;
        [SerializeField] private GameObject spawnChiave;
        private int conteggioPuzzle = 0;
        private bool risolto = false;
        // Start is called before the first frame update
        public void PezzoGiusto()
        {
            conteggioPuzzle++;
            if (conteggioPuzzle == 4 && !risolto)
            {
                Instantiate(chiave, spawnChiave.transform.position, spawnChiave.transform.rotation);
                risolto = true;
                cassetto.SetBool("Apertura", true);
            }
        }

        public void PezzoTolto()
        {
            conteggioPuzzle--;

        }
    }


}
