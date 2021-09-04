using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UniRx;
using Commands;
using System;

namespace Components
{
    public class CharacterAttackInput : MonoBehaviour
    {
        public GameFactoryCmd gameFactoryCmd; 
        public Character character;
 
        void OnTriggerEnter(Collider collider)
        {
            // Attack
            ICharacter characterCollision = collider.gameObject.GetComponent<ICharacter>();
            IDamage damagableCollision = collider.gameObject.GetComponent<IDamage>();

            if(damagableCollision != null & characterCollision != null & character.GetAttackState())
            {
                if(characterCollision.characterData.characterId != character.characterData.characterId)
                {
                    // If is not the player
                    Debug.Log($"Trigger enter in damagable ({characterCollision.characterData.characterName} with position {character.GetCharacterPosition()})");
                    gameFactoryCmd.PerfomAttack(character.characterData, character.figthSystem, characterCollision.characterData, damagableCollision.damageSystem).Execute();
                }
                else 
                {
                    Debug.Log("Trigger enter is not accepted because is the player");
                }
            }
            else 
            {
                Debug.Log("[CharacterAttackInput] Trigger enter but doesn't have damagable");
            }
        }
    }
}
