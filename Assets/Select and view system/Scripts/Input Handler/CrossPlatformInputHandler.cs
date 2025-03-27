using UnityEngine;
using System;

public class CrossPlatformInputHandler : IInputHandler
{
    public event Action<Vector2> OnInputDirection;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) OnInputDirection?.Invoke(Vector2.left);
        if (Input.GetKeyDown(KeyCode.RightArrow)) OnInputDirection?.Invoke(Vector2.right);
        if (Input.GetKeyDown(KeyCode.UpArrow)) OnInputDirection?.Invoke(Vector2.up);
        if (Input.GetKeyDown(KeyCode.DownArrow)) OnInputDirection?.Invoke(Vector2.down);
        if (Input.GetKeyDown(KeyCode.W)) OnInputDirection?.Invoke(Vector2.up);
        if (Input.GetKeyDown(KeyCode.A)) OnInputDirection?.Invoke(Vector2.left);
        if (Input.GetKeyDown(KeyCode.S)) OnInputDirection?.Invoke(Vector2.down);
        if (Input.GetKeyDown(KeyCode.D)) OnInputDirection?.Invoke(Vector2.right);

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended)
            {
                float swipeDistanceX = touch.position.x - touch.rawPosition.x;
                float swipeDistanceY = touch.position.y - touch.rawPosition.y;

                if (swipeDistanceX > swipeDistanceY)
                {
                    if (swipeDistanceX > 50 || swipeDistanceX < -50) OnInputDirection?.Invoke(swipeDistanceX > 0 ? Vector2.left : Vector2.right);
                }
                else
                {
                    if (swipeDistanceY > 50 || swipeDistanceY < -50) OnInputDirection?.Invoke(swipeDistanceY > 0 ? Vector2.up : Vector2.down);
                }
            }
        }
    }
}