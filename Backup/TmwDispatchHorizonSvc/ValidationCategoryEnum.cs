// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.ValidationCategoryEnum
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace WindowsFormsApp1.TmwDispatchHorizonSvc
{
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "ValidationCategoryEnum", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Enumerations.Validation")]
  public enum ValidationCategoryEnum
  {
    [EnumMember] None = 0,
    [EnumMember] All = 500, // 0x000001F4
    [EnumMember] AssetConflicts = 1000, // 0x000003E8
    [EnumMember] CompanyOrderRequirements = 1500, // 0x000005DC
    [EnumMember] CustomerEquipment = 2000, // 0x000007D0
    [EnumMember] DAL = 2500, // 0x000009C4
    [EnumMember] EventCodeValidation = 3000, // 0x00000BB8
    [EnumMember] Expirations = 3500, // 0x00000DAC
    [EnumMember] ExternalTripFolderController = 4000, // 0x00000FA0
    [EnumMember] InvoiceDetails = 4500, // 0x00001194
    [EnumMember] ProductCompatibility = 5000, // 0x00001388
    [EnumMember] Licensing = 5500, // 0x0000157C
    [EnumMember] LoadRequirements = 6000, // 0x00001770
    [EnumMember] Orders = 6500, // 0x00001964
    [EnumMember] OutOfRoute = 7000, // 0x00001B58
    [EnumMember] PayDetails = 7500, // 0x00001D4C
    [EnumMember] ScheduleStop = 8000, // 0x00001F40
    [EnumMember] Stops = 8500, // 0x00002134
    [EnumMember] ReferenceNumRequirements = 9000, // 0x00002328
    [EnumMember] ReferenceUnique = 9500, // 0x0000251C
    [EnumMember] UserDefined = 10000, // 0x00002710
  }
}
