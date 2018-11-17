using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Character {

	// Update is called once per frame
	protected override void Update ()
    {
        GetInput();

        base.Update();
	}

    private void GetInput()
    {
        direction = Vector2.zero;

        if(Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector2.right;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector2.down;
        }
    }
}
