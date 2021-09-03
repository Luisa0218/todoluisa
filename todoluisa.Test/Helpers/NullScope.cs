using System;

namespace todoluisa.Test.Helpers
{
    internal class NullScope : IDisposable
    {
        public static NullScope Instance { get; } = new NullScope();

        public void Dispose() { }

        private NullScope() { }




    }
}
