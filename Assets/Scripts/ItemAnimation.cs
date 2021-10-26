using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAnimation : MonoBehaviour
{
    [Header("VERTICAL MOVEMENT")]
    [Tooltip("Будет ли зацикленное движение по вертикали")]
    [SerializeField] private bool _canVericalMove = false;

    [Tooltip("Кривая движения по вертикали")]
    [SerializeField] private AnimationCurve _directionCurve;

    [Tooltip("Значение амплитуды движения по вертикали: больше значение - больше амплитуда")]
    [SerializeField] private float _scale = 1f;

    [Header("ROTATE MOVEMENT")]
    [Tooltip("Будет ли вращаться объект")]
    [SerializeField] private bool _canRotate = false;

    [Tooltip("Скоростьы вращения объекта")]
    [SerializeField] private float _rotationSpeed = 90f;

    void Update()
    {
        if (_canVericalMove)
        {
            VerticalMove();
        }
        if (_canRotate)
        {
            RotationMove();
        }

    }

    private void VerticalMove()
    {
        transform.position += transform.up * _directionCurve.Evaluate(Mathf.Repeat(Time.time, 1f)) * Time.deltaTime * _scale;
    }

    private void RotationMove()
    {
        transform.Rotate(transform.up, _rotationSpeed * Time.deltaTime);
    }
}
