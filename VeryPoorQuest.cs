using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MelonLoader;

namespace VeryPoorQuest
{
    public class VeryPoorQuestMod
    {
        static void OnApplicationStart()
        {
            if (UnityEngine.Application.platform == UnityEngine.RuntimePlatform.WindowsPlayer)
                MelonLogger.Msg("[VeryPoorQuest] This module is intended for use on the Quest! PC users can already set their performance rating minimum...");
        }
        void OnLevelWasLoaded(int level)
        {
            if (level == 1 && (int)VRC_DataStorageInternal.Read("VRC_AVATAR_PERFORMANCE_RATING_MINIMUM_TO_DISPLAY", typeof(int), 5) != 5)
            {
                VRC_DataStorageInternal.Write("VRC_AVATAR_PERFORMANCE_RATING_MINIMUM_TO_DISPLAY", 5);
                VRC_DataStorageInternal.SaveNow();
                MelonLogger.Msg("[VeryPoorQuest] The deed is done. Have a nice day!");
            }
        }
    }
}
