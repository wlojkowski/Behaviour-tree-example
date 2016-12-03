using UnityEngine;
using System.Collections;

public class CharacterBehaviour : Behavior {

    ActionNode isHungryNode;
    ActionNode wanderNode;
    ActionNode searchFoodNode;
    ActionNode useObject;

    Sequence searchFoodSequence;
    Selector root;

    CharacterProperties characterProperties;
    CharacterController characterController;

	void Start () {
        characterProperties = GetComponent<CharacterController>().characterProperties;
        characterController = GetComponent<CharacterController>();

        isHungryNode = new ActionNode(characterController.isHungry);
        wanderNode = new ActionNode(characterController.Wander);
        searchFoodNode = new ActionNode(characterController.FindFood);
        useObject = new ActionNode(characterController.UseObject);

        searchFoodSequence = new Sequence(isHungryNode);
        searchFoodSequence.addChild(isHungryNode);
        searchFoodSequence.addChild(searchFoodNode);
        searchFoodSequence.addChild(wanderNode);
        searchFoodSequence.addChild(useObject);

        root = new Selector(searchFoodSequence);
        root.addChild(wanderNode);

	}

    void FixedUpdate()
    {
        root.Run();
    }
	
}
