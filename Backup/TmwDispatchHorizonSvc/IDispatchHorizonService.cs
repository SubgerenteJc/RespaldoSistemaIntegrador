// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.IDispatchHorizonService
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ServiceModel;

namespace WindowsFormsApp1.TmwDispatchHorizonSvc
{
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [ServiceContract(ConfigurationName = "TmwDispatchHorizonSvc.IDispatchHorizonService")]
  public interface IDispatchHorizonService
  {
    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/CheckDispatchServiceStatus", ReplyAction = "http://tempuri.org/IDispatchHorizonService/CheckDispatchServiceStatusResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchServiceStatus CheckDispatchServiceStatus();

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/NewDispatchHorizon", ReplyAction = "http://tempuri.org/IDispatchHorizonService/NewDispatchHorizonResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon NewDispatchHorizon();

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetMovesForOrderHeader", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetMovesForOrderHeaderResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetMovesForOrderHeader(
      int orderHeaderNumber,
      List<ExtraDataRequest> extraData);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetMovesForOrderNumber", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetMovesForOrderNumberResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetMovesForOrderNumber(
      string orderNumber,
      List<ExtraDataRequest> extraData);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetMovesForOrderHeaders", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetMovesForOrderHeadersResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetMovesForOrderHeaders(
      List<int> orderHeaderNumbers,
      List<ExtraDataRequest> extraData);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetMovesForOrderNumbers", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetMovesForOrderNumbersResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetMovesForOrderNumbers(
      List<string> orderNumbers,
      List<ExtraDataRequest> extraData);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetMovesForStops", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetMovesForStopsResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetMovesForStops(
      List<int> stpNumbers,
      List<ExtraDataRequest> extraData);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetMovesForReferenceNumber", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetMovesForReferenceNumberResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetMovesForReferenceNumber(
      string referenceNumber,
      List<ExtraDataRequest> extraData);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetMoves", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetMovesResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetMoves(List<int> moveNumber, List<ExtraDataRequest> extraData);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetMove", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetMoveResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetMove(int moveNumber, List<ExtraDataRequest> extraData);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetMoveByLeg", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetMoveByLegResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetMoveByLeg(int lghNumber, List<ExtraDataRequest> extraData);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetMoveByStop", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetMoveByStopResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetMoveByStop(int stpNumber, List<ExtraDataRequest> extraData);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetMoveByFreight", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetMoveByFreightResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetMoveByFreight(int fgtNumber, List<ExtraDataRequest> extraData);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/SaveDispatch", ReplyAction = "http://tempuri.org/IDispatchHorizonService/SaveDispatchResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon SaveDispatch(DispatchHorizon dispatch);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/SaveDispatchStop", ReplyAction = "http://tempuri.org/IDispatchHorizonService/SaveDispatchStopResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    List<DispatchSaveError> SaveDispatchStop(Stop stops);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/SaveDispatchFreight", ReplyAction = "http://tempuri.org/IDispatchHorizonService/SaveDispatchFreightResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    List<DispatchSaveError> SaveDispatchFreight(List<Freight> freight);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/SaveDispatchWithDateRippleForNewMoves", ReplyAction = "http://tempuri.org/IDispatchHorizonService/SaveDispatchWithDateRippleForNewMovesResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon SaveDispatchWithDateRippleForNewMoves(DispatchHorizon dispatch);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/SaveDispatchWithDateRipple", ReplyAction = "http://tempuri.org/IDispatchHorizonService/SaveDispatchWithDateRippleResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon SaveDispatchWithDateRipple(DispatchHorizon dispatch);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/SaveDispatchHandleExceptions", ReplyAction = "http://tempuri.org/IDispatchHorizonService/SaveDispatchHandleExceptionsResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon SaveDispatchHandleExceptions(DispatchHorizon dispatch);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/StandardDateRipple", ReplyAction = "http://tempuri.org/IDispatchHorizonService/StandardDateRippleResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon StandardDateRipple(
      DispatchHorizon dispatch,
      Move mov,
      int startFromStopIndex,
      bool startFromDeparture);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetCurrentActivityLeg", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetCurrentActivityLegResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    int? GetCurrentActivityLeg(AssetTypeEnum type, string id);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetCurrentActivity", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetCurrentActivityResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    CurrentActivity GetCurrentActivity(AssetTypeEnum type, string id);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetActivitySummary", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetActivitySummaryResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    List<AssetAssignment> GetActivitySummary(AssetTypeEnum type, string id);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetPagedAssetAssignments", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetPagedAssetAssignmentsResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    List<AssetAssignment> GetPagedAssetAssignments(
      AssetTypeEnum type,
      string id,
      List<string> statusList,
      int pageIndex,
      int pageSize,
      SortDirectionEnum sortDirection);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetActivityHistory", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetActivityHistoryResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    List<AssetAssignment> GetActivityHistory(
      AssetTypeEnum type,
      string id,
      DateTime startDate,
      DateTime endDate);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/CalculateMileage", ReplyAction = "http://tempuri.org/IDispatchHorizonService/CalculateMileageResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon CalculateMileage(DispatchHorizon dispatch, Move movToUpdate);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetNextTrip", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetNextTripResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetNextTrip(PriorAndNextTripArguments args);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetPriorAndNextTrip", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetPriorAndNextTripResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    PriorAndNextTrip GetPriorAndNextTrip(PriorAndNextTripArguments tripArguments);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/CreateDeadhead", ReplyAction = "http://tempuri.org/IDispatchHorizonService/CreateDeadheadResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DeadheadReturn CreateDeadhead(
      DispatchHorizon lastTripHorizon,
      int? lastTripLghNumber,
      DispatchHorizon currentTripHorizon,
      int currentTripLghNumber);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/CascadeDates", ReplyAction = "http://tempuri.org/IDispatchHorizonService/CascadeDatesResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    CascadeDatesReturn CascadeDates(
      DispatchHorizon dispatch,
      Stop startStop,
      ArriveDepartEnum startDate);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/SplitTrip", ReplyAction = "http://tempuri.org/IDispatchHorizonService/SplitTripResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon SplitTrip(int stopNumber, Location splitLocation);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/SplitTripWithDates", ReplyAction = "http://tempuri.org/IDispatchHorizonService/SplitTripWithDatesResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon SplitTripWithDates(
      int stopNumber,
      Location splitLocation,
      DateTime parkTime,
      DateTime hookTime);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/Validate", ReplyAction = "http://tempuri.org/IDispatchHorizonService/ValidateResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    ValidationErrorCollection Validate(DispatchHorizon dispatch);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/SaveAndIgnoreValidation", ReplyAction = "http://tempuri.org/IDispatchHorizonService/SaveAndIgnoreValidationResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    ValidationDispatch SaveAndIgnoreValidation(
      DispatchHorizon dispatch,
      List<ValidationCategoryEnum> categoriestoIgnore);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/SaveDispatches", ReplyAction = "http://tempuri.org/IDispatchHorizonService/SaveDispatchesResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    List<DispatchSaveError> SaveDispatches(List<DispatchHorizon> dispatches);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetMovesWithRelatedMoves", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetMovesWithRelatedMovesResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetMovesWithRelatedMoves(
      List<int> moveNumbers,
      List<ExtraDataRequest> extraData);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetMovesForOrderHeaderWithRelatedMoves", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetMovesForOrderHeaderWithRelatedMovesResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetMovesForOrderHeaderWithRelatedMoves(
      int orderHeaderNumber,
      List<ExtraDataRequest> extraData);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetMovesForOrderHeadersWithRelatedMoves", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetMovesForOrderHeadersWithRelatedMovesResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetMovesForOrderHeadersWithRelatedMoves(
      List<int> orderHeaderNumbers,
      List<ExtraDataRequest> extraData);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetMovesForOrderNumbersWithRelatedMoves", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetMovesForOrderNumbersWithRelatedMovesResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetMovesForOrderNumbersWithRelatedMoves(
      List<string> orderNumbers,
      List<ExtraDataRequest> extraData);

    [OperationContract(Action = "http://tempuri.org/IDispatchHorizonService/GetMovesForLegWithRelatedMoves", ReplyAction = "http://tempuri.org/IDispatchHorizonService/GetMovesForLegWithRelatedMovesResponse")]
    [FaultContract(typeof (SystemsLinkValidationFault), Action = "http://SystemsLinkValidationFault", Name = "SystemsLinkValidationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkInternalServerErrorFault), Action = "http://SystemsLinkInternalServerErrorFault", Name = "SystemsLinkInternalServerErrorFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    [FaultContract(typeof (SystemsLinkAuthenticationFault), Action = "http://SystemsLinkAuthenticationFault", Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
    DispatchHorizon GetMovesForLegWithRelatedMoves(
      int legNumber,
      List<ExtraDataRequest> extraData);
  }
}
