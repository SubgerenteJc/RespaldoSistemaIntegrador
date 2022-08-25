// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.WebServTest.wsLogisticaSoapClient
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml.Linq;

namespace WindowsFormsApp1.WebServTest
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  public class wsLogisticaSoapClient : ClientBase<wsLogisticaSoap>, wsLogisticaSoap
  {
    public wsLogisticaSoapClient()
    {
    }

    public wsLogisticaSoapClient(string endpointConfigurationName)
      : base(endpointConfigurationName)
    {
    }

    public wsLogisticaSoapClient(string endpointConfigurationName, string remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public wsLogisticaSoapClient(string endpointConfigurationName, EndpointAddress remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public wsLogisticaSoapClient(Binding binding, EndpointAddress remoteAddress)
      : base(binding, remoteAddress)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    WSL_GetInfoEmbarqueResponse wsLogisticaSoap.WSL_GetInfoEmbarque(
      WSL_GetInfoEmbarqueRequest request)
    {
      return this.Channel.WSL_GetInfoEmbarque(request);
    }

    public XElement WSL_GetInfoEmbarque(string pIdLocalidad, DateTime pFecha)
    {
      WSL_GetInfoEmbarqueRequest request = new WSL_GetInfoEmbarqueRequest()
      {
        Body = new WSL_GetInfoEmbarqueRequestBody()
      };
      request.Body.pIdLocalidad = pIdLocalidad;
      request.Body.pFecha = pFecha;
      return ((wsLogisticaSoap) this).WSL_GetInfoEmbarque(request).Body.WSL_GetInfoEmbarqueResult;
    }
  }
}
