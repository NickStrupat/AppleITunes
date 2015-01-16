using System;
using System.Collections.Generic;

namespace AppleITunes {
    public static class EnumHelper {
        public static IEnumerable<T> GetValues<T>() where T : struct {
            return (T[]) Enum.GetValues(typeof (T));
        }
    }
}
