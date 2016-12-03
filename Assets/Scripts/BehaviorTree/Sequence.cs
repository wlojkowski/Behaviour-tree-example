using System.Collections.Generic;

public class Sequence : CompositeNode
{
    public Sequence(Node _child) : base(_child)
    {

    }

    public Sequence(List<Node> _children) : base(_children)
    {

    }

    public override bool Run()
    {
        foreach(Node c in getChildren())
        {
            if (!c.Run())
            {
                return false;
            }
        }
        return true;
    }
}
