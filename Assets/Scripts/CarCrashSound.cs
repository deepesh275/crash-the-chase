
using UnityEngine;

public class CarCrashSound : MonoBehaviour
{
    public AudioSource CrashSound;

    void OnCollisionEnter (Collision collision) {
        CrashSound.Play();
    }
}
