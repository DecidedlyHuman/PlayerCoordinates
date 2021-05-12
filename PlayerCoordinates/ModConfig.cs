using StardewModdingAPI;

namespace PlayerCoordinates
{
    public class ModConfig
    {
        public SButton CoordinateHUDToggle { get; set; } = SButton.F5;
        public SButton LogCoordinates { get; set; } = SButton.F6;
        public SButton SwitchToCursorCoords { get; set; } = SButton.F7;
    }
}