using UnityEngine;
using UnityEngine.EventSystems;

namespace Managers.Map
{
    public class MapPhase : MonoBehaviour, IPointerClickHandler
    {
        public string phaseName;
    
        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("Click " + phaseName);
            ScenesManager.Instance.LoadScene(ScenesManager.Scene.Battle);
        }
    }
}
