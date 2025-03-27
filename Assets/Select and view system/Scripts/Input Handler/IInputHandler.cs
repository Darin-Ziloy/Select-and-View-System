using UnityEngine;
using System;

public interface IInputHandler
{
    event Action<Vector2> OnInputDirection;

    void Update();
}
