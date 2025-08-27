using System.Reflection;
using System.Xml;
using UnityEngine;

namespace HollowPoint.Util;

public static class LoadAssets
{
    public static Dictionary<string, AudioClip> sfxDictionary = [];
    public static Dictionary<string, Texture2D> spriteDictionary = [];

    public static XmlDocument textChanges = new();

    public static void LoadResources()
    {
        //InitializeFont();

        foreach (string res in Assembly.GetExecutingAssembly().GetManifestResourceNames())
        {
            //Modding.Logger.Log(res);         
            if (res.EndsWith(".wav"))
            {
                Stream audioStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(res);
                if (audioStream != null)
                {
                    byte[] buffer = new byte[audioStream.Length];
                    audioStream.Read(buffer, 0, buffer.Length);
                    audioStream.Dispose();
                    string restemp = res.Replace("HollowPoint.assets.", "");
                    sfxDictionary.Add(restemp, WavUtility.ToAudioClip(buffer));
                }
                Log.Debug("Created sound effect {0}", arg0: res);
            }
            else if (res.EndsWith(".png"))
            {
                using var s = Assembly.GetExecutingAssembly().GetManifestResourceStream(res);

                if (s == null)
                    continue;
                byte[] buffer = new byte[s.Length];
                s.Read(buffer, 0, buffer.Length);
                s.Dispose();
                string restemp = res.Replace("HollowPoint.assets.", "");
                Texture2D currSprite;
                currSprite = new Texture2D(1, 1);
                currSprite.LoadImage(buffer);
                currSprite.Apply();
                spriteDictionary.Add(restemp, currSprite);
                Log.Debug("Created sprite from embedded image: {0}", arg0: restemp);
            }
            else if (res.EndsWith(".xml"))
            {
                using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(res);
                using var sr = new StreamReader(stream);

                textChanges.LoadXml(sr.ReadToEnd());
            }
        }
    }
}