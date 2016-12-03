using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {
    public CharacterProperties characterProperties;

    Rigidbody rb;

    public Transform target;

    void Awake()
    {
        characterProperties = new CharacterProperties("Marcus", 10);
        StartCoroutine(decreaseFood());
        rb = GetComponent<Rigidbody>();
    }


    public bool Wander()
    {
        if (Vector3.Distance(rb.position, target.position) < 1f)
        {
            return true;
        }
        target.position = new Vector3(target.position.x, transform.position.y, target.position.z);
        Vector3 dir = (target.position - transform.position).normalized;
        rb.MovePosition(transform.position + dir * 5f * Time.deltaTime);
        return false;
    }

    IEnumerator decreaseFood()
    {
        while (true)
        {
            characterProperties.Food -= Time.deltaTime * 5f;
            yield return new WaitForSeconds(2f);
        }
    }

    public void AddFood(int _value)
    {
        characterProperties.Food += _value;
    }

    public bool isHungry()
    {
        if (characterProperties.Food < 20)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool FindFood()
    {
        Food f = GameManager.instance.GetListOfSpawnedFood()[0];
        if (f != null)
        {
            target = f.transform;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool UseObject()
    {
        return target.GetComponent<Behavior>().Use(this.gameObject);
    }
}
