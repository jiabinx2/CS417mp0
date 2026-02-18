using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public DoorOpen door;

    bool A_done = false;
    bool B_done = false;
    bool C_done = false;

    public void PairCompleted(string type)
    {
        if(type == "Cube") A_done = true;
        if(type == "Doll") B_done = true;
        if(type == "Chess") C_done = true;

        CheckWin();
    }

    void CheckWin()
    {
        if(A_done && B_done && C_done)
        {
            Debug.Log("YOU WIN");
            door.OpenDoor();
        }
    }
}

