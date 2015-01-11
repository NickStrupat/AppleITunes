using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleITunes {
    public static class EnumHelper {
        public static IEnumerable<T> GetValues<T>() where T : struct {
            return (T[]) Enum.GetValues(typeof (T));
        }
    }
}
