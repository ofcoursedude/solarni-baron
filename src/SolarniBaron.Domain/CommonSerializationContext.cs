﻿using System.Text.Json.Serialization;

using SolarniBaron.Domain.BatteryBox.Models;
using SolarniBaron.Domain.BatteryBox.Models.BatteryBox;
using SolarniBaron.Domain.Contracts;
using SolarniBaron.Domain.Ote.Queries.GetPricelist;

namespace SolarniBaron.Domain;

[JsonSerializable(typeof(LoginInfo))]
[JsonSerializable(typeof(BatteryBoxUnits))]
[JsonSerializable(typeof(LoginResponse))]
[JsonSerializable(typeof(BatteryBoxStatus))]
[JsonSerializable(typeof(ApiResponse<GetPricelistQueryResponse>))]
public partial class CommonSerializationContext : JsonSerializerContext
{
}
