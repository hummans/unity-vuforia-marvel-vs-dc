using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UniRx;
using Commands;

namespace Components
{
    public class CharacterAttackInput : MonoBehaviour
    {
        public GameFactoryCmd gameFactoryCmd; 
        public Character character;

        void OnTriggerEnter(Collider collider)
        {
            // Attack
            IDamage damagable = collider.gameObject.GetComponent<IDamage>();
            if(damagable != null)
            {
                Debug.Log("Trigger enter!!");
                gameFactoryCmd.PerfomAttack(character.characterData, character.figthSystem, damagable.damageSystem).Execute();
            }
        }
    }
}
