// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.WebServTest.wsLogisticaSoap
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System.CodeDom.Compiler;
using System.ServiceModel;

namespace WindowsFormsApp1.WebServTest
{
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [ServiceContract(ConfigurationName = "WebServTest.wsLogisticaSoap")]
  public interface wsLogisticaSoap
  {
    [OperationContract(Action = "http://tempuri.org/WSL_GetInfoEmbarque", ReplyAction = "*")]
    WSL_GetInfoEmbarqueResponse WSL_GetInfoEmbarque(
      WSL_GetInfoEmbarqueRequest request);
  }
}
