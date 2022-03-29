using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    private Vector2 _velocity = Vector2.zero;

    private Vector2 _acceleration = Vector2.zero;

    private Vector2 _facing = Vector2.up;

    // Start is called before the first frame update
    private void Start()
    {
        // TODO: face in right direction based on initial _facing.
    }

    // Update is called once per frame
    private void Update()
    {
        this._velocity += this._acceleration * Time.deltaTime;
        this._acceleration *= 0.9f;
        Debug.Log($"velocity: {this._velocity}");
        Debug.Log($"acceleration: {this._acceleration}");

        this.transform.Translate(this._velocity);
    }

    public void FireThrusters()
    {
        Debug.Log("Firing thrusters");
        float magnitude = 1.0f * Time.deltaTime;
        this._acceleration += _facing * magnitude;
    }
}
