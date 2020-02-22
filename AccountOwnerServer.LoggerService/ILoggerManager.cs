using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwnerServer.LoggerService
{
    
    /*
     * Bilgi Mesajları
     * Uyarı mesajları
     * Hata ayıklama mesajları
     * Hata mesajları
     */
    public interface ILoggerManager
    {
        void LogInfo(string message);
        void LogWarn(string message);
        void LogDebug(string message);
        void LogError(string message);
    }
}
