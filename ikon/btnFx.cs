using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnFx : MonoBehaviour {

    public AudioSource myFx;
    public AudioClip clickFx;

    public void loadNextScene()
    {
        StartCoroutine(LoadngLevel());
    } 
    
    IEnumerator LoadngLevel()
    {
        yield return new WaitForSeconds(1f);
        Application.LoadLevel("option");
    }

    public void ClickSound()
    {
        myFx.PlayOneShot(clickFx);
    }
}
