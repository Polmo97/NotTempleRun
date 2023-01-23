using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace er06 {

    public class SparoFreccia : MonoBehaviour
    {
        [SerializeField] GameObject freccia;
        // Start is called before the first frame update
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                freccia.SetActive(true);
            }
        }
    }


}
