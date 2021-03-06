﻿using FitnessApp.Models;
using FitnessApp.SQLserver;
using System.Collections.Generic;

namespace FitnessApp.ViewModels
{
    class ChallengesViewModel
    {
       
        private List<ChallengeModel> allChallengeModels;
        private List<ChallengeModel> uncompletedJoinedChallengeModels = new List<ChallengeModel>();
        private List<ChallengeModel> completedJoinedChallengeModels = new List<ChallengeModel>();


        public ChallengesViewModel() { }

        public void AllChallengesViewModel(int accountID)
        {
            allChallengeModels = Database.GetAllChallenges(accountID);
        }

        public void JoinedChallengesViewModel(int accountID)
        {

            List<ChallengeModel> joinedChallengeModels = Database.GetJoinedChallenges(accountID);

            foreach (var item in joinedChallengeModels)
            {
                // Classify Challenges
                if (item.Progress < item.TargetMinutes)
                    uncompletedJoinedChallengeModels.Add(item);
                else
                    completedJoinedChallengeModels.Add(item);
            }

        }

        public List<ChallengeModel> AllChallengeModels
        {
            get => allChallengeModels;
            set { }
        }

        public List<ChallengeModel> UncompletedJoinedChallengeModels
        {
            get => uncompletedJoinedChallengeModels;
            set { }
        }

        public List<ChallengeModel> CompletedJoinedChallengeModels
        {
            get => completedJoinedChallengeModels;
            set { }
        }
    }
}
