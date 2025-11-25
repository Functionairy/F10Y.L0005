using System;


namespace F10Y.L0005.L001
{
    public class LoggingOperator : ILoggingOperator
    {
        #region Infrastructure

        public static ILoggingOperator Instance { get; } = new LoggingOperator();


        private LoggingOperator()
        {
        }

        #endregion
    }
}
