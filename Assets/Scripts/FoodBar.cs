using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FoodBar : MonoBehaviour {

    CharacterProperties characterProperties;
    public Text foodTxt;
	// Use this for initialization
	void Start () {
        characterProperties = transform.parent.GetComponent<CharacterController>().characterProperties;
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Camera.main.transform);
        foodTxt.text = "Food: " + Mathf.RoundToInt(characterProperties.Food);
	}
}
