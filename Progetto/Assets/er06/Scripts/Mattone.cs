using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace er06
{
    public class Mattone : MonoBehaviour
    {
        [SerializeField]
        private AudioSource audioUrto;


        private void OnCollisionEnter(Collision collision)
        {


            audioUrto.Play();


        }



    }
}