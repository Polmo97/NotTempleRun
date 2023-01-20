using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace er06 {
    public class TorciaController : MonoBehaviour
    {
        [SerializeField] GameObject particleEffect;
        [SerializeField] GameObject fuocoAssi; 
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag("Fuoco"))
            {

                particleEffect.SetActive(true);
            }
            if (other.gameObject.CompareTag("Respawn"))
            {
                fuocoAssi.SetActive(true);
            }

        }

    }


}

