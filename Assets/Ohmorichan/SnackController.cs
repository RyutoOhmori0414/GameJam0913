using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnackController: MonoBehaviour
{
    [Tooltip("HP��\������X���C�_�["), SerializeField] Slider _snackHPSlider;
    [Tooltip("���َq�̗̑�"), SerializeField]float _snackHP = default;
    private float _currentSnackHP = default;
    public float SnackHP
    {
        get => _snackHP;
    }
    private void Start()
    {
        _currentSnackHP = _snackHP;
        _snackHPSlider.value = _currentSnackHP / _snackHP;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _currentSnackHP -= 1f;
            _snackHPSlider.value = _currentSnackHP / _snackHP;
            if (_currentSnackHP < 0f)
            {

            }
        }
    }
}