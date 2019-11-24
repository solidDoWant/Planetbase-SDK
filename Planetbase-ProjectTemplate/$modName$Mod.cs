using System;
using PlanetbaseFramework;

namespace $safeprojectname$
{
	public class $modName$Mod : ModBase
    {
        public override string ModName { get; } = "$modName$Mod";

        public const string AssemblyVersion = "1.0.0.0";
        public override Version ModVersion { get; } = new Version(AssemblyVersion);

        public override void Init()
        {
            $if$ ($shouldInjectPatches$ == True)InjectPatches();$endif$
        }
    }
}