using System;
using System.Collections.Generic;
using System.Text;

namespace NotEdible.exceptions
{
    public class TextureException : Exception
    {
        public TextureException()
        {

        }

        public TextureException(string message)
            : base(message)
        {
        }


    }
}
