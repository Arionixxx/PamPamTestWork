using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] float _rotationSpeed;
    [SerializeField] private FixedJoystick _joystick;
    public GameObject _player;
    




    void Start()
    {
      //  Cursor.lockState = CursorLockMode.Locked;//cursor off

    }

    void Update()
    {

        _player.transform.Rotate (0, _joystick.Horizontal * Time.deltaTime * _rotationSpeed, 0);
        transform.Rotate ( - _joystick.Vertical * Time.deltaTime * _rotationSpeed, 0, 0);
       
    }
}
