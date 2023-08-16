using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "Player Data", order = 1)]
    public class PlayerData : ScriptableObject
    {
        public List<PartyCharacter> characters = new List<PartyCharacter>();

        public void initializeParty()
        {
            var medusa = PartyCharacter.newMedusa();
            
            characters.Add(medusa);
        }
    }

    public class PartyCharacter
    {
        public string charName;
        public float maxHp;

        public static PartyCharacter newMedusa()
        {
            var medusa = new PartyCharacter();
            medusa.charName = "medusa";
            medusa.maxHp = 70f;

            return medusa;
        }
    }
}