using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace er06 {
    public class PortaManager : MonoBehaviour
    {
        [SerializeField] private Animator portaAperta;
        [SerializeField] private AudioSource suonoApertua;
        [SerializeField]
        private GameObject teleportNuovaScena
            ;
        private int conteggioPuzzle = 0;
        private bool risolto = false;
        // Start is called before the first frame update

        public void PezzoGiusto()
        {
            conteggioPuzzle++;
            if (conteggioPuzzle == 3 && !risolto)
            {
                risolto = true;
                portaAperta.SetBool("Apertura", true);
                suonoApertua.Play();
                teleportNuovaScena.SetActive(true);
            }
        }
        public void PezzoTolto()
        {
            conteggioPuzzle--;
        }
    }
}

