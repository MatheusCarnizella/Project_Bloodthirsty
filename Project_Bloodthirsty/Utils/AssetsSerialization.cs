using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Project_Bloodthirsty.Utils
{
    public static class AssetsSerialization
    {

        public static readonly string SFX_EXTENSION = ".wav";
        public static readonly string SFX_FOLDER = "Musicas";
        public static readonly string DEFAULT_PATH = "";

        public static Dictionary<string, SoundPlayer> sfxDictionary = new Dictionary<string, SoundPlayer>();

        public static string GetRootDirectory()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            return Path.GetFullPath(Path.Combine(baseDirectory + @"..\..\"));
        }

        public static string GetRootDirectory(string pathDirectory)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            return Path.GetFullPath(Path.Combine(baseDirectory + @"..\..\" + pathDirectory));
        }

        public static void LoadAllAssets_SFX()
        {
            string[] sfxFiles = Directory.GetFiles(GetRootDirectory(SFX_FOLDER));
            foreach (string sfx in sfxFiles)
            {
                SoundPlayer sfxPlayer = new SoundPlayer() {
                    SoundLocation = sfx
                };
                string fileName = Path.GetFileName(sfx);
                sfxDictionary.Add(fileName, sfxPlayer);
            }

            Console.WriteLine("----- LOADING SFX ASSETS -----");
            int i = 0;
            foreach (KeyValuePair<string, SoundPlayer> sfx in sfxDictionary)
            {
                Console.WriteLine($"[{i}] - SFX FileName: {sfx.Key}");
                Console.WriteLine($"[{i}] - SFX SoundPlayer.SoundLocation: {sfx.Value.SoundLocation}");
                i++;
            }
            Console.WriteLine("----- ASSETS LOADED -----");
        }

        public static SoundPlayer GetSoundPlayerSFX(string sfxFileName)
        {
            sfxFileName += SFX_EXTENSION;
            if (sfxDictionary.TryGetValue(sfxFileName, out SoundPlayer sfxSoundPlayer))
            {
                Console.WriteLine($"Sound file found with name: {sfxFileName} !");
                return sfxSoundPlayer;
            }
            else
            {
                Console.WriteLine($"Impossible to find file with name: {sfxFileName} !");
                return null;
            }
        }

    }
}
