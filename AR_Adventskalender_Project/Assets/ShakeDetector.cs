using UnityEngine;

[RequireComponent(typeof(Controller))]
public class ShakeDetector : MonoBehaviour
{
    public float shakeDetectionThreshold;
    public float minShakeInterval;

    private float _sqrShakeDetectionThreshold;
    private float _timeSinceLastShake;

    private Controller _controller;

    void Start()
    {
        _sqrShakeDetectionThreshold = Mathf.Pow(shakeDetectionThreshold, 2);
        _controller = GetComponent<Controller>();
    }

    void Update()
    {
        if (Input.acceleration.sqrMagnitude >= _sqrShakeDetectionThreshold &&
            Time.unscaledTime >= _timeSinceLastShake + minShakeInterval)
        {
            // _controller.ShakeRigidBody(Input.acceleration);
            // _timeSinceLastShake = Time.unscaledTime;
            _controller.ActivateSnow();
        }
    }
}