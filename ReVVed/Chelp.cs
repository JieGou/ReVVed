using Autodesk.Revit.UI;

namespace RVVD
{
  /// <summary>
  /// 上下文帮助类<para/>
  /// Contextual help is only supported in Revit 2013 and up
  /// </summary>
  internal class Chelp
  {
    internal static ContextualHelp coco_help;
    internal static ContextualHelp of_help;
    internal static ContextualHelp pc_help;
    internal static ContextualHelp mt_help;
    internal static ContextualHelp pl_help;
    internal static ContextualHelp wl_help;
    internal static ContextualHelp cc_help;
    internal static ContextualHelp gf_help;
    internal static ContextualHelp rev_help;
    internal static ContextualHelp opt_help;
    internal static ContextualHelp help_help; //opens to default page

    /// <summary>
    /// 初始化帮助
    /// </summary>
    internal static void initializeHelp()
    {
      //Contents
      string HelpPath = System.IO.Directory.GetParent(Properties.Settings.Default.AddinPath).FullName;
      string helpFile = LocalizationProvider.GetLocalizedValue<string>("HELP_FILE");

      string helpFilePath = "file:///" + HelpPath + helpFile;
      coco_help = new ContextualHelp(ContextualHelpType.ChmFile, helpFilePath)
      {
        HelpTopicUrl = @"ComponentCommander.htm"
      };

      of_help = new ContextualHelp(ContextualHelpType.ChmFile, helpFilePath)
      {
        HelpTopicUrl = @"OpenFolder.htm"
      };

      pc_help = new ContextualHelp(ContextualHelpType.ChmFile, helpFilePath)
      {
        HelpTopicUrl = @"ProjectCommander.htm"
      };

      mt_help = new ContextualHelp(ContextualHelpType.ChmFile, helpFilePath)
      {
        HelpTopicUrl = @"MergeText.htm"
      };

      pl_help = new ContextualHelp(ContextualHelpType.ChmFile, helpFilePath)
      {
        HelpTopicUrl = @"Polyline.htm"
      };

      wl_help = new ContextualHelp(ContextualHelpType.ChmFile, helpFilePath)
      {
        HelpTopicUrl = @"WebLink.htm"
      };

      cc_help = new ContextualHelp(ContextualHelpType.ChmFile, helpFilePath)
      {
        HelpTopicUrl = @"ChangeCase.htm"
      };

      gf_help = new ContextualHelp(ContextualHelpType.ChmFile, helpFilePath)
      {
        HelpTopicUrl = @"GridFlip.htm"
      };

      rev_help = new ContextualHelp(ContextualHelpType.ChmFile, helpFilePath)
      {
        HelpTopicUrl = @"Revisionist.htm"
      };

      opt_help = new ContextualHelp(ContextualHelpType.ChmFile, helpFilePath)
      {
        HelpTopicUrl = @"Other.htm"
      };

      help_help = new ContextualHelp(ContextualHelpType.Url, helpFilePath)
      {
        HelpTopicUrl = @"Welcome.html"
      };
    }
  }
}