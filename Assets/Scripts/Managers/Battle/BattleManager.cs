using UnityEngine;

namespace Managers.Battle
{
    public class BattleManager : MonoBehaviour
    {
        [SerializeField] private GameObject medusaPrefab;
        [SerializeField] private GameObject beholderPrefab;
        
        void Start()
        {
            SpawnCharacters();
        }

        private void SpawnCharacters()
        {
            Instantiate(medusaPrefab, new Vector3(-7, -0.8f, 0), Quaternion.identity);
            Instantiate(beholderPrefab, new Vector3(6.8f, -0.8f, 0), Quaternion.identity);
        }
    }
}
