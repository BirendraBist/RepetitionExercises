namespace RepetitionExercises
{
    // This class defines a Home Theater (HT) system. 
    // It consists of: 
    // a TV, a Blu-Ray player and 2 speakers
    public class HomeTheater
    {
        public HomeTheater()
        {
        }

        // Shift between the "Turn On" and the "Turn off" states for the system.
        // You do it by performing this operation on all devices of the system.
        public void ToggleOnOff()
        {
        }

        // Turn up the volume of both speakers
        public void IncreaseVolume()
        {
        }

        // Turn down the volume of both speakers
        public void DecreaseVolume()
        {
        }

        // Switch to the next channel (channel immediately after the
        // current channel) on the TV.
        public void IncreaseChannel()
        {
        }

        // Switch to the next channel (channel immediately before the
        // current channel) on the TV.
        public void DecreaseChannel()
        {
        }

        // Start playing on the Blu-Ray player
        public void PlayDevice()
        {
        }

        // Stop playing on the Blu-Ray player
        public void StopDevice()
        {
        }

        // Returns the status of the entire system, in the form of a string.
        // Replace "???" with the name of the instance field you have
        // defined for each of the four devices in the HT system.
        public override string ToString()
        {
            string status = "Current status of Home Theater\n";
            status += "------------------------------\n";
            //status += $"Smart TV       : {ConvertOnOff(???.IsOn)}, showing channel {ConvertChannelNo(???.Channel)}\n";
            //status += $"Blu-Ray player : {ConvertOnOff(???.IsOn)}, is {ConvertBluRayStatus(???.IsPlaying)}\n";
            //status += $"Left Speaker   : {ConvertOnOff(???.IsOn)}, is at volume {???.CurrentVolume}\n";
            //status += $"Right Speaker  : {ConvertOnOff(???.IsOn)}, is at volume {???.CurrentVolume}\n";

            return status;
        }

        #region Private metoder
        private string ConvertOnOff(bool onOff)
        {
            return onOff ? "On" : "Off";
        }

        private string ConvertChannelNo(int channelNo)
        {
            return channelNo == 0 ? "(No channel)" : channelNo.ToString();
        }

        private string ConvertBluRayStatus(bool isPlaying)
        {
            return isPlaying ? "Playing" : "Stopped";
        } 
        #endregion
    }
}