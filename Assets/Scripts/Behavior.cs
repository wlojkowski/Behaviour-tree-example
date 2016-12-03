using UnityEngine;
using System.Collections;

public class Behavior : MonoBehaviour {

    public virtual bool Use(GameObject _user)
    {
        return false;
    }
}
