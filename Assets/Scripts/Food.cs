using UnityEngine;
using System.Collections;

public class Food : Behavior {
    public int foodValue;
    public bool canBePrepared;
    bool isPrepared;

    Selector root;
    Repeater eatRepeater;
    Sequence preparingSequence;

    ActionNode eatNode;
    ActionNode canBePreparedNode;
    ActionNode prepareFoodNode;

    GameObject user;

	void Start () {
        GameManager.instance.AddFoodToList(this);

        eatRepeater = new Repeater(0, foodValue);
        canBePreparedNode = new ActionNode(canBePreparedCheck);
        prepareFoodNode = new ActionNode(PrepareFood);
        eatNode = new ActionNode(Eat);
        preparingSequence = new Sequence(canBePreparedNode);

        preparingSequence.addChild(prepareFoodNode);
        preparingSequence.addChild(eatRepeater);
        eatRepeater.SetChild(eatNode);

        root = new Selector(preparingSequence);

        root.addChild(eatRepeater);
	}

    public override bool Use(GameObject _user)
    {
        user = _user;
        return root.Run();
    }


    public bool canBePreparedCheck()
    {
        if (canBePrepared == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool Eat()
    {
        user.GetComponent<CharacterController>().AddFood(foodValue);
        return true;
    }

    bool PrepareFood()
    {
        GetComponent<Renderer>().material.color = Color.red;
        return true;
    }
}
