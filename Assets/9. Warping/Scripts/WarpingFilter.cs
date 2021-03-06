using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpingFilter : SimpleFilter
{
    [Range(0, 10)]
    [SerializeField]
    private float _amplitude = 5;    
    
    [Range(0, 50)]
    [SerializeField]
    private float _speed = 15;

    protected override void OnUpdate()
    {
        _mat.SetFloat("_Amplityde", _amplitude);
        _mat.SetFloat("_Speed", _speed);
    }
}
