using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace er06 {
    public class MinigiocoController : MonoBehaviour
    {
        [SerializeField] private GameObject jointLeva;
        [SerializeField] private List<GameObject> piattaformeRotanti;
        [SerializeField] private Animator animatorIngranaggi;
        [SerializeField] private float angoloLimite = 45f;

        [SerializeField] private AudioSource rumoreIngranaggio;
        private bool invertito = false;
        private float speed = 1;
        private float angoloJoint;

        private void Update()
        {
            angoloJoint = jointLeva.transform.rotation.eulerAngles.x;
            if (angoloJoint > 180)
            {
                angoloJoint = angoloJoint - 360;
                invertito = true;
            }
            else {
                invertito = false;
            }
            animatorIngranaggi.SetFloat("AnimationSpeed", angoloJoint / angoloLimite);
            foreach (GameObject piattaforma in piattaformeRotanti)
            {
                piattaforma.transform.localRotation = Quaternion.Euler(0, 10f * angoloJoint / angoloLimite, 0);

            }
            if (invertito == true && speed > 0) {
                speed = -1;
                //rumoreIngranaggio.pitch = speed;
                rumoreIngranaggio.Play();
            }
            if (invertito == false && speed < 0) {
                speed = 1;
                //rumoreIngranaggio.pitch = speed;
                rumoreIngranaggio.Play();
            }
        }

    }
}

