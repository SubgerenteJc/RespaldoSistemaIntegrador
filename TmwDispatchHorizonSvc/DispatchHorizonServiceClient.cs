// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.DispatchHorizonServiceClient
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace WindowsFormsApp1.TmwDispatchHorizonSvc
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  public class DispatchHorizonServiceClient : ClientBase<IDispatchHorizonService>, IDispatchHorizonService
  {
    public DispatchHorizonServiceClient()
    {
    }

    public DispatchHorizonServiceClient(string endpointConfigurationName)
      : base(endpointConfigurationName)
    {
    }

    public DispatchHorizonServiceClient(string endpointConfigurationName, string remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public DispatchHorizonServiceClient(
      string endpointConfigurationName,
      EndpointAddress remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public DispatchHorizonServiceClient(Binding binding, EndpointAddress remoteAddress)
      : base(binding, remoteAddress)
    {
    }

    public DispatchServiceStatus CheckDispatchServiceStatus()
    {
      return this.Channel.CheckDispatchServiceStatus();
    }

    public DispatchHorizon NewDispatchHorizon()
    {
      return this.Channel.NewDispatchHorizon();
    }

    public DispatchHorizon GetMovesForOrderHeader(
      int orderHeaderNumber,
      List<ExtraDataRequest> extraData)
    {
      return this.Channel.GetMovesForOrderHeader(orderHeaderNumber, extraData);
    }

    public DispatchHorizon GetMovesForOrderNumber(
      string orderNumber,
      List<ExtraDataRequest> extraData)
    {
      return this.Channel.GetMovesForOrderNumber(orderNumber, extraData);
    }

    public DispatchHorizon GetMovesForOrderHeaders(
      List<int> orderHeaderNumbers,
      List<ExtraDataRequest> extraData)
    {
      return this.Channel.GetMovesForOrderHeaders(orderHeaderNumbers, extraData);
    }

    public DispatchHorizon GetMovesForOrderNumbers(
      List<string> orderNumbers,
      List<ExtraDataRequest> extraData)
    {
      return this.Channel.GetMovesForOrderNumbers(orderNumbers, extraData);
    }

    public DispatchHorizon GetMovesForStops(
      List<int> stpNumbers,
      List<ExtraDataRequest> extraData)
    {
      return this.Channel.GetMovesForStops(stpNumbers, extraData);
    }

    public DispatchHorizon GetMovesForReferenceNumber(
      string referenceNumber,
      List<ExtraDataRequest> extraData)
    {
      return this.Channel.GetMovesForReferenceNumber(referenceNumber, extraData);
    }

    public DispatchHorizon GetMoves(
      List<int> moveNumber,
      List<ExtraDataRequest> extraData)
    {
      return this.Channel.GetMoves(moveNumber, extraData);
    }

    public DispatchHorizon GetMove(int moveNumber, List<ExtraDataRequest> extraData)
    {
      return this.Channel.GetMove(moveNumber, extraData);
    }

    public DispatchHorizon GetMoveByLeg(
      int lghNumber,
      List<ExtraDataRequest> extraData)
    {
      return this.Channel.GetMoveByLeg(lghNumber, extraData);
    }

    public DispatchHorizon GetMoveByStop(
      int stpNumber,
      List<ExtraDataRequest> extraData)
    {
      return this.Channel.GetMoveByStop(stpNumber, extraData);
    }

    public DispatchHorizon GetMoveByFreight(
      int fgtNumber,
      List<ExtraDataRequest> extraData)
    {
      return this.Channel.GetMoveByFreight(fgtNumber, extraData);
    }

    public DispatchHorizon SaveDispatch(DispatchHorizon dispatch)
    {
      return this.Channel.SaveDispatch(dispatch);
    }

    public List<DispatchSaveError> SaveDispatchStop(Stop stops)
    {
      return this.Channel.SaveDispatchStop(stops);
    }

    public List<DispatchSaveError> SaveDispatchFreight(List<Freight> freight)
    {
      return this.Channel.SaveDispatchFreight(freight);
    }

    public DispatchHorizon SaveDispatchWithDateRippleForNewMoves(
      DispatchHorizon dispatch)
    {
      return this.Channel.SaveDispatchWithDateRippleForNewMoves(dispatch);
    }

    public DispatchHorizon SaveDispatchWithDateRipple(DispatchHorizon dispatch)
    {
      return this.Channel.SaveDispatchWithDateRipple(dispatch);
    }

    public DispatchHorizon SaveDispatchHandleExceptions(DispatchHorizon dispatch)
    {
      return this.Channel.SaveDispatchHandleExceptions(dispatch);
    }

    public DispatchHorizon StandardDateRipple(
      DispatchHorizon dispatch,
      Move mov,
      int startFromStopIndex,
      bool startFromDeparture)
    {
      return this.Channel.StandardDateRipple(dispatch, mov, startFromStopIndex, startFromDeparture);
    }

    public int? GetCurrentActivityLeg(AssetTypeEnum type, string id)
    {
      return this.Channel.GetCurrentActivityLeg(type, id);
    }

    public CurrentActivity GetCurrentActivity(AssetTypeEnum type, string id)
    {
      return this.Channel.GetCurrentActivity(type, id);
    }

    public List<AssetAssignment> GetActivitySummary(
      AssetTypeEnum type,
      string id)
    {
      return this.Channel.GetActivitySummary(type, id);
    }

    public List<AssetAssignment> GetPagedAssetAssignments(
      AssetTypeEnum type,
      string id,
      List<string> statusList,
      int pageIndex,
      int pageSize,
      SortDirectionEnum sortDirection)
    {
      return this.Channel.GetPagedAssetAssignments(type, id, statusList, pageIndex, pageSize, sortDirection);
    }

    public List<AssetAssignment> GetActivityHistory(
      AssetTypeEnum type,
      string id,
      DateTime startDate,
      DateTime endDate)
    {
      return this.Channel.GetActivityHistory(type, id, startDate, endDate);
    }

    public DispatchHorizon CalculateMileage(
      DispatchHorizon dispatch,
      Move movToUpdate)
    {
      return this.Channel.CalculateMileage(dispatch, movToUpdate);
    }

    public DispatchHorizon GetNextTrip(PriorAndNextTripArguments args)
    {
      return this.Channel.GetNextTrip(args);
    }

    public PriorAndNextTrip GetPriorAndNextTrip(
      PriorAndNextTripArguments tripArguments)
    {
      return this.Channel.GetPriorAndNextTrip(tripArguments);
    }

    public DeadheadReturn CreateDeadhead(
      DispatchHorizon lastTripHorizon,
      int? lastTripLghNumber,
      DispatchHorizon currentTripHorizon,
      int currentTripLghNumber)
    {
      return this.Channel.CreateDeadhead(lastTripHorizon, lastTripLghNumber, currentTripHorizon, currentTripLghNumber);
    }

    public CascadeDatesReturn CascadeDates(
      DispatchHorizon dispatch,
      Stop startStop,
      ArriveDepartEnum startDate)
    {
      return this.Channel.CascadeDates(dispatch, startStop, startDate);
    }

    public DispatchHorizon SplitTrip(int stopNumber, Location splitLocation)
    {
      return this.Channel.SplitTrip(stopNumber, splitLocation);
    }

    public DispatchHorizon SplitTripWithDates(
      int stopNumber,
      Location splitLocation,
      DateTime parkTime,
      DateTime hookTime)
    {
      return this.Channel.SplitTripWithDates(stopNumber, splitLocation, parkTime, hookTime);
    }

    public ValidationErrorCollection Validate(DispatchHorizon dispatch)
    {
      return this.Channel.Validate(dispatch);
    }

    public ValidationDispatch SaveAndIgnoreValidation(
      DispatchHorizon dispatch,
      List<ValidationCategoryEnum> categoriestoIgnore)
    {
      return this.Channel.SaveAndIgnoreValidation(dispatch, categoriestoIgnore);
    }

    public List<DispatchSaveError> SaveDispatches(
      List<DispatchHorizon> dispatches)
    {
      return this.Channel.SaveDispatches(dispatches);
    }

    public DispatchHorizon GetMovesWithRelatedMoves(
      List<int> moveNumbers,
      List<ExtraDataRequest> extraData)
    {
      return this.Channel.GetMovesWithRelatedMoves(moveNumbers, extraData);
    }

    public DispatchHorizon GetMovesForOrderHeaderWithRelatedMoves(
      int orderHeaderNumber,
      List<ExtraDataRequest> extraData)
    {
      return this.Channel.GetMovesForOrderHeaderWithRelatedMoves(orderHeaderNumber, extraData);
    }

    public DispatchHorizon GetMovesForOrderHeadersWithRelatedMoves(
      List<int> orderHeaderNumbers,
      List<ExtraDataRequest> extraData)
    {
      return this.Channel.GetMovesForOrderHeadersWithRelatedMoves(orderHeaderNumbers, extraData);
    }

    public DispatchHorizon GetMovesForOrderNumbersWithRelatedMoves(
      List<string> orderNumbers,
      List<ExtraDataRequest> extraData)
    {
      return this.Channel.GetMovesForOrderNumbersWithRelatedMoves(orderNumbers, extraData);
    }

    public DispatchHorizon GetMovesForLegWithRelatedMoves(
      int legNumber,
      List<ExtraDataRequest> extraData)
    {
      return this.Channel.GetMovesForLegWithRelatedMoves(legNumber, extraData);
    }
  }
}
