using System.Collections.Generic;
using System;

public class RandomSelector : CompositeNode
{
    public RandomSelector(Node _child) : base(_child)
    {

    }

    public RandomSelector(List<Node> _children) : base(_children)
    {

    }

    // Remember to have minimum one task that always be true! 
    // It can be an infinite loop in some cases
    public override bool Run()
    {
        Random rnd = new Random();
        while (true)
        {
            Node child = getChildren()[rnd.Next(0, getChildren().Count)];
            bool result = child.Run();
            if (result)
            {
                return true;
            }
        }
    }
}
