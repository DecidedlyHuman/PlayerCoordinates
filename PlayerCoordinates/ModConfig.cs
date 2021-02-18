using StardewModdingAPI;

namespace PlayerCoordinates
{
    public class ModConfig
    {
        public SButton CoordinateHUDToggle  { get; } = SButton.F8;
        public SButton LogCoordinates { get; set; } = SButton.F9;
        public SButton SwitchToCursorCoords { get; set; } = SButton.F10;
    }
}