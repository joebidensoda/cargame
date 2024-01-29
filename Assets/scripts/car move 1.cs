using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmove1 : MonoBehaviour
{
    public float thrustspeed = 1.0f;
    public float turnspeed = 1.0f;
    public float boostMultiplier = 2.0f;
    public float boostDuration = 2.0f;
    private Rigidbody2D _rigidbody;
    private bool _thrusting;
    private float _turndirection;
    private bool _boosting;
    private float _boostEndTime;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _thrusting = Input.GetKey(KeyCode.W);

        if (Input.GetKey(KeyCode.A))
        {
            _turndirection = 1.0f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _turndirection = -1.0f;
        }
        else
        {
            _turndirection = 0.0f;
        }

        if (Input.GetKeyDown(KeyCode.Space) && !_boosting)
        {
            StartCoroutine(ActivateSpeedBoost());
        }
    }

    private IEnumerator ActivateSpeedBoost()
    {
        _boosting = true;
        _boostEndTime = Time.time + boostDuration;

        thrustspeed *= boostMultiplier;

        yield return new WaitForSeconds(boostDuration);

        thrustspeed /= boostMultiplier;
        _boosting = false;
    }

    private void FixedUpdate()
    {
        if (_thrusting)
        {
            _rigidbody.AddForce(this.transform.up * this.thrustspeed);
        }
        if (_turndirection != 0.0f)
        {
            _rigidbody.AddTorque(_turndirection * this.turnspeed);
        }

        if (_boosting && Time.time < _boostEndTime)
        {
            _rigidbody.AddForce(this.transform.up * this.thrustspeed * boostMultiplier);
        }
    }
}