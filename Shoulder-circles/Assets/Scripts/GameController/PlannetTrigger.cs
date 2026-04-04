using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlannetTrigger : MonoBehaviour
{
    public float rotationspeed=0.05f;
    void Update()
    {
        transform.Rotate(0,rotationspeed,0);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SpaceCraft")
        {
            GameStateManager.Instance.SetState(GameStateManager.GameState.Lose);
        }
    }
}
