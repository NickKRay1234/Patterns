using TMPro;

namespace Strategy
{
    public class TestAnimal : AnimalBase
    {
        private TextMeshProUGUI _text;

        private void Start()
        {
            SetSleepBehaviour(new SleepBehaviour(_text));
            
            Sleep();
        }
    }
}