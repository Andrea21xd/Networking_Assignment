using UnityEngine;
using System.Collections;
using Unity.Netcode;

public class Emoji : NetworkBehaviour
{

    [SerializeField] GameObject emoji;
    



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Emote();
        }
    }




    public void Emote() 
    {
        Debug.Log("We are the owner of our player emoting");
                 
        emoji.SetActive(true);
        StartCoroutine(DisableAfterTime(3f));
    }

    private IEnumerator DisableAfterTime(float delay)
    {
        yield return new WaitForSeconds(delay);
        emoji.SetActive(false);
    }





}
