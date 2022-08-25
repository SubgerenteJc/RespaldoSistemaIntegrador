// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.AssetTypeEnum
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace WindowsFormsApp1.TmwDispatchHorizonSvc
{
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "AssetTypeEnum", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Shared.Enumerations")]
  public enum AssetTypeEnum
  {
    [EnumMember] Driver,
    [EnumMember] Tractor,
    [EnumMember] Trailer,
    [EnumMember] Carrier,
  }
}
