using Mutagen.Bethesda.WPF.Reflection.Attributes;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;
using System.Collections.Generic;

namespace FeminizedLeveledLists
{
    public class PatcherConfig
    {
        [Tooltip("This option will allow mages to be in any faction regardless of the other options set.")]
        public bool AllowMages = false;

        [Tooltip("Whether to remove male draugr from the leveled lists.")]
        public bool AllowDraugr = false;

        [Tooltip("Whether to remove male forsworn from the leveled lists.")]
        public bool AllowForsworn = true;

        [Tooltip("Whether to remove male vampires from the leveled lists.")]
        public bool AllowVampires = true;

        [Tooltip("Whether to remove male falmer from the leveled lists.")]
        public bool AllowFalmer = true;

        [SettingName("Manual Leveled List Override")]
        [Tooltip("Replaces the lists using the chosen editor IDs with those that use the supplied ones. These entries override the above defined options and are still patched as usual. Useful if something breaks naming conventions or has no alternatives defined.")]
        public Dictionary<string, string> ManualOverride = new Dictionary<string, string>(1);
    }
}
