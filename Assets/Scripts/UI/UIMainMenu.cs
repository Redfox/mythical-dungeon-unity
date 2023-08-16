using UnityEngine;
using UnityEngine.UI;
using Player;

namespace UI
{
    public class UIMainMenu : MonoBehaviour
    {
        [SerializeField] private Button startGame;
        public PlayerData player;
    
        void Start()
        {
            startGame.onClick.AddListener(StartGame);
        }

        private void StartGame()
        {
            player.initializeParty();
            ScenesManager.Instance.LoadLobby();
        }
    }
}
