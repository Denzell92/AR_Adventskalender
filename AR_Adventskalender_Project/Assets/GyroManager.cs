using UnityEngine;

public class GyroManager : MonoBehaviour
{
    #region Instance

    private static GyroManager _instance;

    public static GyroManager Instance

    {
        get
        {
            _instance = FindObjectOfType<GyroManager>();
            if (_instance == null)
            {
                _instance = new GameObject("Spawned GyroManager", typeof(GyroManager)).GetComponent<GyroManager>();
            }

            return _instance;
        }
        set { _instance = value; }
    }

    #endregion

    [Header("Logic")] private Gyroscope _gyro;
    private Quaternion _rotation;

    private bool _gyroActive;

    public void EnableGyro()
    {
        //already active
        if (_gyroActive) return;
        if (SystemInfo.supportsGyroscope)
        {
            _gyro = Input.gyro;
            _gyro.enabled = true;
            _gyroActive = _gyro.enabled;
        }
    }

    void Update()
    {
        if (_gyroActive)
        {
            _rotation = _gyro.attitude;
            Debug.Log(_rotation);
        }
    }

    public Quaternion GetGyroRotation()
    {
        return _rotation;
    }
}