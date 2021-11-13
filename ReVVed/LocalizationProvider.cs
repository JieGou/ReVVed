using WPFLocalizeExtension.Extensions;

namespace RVVD
{
  /// <summary>
  /// 本地化(语言)提供者
  /// </summary>
  public static class LocalizationProvider
  {
    /// <summary>
    /// 获取本地语言值
    /// </summary>
    /// <typeparam name="T">类型</typeparam>
    /// <param name="key">关键词</param>
    /// <returns></returns>
    public static T GetLocalizedValue<T>(string key)
    {
      return LocExtension.GetLocalizedValue<T>("ReVVed:Language:" + key);
    }
  }
}