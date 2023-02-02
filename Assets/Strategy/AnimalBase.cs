using UnityEngine;

namespace Strategy
{
    public abstract class AnimalBase : MonoBehaviour
    {
        #region  Variable
        protected float _speed = 0.2f;
        protected float _timer = 4;
        protected ISpeak _speakBehaviour;
        protected IMove _moveBehaviour;
        protected ISleep _sleepBehaviour;
        protected IEat _eatBehaviour;
        protected IFly _flyBehaviour;
        protected ISwim _swimBehaviour;
        protected ICanNot _canNotBehaviour;
        #endregion

        #region  Interface init
        public void SetMoveBehaviour(IMove moveBehaviour)
        {
            _moveBehaviour = moveBehaviour;
        }
        public void SetSpeakBehaviour(ISpeak speakBehaviour)
        {
            _speakBehaviour = speakBehaviour;
        }
        public void SetSleepBehaviour(ISleep sleepBehaviour)
        {
            _sleepBehaviour = sleepBehaviour;
        }
        public void SetEatBehaviour(IEat eatBehaviour)
        {
            _eatBehaviour = eatBehaviour;
        }
        public void SetFlyBehaviour(IFly flyBehaviour)
        {
            _flyBehaviour = flyBehaviour;
        }
        public void SetSwimBehaviour(ISwim swimBehaviour)
        {
            _swimBehaviour = swimBehaviour;
        }
        public void SetCanNotBehaviour(ICanNot canNotBehaviour)
        {
            _canNotBehaviour = canNotBehaviour;
        }
        #endregion

        #region BaseMeth
        protected void Speak() => _speakBehaviour.Speak();
        protected void Sleep() => _sleepBehaviour.Sleep();
        protected void Move() => _moveBehaviour.Move();
        protected void Eat() => _eatBehaviour.Eat();
        protected void Fly() => _flyBehaviour.Fly();
        protected void Swim() => _swimBehaviour.Swim();
        protected void CanNot() => _canNotBehaviour.CanNot();
        #endregion
    }
}