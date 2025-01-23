using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
{
    public delegate void MoveButtonDelegate();
    public event MoveButtonDelegate OnMoveButtonDown;
    
    public bool _isDown;

    private void Update()
    {
        if (_isDown)
        {
            // 뭔가 해야 함
            OnMoveButtonDown?.Invoke();
        }
    }
    
    public void ButtonDown()
    {
        _isDown = true;
    }
    
    public void ButtonUp()
    {
        _isDown = false;
    }
}
