using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigiocoController : MonoBehaviour
{
    [SerializeField] private GameObject jointLeva;
    [SerializeField] private List<GameObject> piattaformeRotanti;
    [SerializeField] private Animator animatorIngranaggi;
    [SerializeField] private float angoloLimite = 45f;
    private float angoloJoint;

    private void Update()
    {
        angoloJoint = jointLeva.transform.rotation.eulerAngles.x;
        if (angoloJoint > 180)
            angoloJoint = angoloJoint - 360;
        animatorIngranaggi.SetFloat("AnimationSpeed", angoloJoint/angoloLimite);
        foreach (GameObject piattaforma in piattaformeRotanti) {
            piattaforma.transform.localRotation = Quaternion.Euler(0, 10f * angoloJoint / angoloLimite,0);
            
        }
    }

}
