using System;


namespace F10Y.L0005.L004
{
    public class HandlerSuites : IHandlerSuites
    {
        #region Infrastructure

        public static IHandlerSuites Instance { get; } = new HandlerSuites();


        private HandlerSuites()
        {
        }

        #endregion
    }
}
