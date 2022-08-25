// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.WebServTest.WSL_GetInfoEmbarqueRequestBody
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WindowsFormsApp1.WebServTest
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [DataContract(Namespace = "http://tempuri.org/")]
  public class WSL_GetInfoEmbarqueRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string pIdLocalidad;
    [DataMember(Order = 1)]
    public DateTime pFecha;

    public WSL_GetInfoEmbarqueRequestBody()
    {
    }

    public WSL_GetInfoEmbarqueRequestBody(string pIdLocalidad, DateTime pFecha)
    {
      this.pIdLocalidad = pIdLocalidad;
      this.pFecha = pFecha;
    }
  }
}
