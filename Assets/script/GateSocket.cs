using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GateSocket : MonoBehaviour
{
    public string acceptedType; // A/B/C
    public PuzzleManager manager;

    private void OnEnable()
    {
        GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>().selectEntered.AddListener(OnInsert);
    }

    private void OnDisable()
    {
        GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>().selectEntered.RemoveListener(OnInsert);
    }

    private void OnInsert(SelectEnterEventArgs args)
    {
        ItemType item = args.interactableObject.transform.GetComponent<ItemType>();
        if(item != null && item.type == acceptedType)
        {
            manager.PairCompleted(acceptedType);
            Debug.Log("Pair Completed: " + acceptedType);
        }
    }
}

