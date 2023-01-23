using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace er06
{
    public class Biglia : MonoBehaviour
    {
        [SerializeField]
        private AudioSource audioUrto;
        [SerializeField]
        private AudioSource audioRotolo;
        [SerializeField]
        private Rigidbody _rigidbody;


        private void OnCollisionEnter(Collision collision)
        {

            //audioUrto.pitch = Mathf.Lerp(1f, 1.5f, _rigidbody.velocity.magnitude);
            audioUrto.Play();
            audioRotolo.volume = 1f;

        }

        private void OnCollisionExit(Collision collision)
        {

            audioRotolo.volume = 0f;

        }

        private void OnCollisionStay(Collision collision)
        {

            if (_rigidbody.velocity.magnitude < 0.1f)
            {
                audioRotolo.volume = 0f;
            }
            else
            {
                audioRotolo.volume = 1f;
                audioRotolo.pitch = Mathf.Lerp(0.5f, 1, _rigidbody.velocity.magnitude);
            }
        }

    }
}
