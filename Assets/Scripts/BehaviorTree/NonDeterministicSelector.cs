using UnityEngine;
using System.Collections.Generic;
using System;

public class NonDeterministicSelector : CompositeNode {

    public NonDeterministicSelector(Node _child) : base(_child)
    {

    }

    public NonDeterministicSelector(List<Node> children) : base(children)
    {

    }

    public override bool Run()
    {
        bool result = false;
        List<Node> shuffled = Utility.Shuffle(getChildren());
        foreach(Node t in shuffled)
        {
            if (t.Run())
            {
                result = true;
                break;
            }
        }
        return result;
    }
}
