using UnityEngine;
using UnityEngine.Playables; 

public class TriggerCutscene : MonoBehaviour
{
    [SerializeField] PlayableDirector playableDirectorCutscene;
    private bool isTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !isTriggered)
        {
            playableDirectorCutscene.gameObject.SetActive(true);
            playableDirectorCutscene.Play();

            isTriggered = true;
        }

    }

}
