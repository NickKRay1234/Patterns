using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Strategy
{
    public class Dog : AnimalBase
    {
        public Dictionary<string, Action> behaviours;
        [SerializeField] private Material _material;
        [SerializeField] private TextMeshProUGUI _text;
        private float _timer = 4;

        private void Awake()
        {
            SetSpeakBehaviour(new WoofBehaviour(_text));
            SetSleepBehaviour(new SleepBehaviour(_text));

            behaviours = new Dictionary<string, Action>()
            {
                { "speak", Speak },
                { "sleep", Sleep },
            };
        }
        
        
    }
}