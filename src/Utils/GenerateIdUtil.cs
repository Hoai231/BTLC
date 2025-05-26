using System;

namespace BTL_C_.src.Utils
{
  internal class GenerateIdUtil
  {
    public static string GenerateId(string key)
    {
      // Lấy thời gian hiện tại theo milliseconds kể từ 1970 (Unix timestamp)
      long timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds(); // VD: 1713795134421
      string timePart = timestamp.ToString();

      // Lấy phần cuối để đủ độ dài 10 ký tự (bao gồm key)
      int digitsToTake = 10 - key.Length;
      string lastDigits = timePart.Substring(timePart.Length - digitsToTake);

      return key + lastDigits;
    }
  }
}
