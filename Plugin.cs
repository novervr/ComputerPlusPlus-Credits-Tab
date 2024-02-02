using BepInEx;
using GorillaNetworking;
using System;
using System.Reflection;
using UnityEngine;
using ComputerPlusPlus;

namespace ComputerPlusPlusCreditsTab
{
    [BepInDependency("com.kylethescientist.gorillatag.computerplusplus")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    [assembly: System.Reflection.AssemblyVersion("2.0")]
    public class TestScreen : IScreen
    {
        public string Title => "Credits";

        public string Description => "Credits tab";

        bool onePressed = false;
        bool twoPressed = false;
        bool threePressed = false;
        bool fourPressed = false;
        // This is called every frame while the screen is active
        public string GetContent()
        {
            if (onePressed)
            {
                return "CREDITS\r\n\r\n\r\nGame by Kerestell (Lemming)\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nPress\r\n 1-4 to change different pages.\r\nPage 1";
            }
            if (twoPressed)
            {
                return "CREDITS\r\n\r\n  \"Monke Need To Swing\"\r\ncomposed by Stunshine\r\nProduced\r\nby AUDIOPFEIL & OWLOBE\r\n\r\n  \"Cave\"\r\n, \"Campfire\"\r\ncomposed by\r\n Stunshine\r\n\r\nSound Design by David Anderson Kirk\r\n  \r\n\r\nPage 2";
            }
            if (threePressed)
            {
                return "CREDITS\r\n\r\n\r\nAdditional art by\r\n\r\n\r\nLulu (Laura) Lorian\r\n\r\n@lululorian\r\n\r\n\r\nLilith\r\n Tothill\r\n\r\n\r\n\r\n\r\n\r\nPage 3"; ;
            }
            if (fourPressed)
            {
                return "MOD CREDITS\r\n\r\n\r\nComputer mod made by\r\n\r\n\r\nKyleTheScientist ( Kyle Williams) \r\n\r\nhttps://github.com/KyleTheScientist\r\n\r\n\r\nMod made by\r\n SepDev\r\n\r\n\r\n\r\n\r\n\r\nPage 4"; ;
            }
            return "You are on credits home page, press 1, 2, 3, or 4 to change pages. Once you do that, this will not appear again, unless you restart your game/reopen the tab.";
        }

        // This is called whenever a key is pressed while the screen is active
        public void OnKeyPressed(GorillaKeyboardButton button)
        {
            if (button.characterString == "1")
            {
                onePressed = true;
            }
            else
            {
                onePressed = false;
            }

            if (button.characterString == "2")
            {
                twoPressed = true;
            }
            else
            {
                twoPressed = false;
            }

            if (button.characterString == "3")
            {
                threePressed = true;
            }
            else
            {
                threePressed = false;
            }

            if (button.characterString == "4")
            {
                fourPressed = true;
            }
            else
            {
                fourPressed = false;
            }
        }

        public void Start()
        {

        }
    }
}
