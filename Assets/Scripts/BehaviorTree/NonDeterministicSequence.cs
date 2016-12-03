using System;
using System.Collections;
using System.Collections.Generic;

public class NonDeterministicSequence : CompositeNode
{

    public NonDeterministicSequence(Node _child) : base(_child)
    {

    }

    public NonDeterministicSequence(List<Node> _children) : base(_children)
    {

    }
    public override bool Run()
    {
        bool result = true;
        List<Node> shuffled = Utility.Shuffle(getChildren());
        foreach(Node t in shuffled)
        {
            if (!t.Run())
            {
                result = false;
                break;
            }
        }
        return result;
    }
}
