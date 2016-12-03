using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    List<Food> listOfSpawnedFood;

    void Awake () {
        instance = this;
        listOfSpawnedFood = new List<Food>();
	}

    public void AddFoodToList(Food _food)
    {
        listOfSpawnedFood.Add(_food);
    }

    public void RemoveFoodFromList(Food _food)
    {
        listOfSpawnedFood.Remove(_food);
    }

    public List<Food> GetListOfSpawnedFood()
    {
        return listOfSpawnedFood;
    }


	
	
}
