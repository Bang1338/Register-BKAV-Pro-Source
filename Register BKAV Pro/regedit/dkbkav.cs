using System;
using Microsoft.Win32;

namespace regedit
{
	// Token: 0x02000007 RID: 7
	internal class dkbkav
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00004C6C File Offset: 0x00002E6C
		public bool WriteRegKey(string keyName, object value)
		{
			RegistryKey localMachine = Registry.LocalMachine;
			RegistryKey registryKey = localMachine.CreateSubKey("Software\\bkav");
			registryKey.SetValue(keyName, value);
			return true;
		}
	}
}
