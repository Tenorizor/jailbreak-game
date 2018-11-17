using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField]
    private float speed; //how fast character moves

    protected Vector2 direction;
	
	// Update is called once per frame
	protected virtual void Update ()
    {
        Move(); //calls move class
    }
    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);

    }
}
