using System;
using Serilog;

namespace BookAPI.Application.AppLog;

public static class ExceptionWriter
{
    private static void LogToDebug(string message)
    {
        Log.Debug(message);
    }

    private static void LogToConsole(string message)
    {
        Log.Warning(message);
    }

    private static void LogToFile(string information)
    {
        Log.Information(information);
    }

    public static void LogExceptions(Exception e)
    {
        LogToDebug(e.Message);
        LogToConsole(e.Message);
        LogToFile(e.Message);
    }
}
