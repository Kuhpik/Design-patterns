using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Others.DoubleBuffer
{
    //Maybe not the best example
    //Cave generator has cleaner reason to use double buffer
    //https://github.com/Habrador/Unity-Programming-Patterns/blob/master/Assets/Patterns/7.%20Double%20Buffer/Cave/GameController.cs

    public class Leaderboard
    {
        List<LeaderboardRecord> _actualRecords = new List<LeaderboardRecord>(32);
        List<LeaderboardRecord> _oldRecords = new List<LeaderboardRecord>(32);

        public void SaveProgress(LeaderboardRecord record)
        {
            _actualRecords.Add(record);
            _actualRecords = _actualRecords.OrderByDescending(x => x.Score).ToList(); //Better just re-sort than create new one.
        }

        //User interested in current top-player
        //He sees interesting info
        //Records in online game can change frequently.
        //So it's easy to lose record you wanna check
        //Leaderboard will not refresh untill user say so.
        public void ShowHighest()
        {
            var record = _oldRecords[0];
            Debug.Log($"Highest: {record.Name} has {record.Score} score!");
        }

        public void ShowByIndex(int index)
        {
            //Subscribed to UI buttons.
            //Will never be out of collection size.

            var record = _oldRecords[index]; 
            Debug.Log($"User {record.Name} has {record.Score} score!");
        }

        public void Refresh()
        {
            Debug.Log("<color=orange>Refreshing...</color>");
            _oldRecords = _actualRecords.ToList();
        }
    }
}