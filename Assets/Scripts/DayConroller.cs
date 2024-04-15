﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayConroller : MonoBehaviour
{
    public float Speed;

    public float DayXRotate;

    public float NightXRotate;

    public GameObject LightGroup;

    private float _newAngleX;

    private bool _isDay;

    public void Start()
    {
        _newAngleX = transform.eulerAngles.x;
    }

    public void Update()
    {
        transform.Rotate(Vector3.right * Speed * Time.deltaTime);
        _newAngleX = transform.eulerAngles.x;
        _isDay = _newAngleX > DayXRotate && _newAngleX < NightXRotate;
        LightOnOrOf();
    }

    private void LightOnOrOf()
    {
        if (_isDay)
        {
            LightGroup.SetActive(false);
        }
        if (!_isDay)
        {
            LightGroup.SetActive(enabled);
        }
    }
}
