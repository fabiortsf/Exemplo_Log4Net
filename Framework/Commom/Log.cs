using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Commom
{
    public sealed class Log
    {
        readonly ILog _logger;

        static Log()
        {

            // Gets directory path of the calling application
            // RelativeSearchPath is null if the executing assembly i.e. calling assembly is a
            // stand alone exe file (Console, WinForm, etc). 
            // RelativeSearchPath is not null if the calling assembly is a web hosted application i.e. a web site
            var log4NetConfigDirectory = AppDomain.CurrentDomain.RelativeSearchPath ?? AppDomain.CurrentDomain.BaseDirectory;

            var log4NetConfigFilePath = Path.Combine(log4NetConfigDirectory, "log4net.config");
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(log4NetConfigFilePath));

        }

        public Log(Type logClass)
        {
            _logger = LogManager.GetLogger(logClass);
        }

        public void Fatal(string errorMessage)
        {
            if (_logger.IsFatalEnabled)
                _logger.Fatal(errorMessage);
        }
        public void Fatal(string errorMessage, Exception ex)
        {
            if (_logger.IsFatalEnabled)
                _logger.Fatal(errorMessage, ex);
        }

        public void Error(string errorMessage)
        {
            if (_logger.IsErrorEnabled)
                _logger.Error(errorMessage);
        }
        public void Error(string errorMessage, Exception ex)
        {
            if (_logger.IsFatalEnabled)
                _logger.Error(errorMessage, ex);
        }

        public void Warn(string message)
        {
            if (_logger.IsWarnEnabled)
                _logger.Warn(message);
        }
        public void Warn(string errorMessage, Exception ex)
        {
            if (_logger.IsFatalEnabled)
                _logger.Warn(errorMessage, ex);
        }

        public void Info(string message)
        {
            if (_logger.IsInfoEnabled)
                _logger.Info(message);
        }
        public void Info(string errorMessage, Exception ex)
        {
            if (_logger.IsFatalEnabled)
                _logger.Info(errorMessage, ex);
        }

        public void Debug(string message)
        {
            if (_logger.IsDebugEnabled)
                _logger.Debug(message);
        }
        public void Debug(string errorMessage, Exception ex)
        {
            if (_logger.IsFatalEnabled)
                _logger.Debug(errorMessage, ex);
        }
    }
}
