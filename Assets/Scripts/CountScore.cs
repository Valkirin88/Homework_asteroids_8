using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpacePatterns
{
    internal sealed class CountScore
    {
        private float _score = 0;
        private float _scoreForHitting = 10f;
        private float _oneThousand = 1000f;
        private float _oneMillion = 1000000f;
        public string ScoreForShowing { get; private set; }
        private Health _health;
        

        public CountScore()
        {
            _health.OnChangedHealth += IncreaseScoreNumber;
            ConvertScoreNmber(_score);
        }

       public void IncreaseScoreNumber()
        {
            _score = _score + _scoreForHitting;
            ScoreForShowing = ConvertScoreNmber(_score);    
        }


        private string ConvertScoreNmber(float currentScore)
        {
            if (currentScore / _oneThousand >= 1 && currentScore / _oneThousand < _oneThousand)
            {
                currentScore /= _oneThousand;
                int score = (int)currentScore;
                string _scoreForShowing = $"{score}" + "K";
            }
            else if (currentScore / _oneThousand >= _oneThousand)
            {
                currentScore /= _oneMillion;
                int score = (int)currentScore;
                string _scoreForShowing = $"{score}" + "M";
            }
            return ScoreForShowing;            
        }
    }
}
