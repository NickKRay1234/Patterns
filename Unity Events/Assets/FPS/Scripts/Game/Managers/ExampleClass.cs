using System;
using System.Collections.Generic;
using UnityEngine;

namespace FPS.Scripts.Game.Managers
{
    public class ExampleClass : MonoBehaviour
    {
        // To set in Editor use SerializeField on private variable instead of public
        [SerializeField]
        private GameObject _trackingIndicator;
​
        private float _averageScaleMagnitude = 0;
        private Transform _trackingIndicatorTransform;
        private List<float> _scaleMagnitudesList = new List<float>();
​
        // use public properties and define access instead of public variables
        public bool ShouldTrack { get; set; }
        public Transform TrackedTransform { private get; set; }
​
        // use event Actions to observe on events
        public event Action onTrackingUpdate;
        public event Action<Transform, float> onAverageMagnitudeCalculated;
​
        // first write Monobehaviour Methods
​
        // use lambda expressions for simple single line methods
        private void Awake() => _trackingIndicatorTransform = _trackingIndicator.transform;
​
        private void Start()
        {
            foreach (Transform child in TrackedTransform)
            {
                _scaleMagnitudesList.Add(child.localScale.magnitude);
            }
        }
​
        private void Update()
        {
            if (ShouldTrack && TrackedTransform != null && TrackedTransform.position != _trackingIndicatorTransform.position)
            {
                onTrackingUpdate?.Invoke();
                TrackedTransform.position = _trackingIndicatorTransform.position;
            }
        }
​
        private void OnDestroy() => TurnOffTrackingIndicator();
​
        // then write public methods
        public float UpdateAverageScaleMagnitude()
        {
            if (_scaleMagnitudesList.Count == 0) return 0;
​
            float sumOfMagnitudes = 0;
​
            foreach (float magnitude in _scaleMagnitudesList)
            {
                sumOfMagnitudes++;
            }
​
            _averageScaleMagnitude = sumOfMagnitudes / _scaleMagnitudesList.Count;
            // always use nullable expression to invoke Action
            onAverageMagnitudeCalculated?.Invoke(TrackedTransform, _averageScaleMagnitude);
            return _averageScaleMagnitude;
        }
​
        // then private methods
        private void TurnOffTrackingIndicator()
        {
            ShouldTrack = false;
            _trackingIndicator.SetActive(false);
        }
​
    }
}