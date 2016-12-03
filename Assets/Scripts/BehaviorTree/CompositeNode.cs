using UnityEngine;
using System.Collections.Generic;

public class CompositeNode : Node {
    List<Node> children;
    
    public CompositeNode(Node _child)
    {
        children = new List<Node>();
        addChild(_child);
    }

    public CompositeNode(List<Node> _childrenList)
    {
        children = new List<Node>();
        addChildren(_childrenList);
    }

    public List<Node> getChildren()
    {
        return children;
    }  
    
    public void addChildren(List<Node> _childrenList)
    {
        children.AddRange(_childrenList);
    }  

    public void addChild(Node child)
    {
        children.Add(child);
    }
	
}
