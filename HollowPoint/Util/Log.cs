using Modding;
using System.Runtime.CompilerServices;
using System.Text;

namespace HollowPoint.Util;

internal static class Log
{
    public static LogLevel LogLevel => ModHooks.GlobalSettings.LoggingLevel;
    public static bool IsEnabled(LogLevel level) => level >= LogLevel;

    public static void Trace(string message, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Fine, Logger.LogFine, sb => sb.Append(message), callerFile, callerLineNum, callerMember);
    public static void Trace<T1>(string message, T1 arg0, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Fine, Logger.LogFine, sb => sb.AppendFormat(message, arg0), callerFile, callerLineNum, callerMember);
    public static void Trace<T1, T2>(string message, T1 arg0, T2 arg1, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Fine, Logger.LogFine, sb => sb.AppendFormat(message, arg0, arg1), callerFile, callerLineNum, callerMember);
    public static void Trace<T1, T2, T3>(string message, T1 arg0, T2 arg1, T3 arg2, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Fine, Logger.LogFine, sb => sb.AppendFormat(message, arg0, arg1, arg2), callerFile, callerLineNum, callerMember);
    public static void Trace(string message, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "", params object[] args) =>
        WriteLog(LogLevel.Fine, Logger.LogFine, sb => sb.AppendFormat(message, args), callerFile, callerLineNum, callerMember);

    public static void Debug(string message, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Debug, Logger.LogDebug, sb => sb.Append(message), callerFile, callerLineNum, callerMember);
    public static void Debug<T1>(string message, T1 arg0, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Debug, Logger.LogDebug, sb => sb.AppendFormat(message, arg0), callerFile, callerLineNum, callerMember);
    public static void Debug<T1, T2>(string message, T1 arg0, T2 arg1, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Debug, Logger.LogDebug, sb => sb.AppendFormat(message, arg0, arg1), callerFile, callerLineNum, callerMember);
    public static void Debug<T1, T2, T3>(string message, T1 arg0, T2 arg1, T3 arg2, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Debug, Logger.LogDebug, sb => sb.AppendFormat(message, arg0, arg1, arg2), callerFile, callerLineNum, callerMember);
    public static void Debug(string message, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "", params object[] args) =>
        WriteLog(LogLevel.Debug, Logger.LogDebug, sb => sb.AppendFormat(message, args), callerFile, callerLineNum, callerMember);

    public static void Info(string message, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Info, Logger.Log, sb => sb.Append(message), callerFile, callerLineNum, callerMember);
    public static void Info<T1>(string message, T1 arg0, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Info, Logger.Log, sb => sb.AppendFormat(message, arg0), callerFile, callerLineNum, callerMember);
    public static void Info<T1, T2>(string message, T1 arg0, T2 arg1, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Info, Logger.Log, sb => sb.AppendFormat(message, arg0, arg1), callerFile, callerLineNum, callerMember);
    public static void Info<T1, T2, T3>(string message, T1 arg0, T2 arg1, T3 arg2, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Info, Logger.Log, sb => sb.AppendFormat(message, arg0, arg1, arg2), callerFile, callerLineNum, callerMember);
    public static void Info(string message, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "", params object[] args) =>
        WriteLog(LogLevel.Info, Logger.Log, sb => sb.AppendFormat(message, args), callerFile, callerLineNum, callerMember);

    public static void Warn(string message, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Warn, Logger.LogWarn, sb => sb.Append(message), callerFile, callerLineNum, callerMember);
    public static void Warn<T1>(string message, T1 arg0, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Warn, Logger.LogWarn, sb => sb.AppendFormat(message, arg0), callerFile, callerLineNum, callerMember);
    public static void Warn<T1, T2>(string message, T1 arg0, T2 arg1, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Warn, Logger.LogWarn, sb => sb.AppendFormat(message, arg0, arg1), callerFile, callerLineNum, callerMember);
    public static void Warn<T1, T2, T3>(string message, T1 arg0, T2 arg1, T3 arg2, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Warn, Logger.LogWarn, sb => sb.AppendFormat(message, arg0, arg1, arg2), callerFile, callerLineNum, callerMember);
    public static void Warn(string message, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "", params object[] args) =>
        WriteLog(LogLevel.Warn, Logger.LogWarn, sb => sb.AppendFormat(message, args), callerFile, callerLineNum, callerMember);

    public static void Error(string message, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Error, Logger.LogError, sb => sb.Append(message), callerFile, callerLineNum, callerMember);
    public static void Error<T1>(string message, T1 arg0, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Error, Logger.LogError, sb => sb.AppendFormat(message, arg0), callerFile, callerLineNum, callerMember);
    public static void Error<T1, T2>(string message, T1 arg0, T2 arg1, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Error, Logger.LogError, sb => sb.AppendFormat(message, arg0, arg1), callerFile, callerLineNum, callerMember);
    public static void Error<T1, T2, T3>(string message, T1 arg0, T2 arg1, T3 arg2, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "") =>
        WriteLog(LogLevel.Error, Logger.LogError, sb => sb.AppendFormat(message, arg0, arg1, arg2), callerFile, callerLineNum, callerMember);
    public static void Error(string message, [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLineNum = 0, [CallerMemberName] string callerMember = "", params object[] args) =>
        WriteLog(LogLevel.Error, Logger.LogError, sb => sb.AppendFormat(message, args), callerFile, callerLineNum, callerMember);

    [ThreadStatic]
    private static StringBuilder? _sb;
    private static StringBuilder SharedBuilder => _sb ??= new(capacity: 512);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void WriteLog(LogLevel level, Action<string> log, Action<StringBuilder> format,
        string callerFile, int callerLineNum, string callerMember)
    {
        if (!IsEnabled(level))
            return;

        var sb = SharedBuilder;
        try
        {
            sb.Append("[HollowPoint/");
            sb.Append(callerMember);
#if DEBUG
            sb.Append('#');
            sb.Append(callerFile);
            sb.Append(':');
            sb.Append(callerLineNum);
#endif
            sb.Append("]: ");

            format(sb);
            log(sb.ToString());
        }
        finally
        {
            sb.Clear();
        }
    }
}
