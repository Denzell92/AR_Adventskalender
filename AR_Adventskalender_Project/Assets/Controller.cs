using System;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float shakeForceMultiplier;
    public Rigidbody shakingRigidbody;
    public ParticleSystem particleSys;

    private void Awake()
    {
        particleSys.Stop();
    }

    public void ShakeRigidBody(Vector3 deviceAccel)
    {
        shakingRigidbody.AddForce(deviceAccel * shakeForceMultiplier, ForceMode.Impulse);
    }

    public void ActivateSnow()
    {
        particleSys.Play();
    }
}