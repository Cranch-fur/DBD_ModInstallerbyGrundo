namespace Dead_By_Daylight_Mod_Installer.Model
{
    public interface ISettingsRepository
    {
        Settings Settings { get; }

        void SaveSettings();
    }
}
