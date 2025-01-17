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
            StartCoroutine(DisableAfterTime(3f)); // Start the coroutine with a 3-second timer
        }
    }

    private IEnumerator DisableAfterTime(float delay)
    {
        yield return new WaitForSeconds(delay); // Wait for the specified delay
        Emoji.SetActive(false); // Disable the Emoji game object
    }
}
