using System;
using System.Runtime.Serialization;

namespace BLL
{
    [Serializable]
    public class UsuarioouSenhaInvalidadoException : Exception
    {
        public UsuarioouSenhaInvalidadoException()
        {
        }

        public UsuarioouSenhaInvalidadoException(string message) : base(message)
        {
        }

        public UsuarioouSenhaInvalidadoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UsuarioouSenhaInvalidadoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}