using UnityEngine;
using System.Collections;

public class EmojiController : MonoBehaviour
{
    public GameObject Emoji;

    void Update()
    {    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Emoji.SetActive(true);
            StartCoroutine(DisableAfterTime(3f)); 
        }
    }

    private IEnumerator DisableAfterTime(float delay)
    {
        yield return new WaitForSeconds(delay); 
        Emoji.SetActive(false); 
    }
}
