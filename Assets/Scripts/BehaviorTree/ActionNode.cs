using System;

public class ActionNode : Node {
    private Func<bool> action;

    public void SetAction(Func<bool> _action)
    {
        action = _action;
    }

    public ActionNode(Func<bool> _action)
    {
        action = _action;
    }

    public override bool Run()
    {
        return action();
    }
}
