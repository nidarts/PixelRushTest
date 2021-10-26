using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject _skeletion;
    private Animator _animator;
    private int _clickCount;

    private void Start()
    {
        _animator = _skeletion.GetComponent<Animator>();
        _clickCount = 0;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_clickCount < 3)
            {
                _clickCount++;
            }
            else
            {
                _clickCount = 0;
            }
            NextAnimation(_clickCount);
        }
    }

    private void NextAnimation(int val)
    {
        _animator.SetInteger("animation_switcher", val);
    }
}
