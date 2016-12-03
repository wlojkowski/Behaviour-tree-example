using UnityEngine;
using System.Collections;

public class Repeater : Node
{
    Node child;
    int startValue;
    int maxValue;

    public void SetChild(Node _child)
    {
        child = _child;
    }

    public Repeater(int _startValue, int _maxValue)
    {
        startValue = _startValue;
        maxValue = _maxValue;
    }

    public override bool Run()
    {
        while (startValue < maxValue)
        {
            child.Run();
            startValue++;
        }
        return true;
    }
}
