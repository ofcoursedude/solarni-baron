﻿using Microsoft.Extensions.Logging;
using SolarniBaron.Domain.Contracts;
using SolarniBaron.Domain.Contracts.Commands;

namespace SolarniBaron.Domain.BatteryBox.Commands.SetMode;

public class SetModeCommandHandler : ICommandHandler<SetModeCommand, SetModeCommandResponse>
{
    private readonly IDataConnector _connector;
    private readonly ILogger<SetModeCommandHandler> _logger;

    public SetModeCommandHandler(IDataConnector connector, ILogger<SetModeCommandHandler> logger)
    {
        _connector = connector;
        _logger = logger;
    }

    public async Task<SetModeCommandResponse> Execute(ICommand<SetModeCommand, SetModeCommandResponse> command)
    {
        var setModeCommand = command.Data ?? throw new ArgumentException("Invalid command type");
        var mode = await _connector.SetMode(setModeCommand.Username, setModeCommand.Password, setModeCommand.UnitId,
            setModeCommand.Mode);

        return new SetModeCommandResponse(mode.Item1 ? ResponseStatus.Ok : ResponseStatus.Error,
            mode.Item2);
    }
}