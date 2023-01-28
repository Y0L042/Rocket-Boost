using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    private Vector3 _startingPosition;
    [SerializeField]
    private Vector3 _targetPosition;
    [SerializeField][Range(0,1)]
    private float _movementFactor;
    [SerializeField]
    private float period = 2f;

    // Start is called before the first frame update
    void Start()
    {
        _startingPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        const float tau = Mathf.PI * 2;
        float freq = Time.time / period + 0.0001f;
        float rawSinWave = Mathf.Sin(freq * tau);
        _movementFactor = (rawSinWave + 1f) / 2f;
        Vector3 offset = _targetPosition * _movementFactor;
        transform.position = _startingPosition + offset;
    }

    private void OnDrawGizmosSelected()
    {
        // Set the color of the Gizmo
        Gizmos.color = Color.red;
        // Draw a cube using the dimensions of the transform component
        Gizmos.DrawSphere(_startingPosition + (_targetPosition * _movementFactor), 5f);
        // Gizmos.DrawSphere(transform.position + (_targetPosition * _movementFactor), 5f);
    }
}
