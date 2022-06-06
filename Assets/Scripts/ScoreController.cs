using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpacePatterns
{
    internal sealed class ScoreController 
    {
        private readonly CountScore _countScore;
        private readonly ScoreView _scoreView;
        private Health _health;

        public ScoreController()
        {
            _countScore = new CountScore();
            _scoreView = new ScoreView();
            _health.OnChangedHealth += ShowScore; 
        }

        public void ShowScore()
        {
            _scoreView.Score = _countScore.ScoreForShowing;
        }



    }
}
