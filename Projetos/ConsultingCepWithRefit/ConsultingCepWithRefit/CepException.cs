using System;

namespace ConsultingCepWithRefit
{
    [Serializable]
    public class CepException : Exception
    {
        public CepException() { }
        public CepException(string message) : base(message) { }
        public CepException(string message, Exception inner) : base(message, inner) { }
        protected CepException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
