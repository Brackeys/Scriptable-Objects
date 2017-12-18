using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {

	public Card card;

	public Text nameText;
	public Text descriptionText;

	public Image artworkImage;

	public Text manaText;
	public Text attackText;
	public Text healthText;

	// Use this for initialization
	void Start () {
		nameText.text = card.name;
		descriptionText.text = card.description;

		artworkImage.sprite = card.artwork;

		manaText.text = card.manaCost.ToString();
		attackText.text = card.attack.ToString();
		healthText.text = card.health.ToString();
	}
	
}
