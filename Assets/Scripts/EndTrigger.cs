using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        Debug.Log("asd");
        gameManager.completeLevel();
    }

}
