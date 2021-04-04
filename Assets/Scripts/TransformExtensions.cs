using UnityEngine;

public static class TransformExtensions
{
    public static void WrapOnScreen(this Transform transform)
    {
        //Wrap objects in viewport. Todo make this reusable. 
        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(transform.position);
        var offScreenX = viewportPosition.x > 1 || viewportPosition.x < 0;
        var offScreenY = viewportPosition.y > 1 || viewportPosition.y < 0;
        if (offScreenX || offScreenY)
        {
            var newPosition = transform.position;
            if (offScreenX)
            {
                newPosition.x = -newPosition.x;
            }

            if (offScreenY)
            {
                newPosition.y = -newPosition.y;
            }
            transform.position = newPosition;
        }
    }
}