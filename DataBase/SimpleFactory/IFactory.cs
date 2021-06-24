using System;

namespace ClassLibraryEngSoft.Factory
{
    public interface IFactory
    {
        object Create(string type);

    }
}