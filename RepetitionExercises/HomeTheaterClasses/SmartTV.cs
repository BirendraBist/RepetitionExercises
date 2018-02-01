namespace RepetitionExercises
{
    // This class models a very simple Smart TV,
    // which can turn on  and turn Down and where we can  shift the channel.
    public class SmartTV
    {
        private const int MinChannel = 1;
        private const int MaxChannel = 100;

        private bool _isOn;
        private int _channel;

        public SmartTV()
        {
            _isOn = false;
            _channel = 0;
        }

        public bool IsOn
        {
            get { return _isOn; }
        }

        // Shift the channel, unless the new value is not valid
        //  jf. min- og max-values for the channel.
        public int Channel
        {
            get { return _channel; }
            set
            {
                if (value >= MinChannel && value <= MaxChannel && IsOn)
                {
                    _channel = value;
                }
            }
        }
        
        // Shift between the "Turn On" and the "Turn off" states for the system.
        // when TV turns down , the channel is 0 
        // when TV turn up , the channel is 1.
        public void ToggleOnOff()
        {
            _isOn = !_isOn;

            if (_isOn)
            {
                _channel = 1;
            }
            if (!_isOn)
            {
                _channel = 0;
            }
        }
    }
}