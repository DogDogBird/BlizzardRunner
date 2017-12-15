using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class MyNetworkManager : NetworkManager {

	public Button Character1Button;
	public Button Character2Button;
	public Button Character3Button;
	public Button Character4Button;
	public Button Character5Button;
	public Button Character6Button;
	public Button Character7Button;

	int avatarIndex = 0;
	// Use this for initialization
	void AvatarPicker(string buttonName)
	{
		switch (buttonName) {
		case "루시우":
			avatarIndex = 0;
			break;
		case "망령군마":
			avatarIndex = 1;
			break;
		case "개개비":
			avatarIndex = 2;
			break;
		}
		playerPrefab = spawnPrefabs[avatarIndex];
	}

	void Start () {
		Character1Button.onClick.AddListener (delegate { AvatarPicker(Character1Button.name);});
		Character2Button.onClick.AddListener (delegate { AvatarPicker(Character2Button.name);});
		Character3Button.onClick.AddListener (delegate { AvatarPicker(Character3Button.name);});
		Character4Button.onClick.AddListener (delegate { AvatarPicker(Character4Button.name);});
		Character5Button.onClick.AddListener (delegate { AvatarPicker(Character5Button.name);});
		Character6Button.onClick.AddListener (delegate { AvatarPicker(Character6Button.name);});
		Character7Button.onClick.AddListener (delegate { AvatarPicker(Character7Button.name);});


		}
}


	
	

