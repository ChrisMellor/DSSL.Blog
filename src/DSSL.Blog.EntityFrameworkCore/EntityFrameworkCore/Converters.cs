using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;

namespace DSSL.Blog.EntityFrameworkCore
{
    public static class Converters
    {
        public static ValueConverter<ICollection<string>, string> Collection()
        {
            return new ValueConverter<ICollection<string>, string>(
                x => string.Join(";", x),
                x => x.Split(';', StringSplitOptions.RemoveEmptyEntries));
        }
    }
}