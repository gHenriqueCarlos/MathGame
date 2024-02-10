using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MathGame
{
    public class PlayerDataEx
    {
        
    }
    public class PlayerData
    {
        public int WrongAnswers = 0;
        public int RightAnswers = 0;
        public int Level = 0;

        public PlayerData(bool loadPlayerData) { 
            if(loadPlayerData){
                LoadPlayerData();
            }
        }

        public void LoadPlayerData(){
            WrongAnswers = 0;
            RightAnswers = 0;
            Level = 0;

            // Load Data
        }
        public void SavePlayerData(int WrongAnswers, int RightAnswers, int Level){
            // Save Data
        }
    }
}
