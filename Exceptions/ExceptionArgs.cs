using System;

namespace Exceptions
{
    [Serializable]
    public abstract class ExceptionArgs
    {
        public virtual string Message { get { return string.Empty; } }
    }
}
