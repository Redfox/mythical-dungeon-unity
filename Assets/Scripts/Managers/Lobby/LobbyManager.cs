using Player;
using UnityEngine;
using UnityEngine.UI;

namespace Managers.Lobby
{
    public class LobbyManager : MonoBehaviour
    {
        [SerializeField] private Button continueButton;
        public PlayerData player;
    
        // Start is called before the first frame update
        void Start()
        {
            continueButton.onClick.AddListener(() => { ScenesManager.Instance.LoadScene(ScenesManager.Scene.Map); });
        
            foreach (var character in player.characters)
            {
                Debug.Log(character.charName);
            }
        }
    }
}
