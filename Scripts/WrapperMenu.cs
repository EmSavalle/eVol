using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapperMenu : MonoBehaviour {
	// Update is called once per frame
	public void onLoadGameClick() {

        SceneLoaderSystem.instance.onLoadGame();
		
	}

}
