using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using ViewModel;

namespace Components
{
    public class Character : MonoBehaviour, IDamage, IFight
    {
        [SerializeField] private CharacterData _characterData;
        public CharacterData characterData { get; set; }

        [SerializeField] private CharacterFight _fightSystem;
        public CharacterFight figthSystem { get; set; }

        [SerializeField] private CharacterDamage _damageSystem;
        public CharacterDamage damageSystem { get; set; }

        void Awake()
        {
            this.characterData = _characterData;
            this.figthSystem = _fightSystem;
            this.damageSystem = _damageSystem;
            
            damageSystem.currentLife.Value = damageSystem.maximumLife;
        }
    }
}
