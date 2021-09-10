using UnityEngine;
using UniRx;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "Fight", menuName = "Scriptable/Character Fight")]
    public class CharacterFight : ScriptableObject
    {
        public int damage;
        public float force;
        public int rate;
        [Range(10,100)] public float distanceAttack;

        public IntReactiveProperty nextAttack {get; set;}
        public ISubject<CharacterMotion> OnCharacterAttack = new Subject<CharacterMotion>();
    }
}