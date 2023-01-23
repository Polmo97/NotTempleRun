using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace er06
{
    public class PuzzleManager : MonoBehaviour
    {
        [SerializeField] private Animator cassetto;
        [SerializeField] private GameObject chiave;
        [SerializeField] private GameObject spawnChiave;
        private int conteggioPuzzle = 0;
        private bool risolto = false;

        public void PezzoGiusto()
        {
            conteggioPuzzle++;
            if (conteggioPuzzle == 4 && !risolto)
            {
                GameObject chiavecubo = Instantiate(chiave, spawnChiave.transform);
                chiavecubo.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
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
