using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SnackController: MonoBehaviour
{
    [Tooltip("HPを表示するスライダー"), SerializeField] Slider _snackHPSlider;
    [Tooltip("お菓子の体力"), SerializeField]float _snackHP = default;
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
            _snackHPSlider.DOValue(_currentSnackHP / _snackHP, 0.5f);
            if (_currentSnackHP <= 0f)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
