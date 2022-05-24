using System;
using System.Collections.Generic;
using UnityEngine;

//That is required so nobody can set hex values into unity's position 
[Serializable]
public struct GridPosition : IEquatable<GridPosition>
{
    public int x;
    public int y;
    
    

    public GridPosition(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public List<GridPosition> GetNeighbours(List<GridPosition> buffer)
    {
        buffer.Clear();

        var result = new List<GridPosition>();

        return result;
    }

    public bool Equals(GridPosition other)
    {
        return other.x == x && other.y == y;
    }

    //Assuming we will never go bigger/lower than 1024 in Y dimension
    public override int GetHashCode()
    {
        return (x << 10) + y;
    }

    public static float Distance(GridPosition a, GridPosition b)
    {
        var first = a.ToVector3();
        var second = b.ToVector3();

        return Vector3.Distance(first, second);
    }
}