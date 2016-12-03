using System.Collections.Generic;

public class Selector : CompositeNode {
    public Selector(Node _child) : base(_child)
    {

    }

    public Selector(List<Node> _children) : base(_children)
    {

    }

    public override bool Run()
    {
        foreach(Node c in getChildren())
        {
            if (c.Run())
            {
                return true;
            }
        }
        return false;
    }
}
