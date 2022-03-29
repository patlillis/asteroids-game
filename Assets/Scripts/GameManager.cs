using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }

    private Ship _ship;

    private void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        _ship = FindObjectOfType<Ship>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _ship.FireThrusters();
        }
    }
}