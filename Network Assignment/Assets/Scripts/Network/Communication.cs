//using UnityEngine;
//using System.Collections;
//using Unity.Netcode;

//public class Communication : NetworkBehaviour
//{
//    [SerializeField] GameObject emoji;

//    bool isEmoting = false;
//    private GameObject emoteActive = null;

//    [ServerRpc(RequireOwnership = false)]

//    public void EmoteServer(ulong clientId)
//    {
//        if (emoji != null)
//        {
//            if (isEmoting)
//            {
//                emoteActive.GetComponent<NetworkObject>().Despawn();
//            }
//            else
//            {
//                GameObject Emote = Instantiate(emoji, transform);
//                Emote.GetComponent<NetworkObject>().Spawn();
//                emoteActive = Emote;
//            }

//            isEmoting = !isEmoting;
//        }

//        Emote(clientId);
//    }

//    [ClientRpc]

//    public void Emote(ulong clientId)
//    {
//        Debug.Log("Client with ID " + clientId + " is trying to emote");
//    }

//}
     