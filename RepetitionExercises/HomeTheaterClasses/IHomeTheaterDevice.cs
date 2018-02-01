namespace RepetitionExercises
{
    // Minimal interface for "devices", 
    
    public interface IHomeTheaterDevice
    { 
        bool IsOn { get; }
        void ToggleOnOff();
    }
}