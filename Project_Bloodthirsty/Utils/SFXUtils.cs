using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using Project_Bloodthirsty.Utils;

namespace Project_Bloodthirsty.SFXUtils
{
    public static class SFXUtility
    {

        public const string SFX_EXTENSION = ".wav";
        public const string SFX_FOLDER = "Musicas";

        private static Dictionary<string, SoundPlayer> sfxDictionary = new Dictionary<string, SoundPlayer>();

        public static void LoadAllAssets_SFX(bool logSFXLoading = false)
        {
            string[] sfxFiles = Directory.GetFiles(Utility.GetRootDirectory(SFX_FOLDER));
            foreach (string sfx in sfxFiles)
            {
                SoundPlayer sfxPlayer = new SoundPlayer(sfx);
                string fileName = Path.GetFileName(sfx);
                sfxDictionary.Add(fileName, sfxPlayer);
            }

            if (logSFXLoading)
            {
                Console.WriteLine("----- LOADING SFX ASSETS -----");
                int i = 0;
                foreach (KeyValuePair<string, SoundPlayer> sfx in sfxDictionary)
                {
                    Console.WriteLine($"[{i}] - SFX FileName: {sfx.Key}");
                    Console.WriteLine($"[{i}] - SFX SoundPlayer.SoundLocation: {sfx.Value.SoundLocation}");
                    i++;
                }
                Console.WriteLine("----- SFX ASSETS LOADED -----");
            }
        }

        public static SoundPlayer GetSpecificSoundPlayerSFX(string sfxFileName = "")
        {
            sfxFileName += SFX_EXTENSION;
            if (sfxDictionary.ContainsKey(sfxFileName))
            {
                if (sfxDictionary.TryGetValue(sfxFileName, out SoundPlayer sfxSoundPlayer))
                {
                    if (sfxSoundPlayer != null)
                    {
                        Console.WriteLine($"GetSpecificSoundPlayerSFX() -> Sound file found with name: {sfxFileName} !");
                        return sfxSoundPlayer;
                    }

                    Console.WriteLine($"GetSpecificSoundPlayerSFX() -> Key with value: {sfxFileName} found! But the 'SoundPlayer' value was not found...'");
                    return null;
                }
                else
                {
                    Console.WriteLine($"GetSpecificSoundPlayerSFX() -> Impossible to find file with name: {sfxFileName} !");
                    return null;
                }
            }

            Console.WriteLine($"GetSpecificSoundPlayerSFX -> Key with value: {sfxFileName} not found!");
            return null;
        }

    }
}
