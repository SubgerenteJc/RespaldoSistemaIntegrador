// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.WebServTest.WSL_GetInfoEmbarqueResponse
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WindowsFormsApp1.WebServTest
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [MessageContract(IsWrapped = false)]
  public class WSL_GetInfoEmbarqueResponse
  {
    [MessageBodyMember(Name = "WSL_GetInfoEmbarqueResponse", Namespace = "http://tempuri.org/", Order = 0)]
    public WSL_GetInfoEmbarqueResponseBody Body;

    public WSL_GetInfoEmbarqueResponse()
    {
    }

    public WSL_GetInfoEmbarqueResponse(WSL_GetInfoEmbarqueResponseBody Body)
    {
      this.Body = Body;
    }
  }
}
