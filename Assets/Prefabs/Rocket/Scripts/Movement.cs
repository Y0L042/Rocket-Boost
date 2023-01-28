// using System.Collections;
// using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] public bool ShowGizmos = true;

    [SerializeField] private AudioClip _forwardThrustAudio;
    [SerializeField] private ParticleSystem _forwardThrustParticleSystem;
    [SerializeField] private ParticleSystem _rotationRightThrustParticleSystem;
    [SerializeField] private ParticleSystem _rotationLeftThrustParticleSystem;

    // Properties
    [SerializeField] private float _maxForwardThrust = 15f;
    private float _forwardThrust;
    [SerializeField] public float ForwardThrust 
    {
        get { return _forwardThrust; }
        private set
        {
            _forwardThrust = Mathf.Clamp(value, 0, _maxForwardThrust);
        }
        
    }


    [SerializeField] private float _turnSpeed_DegSec = 50f;


    [SerializeField] private float _maxRotationThrust = 3.5f;
    [SerializeField] private float _rotationThrust;
    [SerializeField] public float RotationThrust
    {
        get
        {
            return _rotationThrust;
        }
        private set
        {
            _rotationThrust = Mathf.Clamp(value, -_maxRotationThrust, _maxRotationThrust);
        }
    }

    [SerializeField] private Vector3 _customCenterOfMass;
    public Vector3 CustomCenterOfMass 
    {
        get { return _customCenterOfMass; }
        set
        {
            _customCenterOfMass = value;
            if (_rb) {_rb.centerOfMass = CustomCenterOfMass;}
        }
    }
    
    // Variables
    private Rigidbody _rb;
    private PlayerManager _playerManager;

    // Inputs
    private float _forwardThrustInput;
    private float _rotationThrustInput;


    private void Awake() 
    {

    }

    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();    
        _rb.centerOfMass = CustomCenterOfMass;
        _playerManager = this.GetComponent<PlayerManager>();
    }


    void FixedUpdate()
    {
        PerformForwardThrust();
        PerformRotationThrust();
        // RotateShip();
    }


    private void PerformForwardThrust()
    {
        ForwardThrust = _forwardThrustInput * _maxForwardThrust;
        _rb.AddRelativeForce(Vector3.up * ForwardThrust);
        PlayForwardThrustFx(ForwardThrust > 0);
    }

    private void PlayForwardThrustFx(bool forwardThrustActive)
    {
        if (forwardThrustActive)
        { _forwardThrustParticleSystem.Play(); } 
        else 
        { _forwardThrustParticleSystem.Stop(); }
        
        if (_playerManager){ _playerManager.PlayAudio(_forwardThrustAudio, forwardThrustActive); }
    }


    private void PerformRotationThrust()
    {
        RotationThrust = _rotationThrustInput * _maxRotationThrust;
        _rb.AddRelativeTorque(Vector3.forward * RotationThrust);
        PlayRotationThrustFx(RotationThrust > 0, RotationThrust < 0);
    }

    private void PlayRotationThrustFx(bool playRight, bool playLeft)
    {
        if (playRight)
        { _rotationRightThrustParticleSystem.Play(); } 
        else 
        { _rotationRightThrustParticleSystem.Stop(); }

        if (playLeft)
        { _rotationLeftThrustParticleSystem.Play(); } 
        else 
        { _rotationLeftThrustParticleSystem.Stop(); }

        if (_playerManager){ _playerManager.PlayAudio(_forwardThrustAudio, playRight||playLeft, 0.25f); }
    }

    void OnDrawGizmos()
    {
        if (!ShowGizmos){ return; }
        float CoMRadius = 1f;
        // Draw a sphere at the center of mass of the rigidbody
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position + _customCenterOfMass, CoMRadius);
    }


    private void RotateShip()
    // Rotation stops working as soon as a torque force is applied (thru collision, for example)
    {
        float rotationInc = _turnSpeed_DegSec * Time.deltaTime * _rotationThrustInput;
        _rb.freezeRotation = true; // freezing physics rotation so that we can manually rotate
        transform.Rotate(Vector3.forward * rotationInc);
        _rb.freezeRotation = true; // unfreezing physics rotation so that the physics system can take over
    }


    private void OnDisable() 
    {
        PlayForwardThrustFx(false);
        PlayRotationThrustFx(false,false);
    }


    private void OnThrust(InputValue value) => _forwardThrustInput = value.Get<float>();

    private void OnTurn(InputValue value) => _rotationThrustInput = value.Get<float>();


    // DevTools

}
