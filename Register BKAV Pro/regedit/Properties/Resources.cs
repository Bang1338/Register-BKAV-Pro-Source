using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace regedit.Properties
{
	// Token: 0x02000003 RID: 3
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002067 File Offset: 0x00000267
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000021A0 File Offset: 0x000003A0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("regedit.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (set) Token: 0x06000004 RID: 4 RVA: 0x0000206F File Offset: 0x0000026F
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000001 RID: 1
		private static ResourceManager resourceMan;

		// Token: 0x04000002 RID: 2
		private static CultureInfo resourceCulture;
	}
}
