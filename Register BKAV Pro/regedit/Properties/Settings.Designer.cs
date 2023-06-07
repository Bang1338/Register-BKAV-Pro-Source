using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace regedit.Properties
{
	// Token: 0x02000006 RID: 6
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002179 File Offset: 0x00000379
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000039 RID: 57
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
