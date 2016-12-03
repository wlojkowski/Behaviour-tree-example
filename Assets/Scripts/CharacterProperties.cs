using UnityEngine;
using System.Collections;

public class CharacterProperties{

    string name;
    float food;

    public CharacterProperties(string _name, float _food)
    {
        name = _name;
        food = _food;
    }

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }


    public float Food
    {
        get
        {
            return food;
        }

        set
        {
            food = value;
        }
    }
    
}
