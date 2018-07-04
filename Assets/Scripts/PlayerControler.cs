using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour {

    public float Speed;
	public Text countText;
	public Text winText;

    private Rigidbody2D rb2d;
	private int count;

    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
		count = 0;
		winText.text ="";
		SetCountText ();

    }


	void FixedUpdate () 
    {

        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        rb2d.AddForce(movement*Speed);
	}


    //OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
    void OnTriggerEnter2D(Collider2D other) 
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("PickUp"))
                {
                     other.gameObject.SetActive(false);
					 count = count + 1;
					 SetCountText ();
                }
    }

	void SetCountText () 
	{
	 countText.text = "Punkty: " + count.ToString ();
	 if (count >= 13) 
	 {
		winText.text = "Jesteś zwyciężcą!";
	 }
	}

}