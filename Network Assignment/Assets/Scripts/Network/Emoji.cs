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
            OnEmote();
        }
    }


    private void OnEmote()
    {
        NetworkObject networkObject = GetComponent<NetworkObject>();
        if (IsClient && networkObject != null && networkObject.IsOwner)
        {
            EmoteRpc(networkObject.OwnerClientId);
        }
 
    }

    private void OnEmote2()
    {
        NetworkObject networkObject = GetComponent<NetworkObject>();
        if (IsClient && networkObject != null && networkObject.IsOwner)
        {
            EmoteRpc(networkObject.OwnerClientId);
        }

    }

    [Rpc(SendTo.Server)]
    private void EmoteRpc(ulong playerId)
    {
        //Debug.Log("We are the owner of our player emoting");

        emoji.SetActive(true);
        StartCoroutine(DisableAfterTime(3f));
    }

    private IEnumerator DisableAfterTime(float delay)
    {
        yield return new WaitForSeconds(delay);
        emoji.SetActive(false);
    }

    public void Emote1() 
    {
        Debug.Log("We are the owner of our player emoting");
                 
        emoji.SetActive(true);
        StartCoroutine(DisableAfterTime(3f));
    }


}
