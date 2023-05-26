using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmaDisplay : MonoBehaviour
{
	public ScriptableObjects scriptableObject;
	public Text nombreText;
	public Text precioText;
	public Image spriteImage;

    void Start()
    {
	nombreText.text = scriptableObject.nombre;
	precioText.text = scriptableObject.price;
	spriteImage.sprite = scriptableObject.sprite;
    }

  
}
