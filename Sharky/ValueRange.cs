using System.Reflection;

namespace Sharky.Helper
{
    public readonly struct ValueRange
    {
        public int Min { get; }

        public int Max { get; }

        public string Key { get; }

        public ValueRange(int min, int max, string key)
        {
            Key = key;
            Min = min;
            Max = max;
        }

        private ValueRange(int min, int max)
        {
            Key = Guid.NewGuid().ToString();
            Min = min;
            Max = max;
        }

        public static implicit operator ValueRange(int x) => new(x, x);

        public static implicit operator int(ValueRange v) => ValueCallbackService.GetValue(v);

        public static bool operator <(ValueRange v, int b) => ValueCallbackService.GetValue(v) < b;

        public static bool operator >(ValueRange v, int b) => ValueCallbackService.GetValue(v) > b;

        public static bool operator <=(ValueRange v, int b) => ValueCallbackService.GetValue(v) <= b;

        public static bool operator >=(ValueRange v, int b) => ValueCallbackService.GetValue(v) >= b;

        public static ValueRange operator ++(ValueRange v) => new(v.Min + 1, v.Max + 1, v.Key);

        public static ValueRange operator --(ValueRange v) => new(v.Min - 1, v.Max - 1, v.Key);
    }
}
