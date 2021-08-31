using UnityEngine;
using UniRx;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "Fight", menuName = "Scriptable/Character Fight")]
    public class CharacterFight : ScriptableObject
    {
        public int damage;
        public float force;
        public int range;
        public int rate;
        public ISubject<CharacterMotion> OnCharacterAttack = new Subject<CharacterMotion>();
    }
}