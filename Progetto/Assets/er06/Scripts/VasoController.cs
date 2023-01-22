using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace er06 {
    public class VasoController : MonoBehaviour
    {
        [SerializeField] GameObject particleEffect;
        [SerializeField] GameObject oggettoNascosto;
        private bool grabbed=false;
        // Start is called before the first frame update

        private void OnCollisionEnter(Collision collision)
        {
            if (grabbed == true)
            {
                oggettoNascosto.transform.position = transform.position;
                Instantiate(particleEffect, this.transform.position, particleEffect.transform.rotation);
                oggettoNascosto.SetActive(true);
                this.gameObject.SetActive(false);
            }
        }

        public void GrabbedStatus(bool trueOrFalse) {
            grabbed = trueOrFalse;
        }
    }

}

