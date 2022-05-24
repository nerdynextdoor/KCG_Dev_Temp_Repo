using System;
using UnityEngine;

public static class PositionConversionExstensions
{
    public static Vector3 ToVector3(this GridPosition position)
    {
        var result = new Vector3(position.x, position.y);

        return result;
    }

    public static GridPosition ToGridPosition(this Vector3 position)
    {
        var x = (int)Math.Truncate(position.x);

        var y = (int)Math.Truncate(position.y);

        var result = new GridPosition(x, y);
        return result;
    }

    public static int ToIndex(this GridPosition position, GridSize size)
    {
        return position.x * size.y + position.y;
    }

    public static GridPosition ToGridPosition(this int position, GridSize size)
    {
        var x = position / size.y;
        var y = position - x * size.y;
        var result = new GridPosition(x, y);
        return result;
    }
}