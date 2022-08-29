using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FortniteChecker.Models;
using FortniteChecker.Models.FortniteAPI;
using TCM_Fortnite_Tool;

namespace FortniteChecker.Classes
{
    static class SkinParser
    {
        public static string GetOutfit(Dictionary<string, ItemDetails> items)
        {
            var sb = new StringBuilder();

            foreach (var item in items.Values.Where(x => x.TemplateId.Contains("AthenaCharacter")))
            {
                var checkOutfit = GlobalVariables.Outfits.Cast<DictionaryEntry>()
                    .FirstOrDefault(x => item.TemplateId.Contains(x.Key.ToString()));

                if (checkOutfit.Key == null && checkOutfit.Value == null)
                {
                    if (Form1.EnableNoneSkins == true)
                    {
                        sb.AppendLine(item.TemplateId.ToString()); continue;
                    }
                }
                else
                    sb.AppendLine(GlobalVariables.Outfits[checkOutfit.Key].ToString());
            }

            return sb.ToString();
        }

        public static string GetLoadingScreens(Dictionary<string, ItemDetails> items)
        {
            var sb = new StringBuilder();

            foreach (var item in items.Values.Where(x => x.TemplateId.Contains("AthenaLoadingScreen")))
            {
                var checkLoadingScreens = GlobalVariables.LoadingScreens.Cast<DictionaryEntry>()
                    .FirstOrDefault(x => item.TemplateId.Contains(x.Key.ToString()));

                if (checkLoadingScreens.Key == null && checkLoadingScreens.Value == null)
                {
                    if (Form1.EnableNoneSkins == true)
                    {
                        sb.AppendLine(item.TemplateId.ToString()); continue;
                    }
                }
                else
                    sb.AppendLine(GlobalVariables.LoadingScreens[checkLoadingScreens.Key].ToString());
            }

            return sb.ToString();
        }

        public static string GetBackBlings(Dictionary<string, ItemDetails> items)
        {
            var sb = new StringBuilder();

            foreach (var item in items.Values.Where(x => x.TemplateId.Contains("AthenaBackpack")))
            {
                var checkBackBling = GlobalVariables.Backblings.Cast<DictionaryEntry>()
                    .FirstOrDefault(x => item.TemplateId.Contains(x.Key.ToString()));

                if (checkBackBling.Key == null && checkBackBling.Value == null)
                {
                    if (Form1.EnableNoneSkins == true)
                    {
                        sb.AppendLine(item.TemplateId.ToString()); continue;
                    }
                }
                else
                    sb.AppendLine(GlobalVariables.Backblings[checkBackBling.Key].ToString());
            }

            return sb.ToString();
        }

        public static string GetGliders(Dictionary<string, ItemDetails> items)
        {
            var sb = new StringBuilder();

            foreach (var item in items.Values.Where(x => x.TemplateId.Contains("AthenaGlider")))
            {
                var checkGlider = GlobalVariables.Gliders.Cast<DictionaryEntry>()
                    .FirstOrDefault(x => item.TemplateId.Contains(x.Key.ToString()));

                if (checkGlider.Key == null && checkGlider.Value == null)
                {
                    if (Form1.EnableNoneSkins == true)
                    {
                        sb.AppendLine(item.TemplateId.ToString()); continue;
                    }
                }
                else
                    sb.AppendLine(GlobalVariables.Gliders[checkGlider.Key].ToString());
            }

            return sb.ToString();
        }

        public static string GetDances(Dictionary<string, ItemDetails> items)
        {
            var sb = new StringBuilder();

            foreach (var item in items.Values.Where(x => x.TemplateId.Contains("AthenaDance")))
            {
                var checkDances = GlobalVariables.Dances.Cast<DictionaryEntry>()
                    .FirstOrDefault(x => item.TemplateId.Contains(x.Key.ToString()));

                if (checkDances.Key == null && checkDances.Value == null)
                {
                    if (!item.TemplateId.ToString().Contains("emoji"))
                    {
                        if (Form1.EnableNoneSkins == true)
                        {
                            sb.AppendLine(item.TemplateId.ToString()); continue;
                        }
                    }
                }
                else
                    sb.AppendLine(GlobalVariables.Dances[checkDances.Key].ToString());
            }
            return sb.ToString();
        }
        public static string GetEmojis(Dictionary<string, ItemDetails> items)
        {
            var sb = new StringBuilder();

            foreach (var item in items.Values.Where(x => x.TemplateId.Contains("emoji")))
            {
                var checkEmojis = GlobalVariables.Emojis.Cast<DictionaryEntry>()
                    .FirstOrDefault(x => item.TemplateId.Contains(x.Key.ToString()));

                if (checkEmojis.Key == null && checkEmojis.Value == null)
                {
                    if (item.TemplateId.ToString().Contains("emoji"))
                    {
                        if (Form1.EnableNoneSkins == true)
                        {
                            sb.AppendLine(item.TemplateId.ToString()); continue;
                        }
                    }
                }
                else
                    sb.AppendLine(GlobalVariables.Emojis[checkEmojis.Key].ToString());
            }
            return sb.ToString();
        }


        public static string GetPickaxes(Dictionary<string, ItemDetails> items)
        {
            var sb = new StringBuilder();

            foreach (var item in items.Values.Where(x => x.TemplateId.Contains("AthenaPickaxe")))
            {
                var checkPickaxe = GlobalVariables.Pickaxes.Cast<DictionaryEntry>()
                    .FirstOrDefault(x => item.TemplateId.Contains(x.Key.ToString()));

                if (checkPickaxe.Key == null && checkPickaxe.Value == null)
                {
                    if (Form1.EnableNoneSkins == true)
                    {
                        sb.AppendLine(item.TemplateId.ToString()); continue;
                    }
                }
                else
                    sb.AppendLine(GlobalVariables.Pickaxes[checkPickaxe.Key].ToString());
            }

            return sb.ToString();
        }
    }
}
