using UnityEngine;
using System.Collections;

public class Root : Node {
    Node child;

    public override bool Run()
    {
        return child.Run();
    }


    public Node GetChild()
    {
        return child;
    }

    public void SetChild(Node newChild)
    {
        child = newChild;
    }

}
