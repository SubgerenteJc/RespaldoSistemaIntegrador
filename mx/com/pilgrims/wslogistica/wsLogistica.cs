// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.mx.com.pilgrims.wslogistica.wsLogistica
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1.mx.com.pilgrims.wslogistica
{
  [GeneratedCode("System.Web.Services", "4.7.2556.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [WebServiceBinding(Name = "wsLogisticaSoap", Namespace = "http://tempuri.org/")]
  public class wsLogistica : SoapHttpClientProtocol
  {
    private SendOrPostCallback WSL_GetInfoEmbarqueOperationCompleted;
    private bool useDefaultCredentialsSetExplicitly;

    public wsLogistica()
    {
      this.Url = Settings.Default.WindowsFormsApp1_mx_com_pilgrims_wslogistica_wsLogistica;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    public new string Url
    {
      get
      {
        return base.Url;
      }
      set
      {
        if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
          base.UseDefaultCredentials = false;
        base.Url = value;
      }
    }

    public new bool UseDefaultCredentials
    {
      get
      {
        return base.UseDefaultCredentials;
      }
      set
      {
        base.UseDefaultCredentials = value;
        this.useDefaultCredentialsSetExplicitly = true;
      }
    }

    public event WSL_GetInfoEmbarqueCompletedEventHandler WSL_GetInfoEmbarqueCompleted;

    [SoapDocumentMethod("http://tempuri.org/WSL_GetInfoEmbarque", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal)]
    public XmlNode WSL_GetInfoEmbarque(string pIdLocalidad, DateTime pFecha)
    {
      return (XmlNode) this.Invoke(nameof (WSL_GetInfoEmbarque), new object[2]
      {
        (object) pIdLocalidad,
        (object) pFecha
      })[0];
    }

    public void WSL_GetInfoEmbarqueAsync(string pIdLocalidad, DateTime pFecha)
    {
      this.WSL_GetInfoEmbarqueAsync(pIdLocalidad, pFecha, (object) null);
    }

    public void WSL_GetInfoEmbarqueAsync(string pIdLocalidad, DateTime pFecha, object userState)
    {
      if (this.WSL_GetInfoEmbarqueOperationCompleted == null)
        this.WSL_GetInfoEmbarqueOperationCompleted = new SendOrPostCallback(this.OnWSL_GetInfoEmbarqueOperationCompleted);
      this.InvokeAsync("WSL_GetInfoEmbarque", new object[2]
      {
        (object) pIdLocalidad,
        (object) pFecha
      }, this.WSL_GetInfoEmbarqueOperationCompleted, userState);
    }

    private void OnWSL_GetInfoEmbarqueOperationCompleted(object arg)
    {
      if (this.WSL_GetInfoEmbarqueCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.WSL_GetInfoEmbarqueCompleted((object) this, new WSL_GetInfoEmbarqueCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    public new void CancelAsync(object userState)
    {
      base.CancelAsync(userState);
    }

    private bool IsLocalFileSystemWebService(string url)
    {
      if (url == null || url == string.Empty)
        return false;
      Uri uri = new Uri(url);
      return uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
    }
  }
}
