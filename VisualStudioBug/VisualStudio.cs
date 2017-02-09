namespace VisualStudioBug
{
  /// <summary>
  /// Microsoft Visual Studio Enterprise 2017 RC
  /// Version 15.0.26206.0 D15REL
  /// </summary>
  public class VisualStudio
  {
    /*
     * Steps to reproduce:
     * 
     * - Compile project
     * - Select 'VisualStudioBug(net45)' in dropdown
     * - Change Bug to IBug and keep the cursor there
     * - Quick Actions => Generate type 'IBug' => Generate interface 'IBug' in new file
     * - Press F12 (Go To Definition)
     * 
     *  This results in 'Object reference not set to an instance of an object.'
     */
    public void CreateBug(Bug bug)
    {
    }
  }
}
