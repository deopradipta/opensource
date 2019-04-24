using System.Collections; 
using UnityEngine;
using UnityEngine.SceneManagement;

public class optionmenu : MonoBehaviour {

    public void optiontomenu (int Option){
        SceneManager.LoadScene(Option);
    }
}
