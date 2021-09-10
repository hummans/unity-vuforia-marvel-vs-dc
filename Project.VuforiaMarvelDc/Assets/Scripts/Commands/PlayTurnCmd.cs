using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using ViewModel;

namespace Commands
{
    public class PlayTurnCmd : MonoBehaviour, ICommand
    {
        private GameData gameData;
        private PlayerCharacter player1;
        private PlayerCharacter player2;

        public PlayTurnCmd(PlayerCharacter player1, PlayerCharacter player2, GameData gameData)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.gameData = gameData;
        }
        
        public void Execute()
        {
            gameData.currentCharacters.Add(player1);
            gameData.currentCharacters.Add(player2);
        }
    }
}