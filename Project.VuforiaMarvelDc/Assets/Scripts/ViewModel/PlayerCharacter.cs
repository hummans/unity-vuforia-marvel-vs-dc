using UnityEngine;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "PlayerCharacter", menuName = "Scriptable/Player Character")]
    public class PlayerCharacter : ScriptableObject
    {
        public int id;
        public CharacterData characterData;
        public CharacterFight characterFight;
        public CharacterDamage characterDamage;
    }
}