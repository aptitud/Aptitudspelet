using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoRandomizer : MonoBehaviour
{
    public Sprite[] sprites;
    
	void Start ()
	{
	    var spriteIndex = Random.Range(0, sprites.Length);

        var spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	    spriteRenderer.sprite = sprites[spriteIndex];
	}
}
