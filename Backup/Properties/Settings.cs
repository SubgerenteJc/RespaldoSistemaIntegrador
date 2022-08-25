// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.Properties.Settings
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DefaultSettingValue("http://wslogistica.pilgrims.com.mx:8054/wsLogistica.asmx")]
    public string WindowsFormsApp1_mx_com_pilgrims_wslogistica_wsLogistica
    {
      get
      {
        return (string) this[nameof (WindowsFormsApp1_mx_com_pilgrims_wslogistica_wsLogistica)];
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string dbConn
    {
      get
      {
        return (string) this[nameof (dbConn)];
      }
    }
  }
}
