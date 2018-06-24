using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gersof.Common.Logger
{
    public class HelperLogger
    {

        private static readonly Lazy<HelperLogger> Instance = new Lazy<HelperLogger>(() => new HelperLogger());
            
        private ILog log;
            
        private HelperLogger()
        {
            this.InitializerLogger();
        }

        public static HelperLogger Current
        {
            get
            {
                return Instance.Value;
            }
        }

        public void RegisterEventLogError(Exception exception, string applicationName, string machineName, string methodName)
        {
            MDC.Set("Application", applicationName);
            MDC.Set("Machine", machineName);
            MDC.Set("Method", methodName);
            this.log.Error(this.GetMessageLog(exception), exception);
        }

        public void RegisterEventLogInfo(string info)
        {
            this.log.Info(info);
        }

        public bool ValidateLogguerIsEnabledInfo()
        {
            return this.log.IsInfoEnabled;
        }
             
        private void InitializerLogger()
        {
            log4net.Config.XmlConfigurator.Configure();
            this.log = LogManager.GetLogger(this.GetType());
        }

        
        private string GetMessageLog(Exception exception)
        {
            StringBuilder builder = new StringBuilder();
            string stackTrace = string.Empty;

            builder.AppendLine();
            builder.Append("Hora: ").Append(DateTime.Now.ToString()).AppendLine();
            builder.Append("Tipo Excepción: ").Append(exception.GetType().ToString()).AppendLine();
            builder.Append("Excepción: ").Append(exception.Message).AppendLine();
            builder.Append("InnerException: ").Append(this.GetOriginalException(exception, out stackTrace).Message).AppendLine();
            builder.Append("StackTrace: ").AppendLine().AppendLine().Append(stackTrace).AppendLine();

            return builder.ToString();
        }
               
        private Exception GetOriginalException(Exception exception, out string stackTrace)
        {
            bool finalException = false;
            int posicionTrace = 0;
            StringBuilder resultStackTrace = new StringBuilder();
            stackTrace = string.Empty;

            while (!finalException)
            {
                if (exception.InnerException == null)
                {
                    resultStackTrace.Append("Posición de la traza: ").Append(posicionTrace).AppendLine();
                    resultStackTrace.Append("Ensamblado: ").Append(exception.Source).AppendLine();
                    resultStackTrace.Append("Metodo que retorna el error: ").Append(exception.TargetSite).AppendLine();
                    resultStackTrace.Append("Traza: ").Append(exception.StackTrace).AppendLine();
                    finalException = true;
                }
                else
                {
                    resultStackTrace.Append("Posición de la traza: ").Append(posicionTrace).AppendLine();
                    resultStackTrace.Append("Ensamblado: ").Append(exception.Source).AppendLine();
                    resultStackTrace.Append("Metodo que retorna el error: ").Append(exception.TargetSite).AppendLine();
                    resultStackTrace.Append("Traza: ").Append(exception.StackTrace).AppendLine();
                    exception = exception.InnerException;
                    posicionTrace++;
                }
            }

            stackTrace = resultStackTrace.ToString();
            return exception;
        }
    }
}
