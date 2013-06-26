using System.Web;
using System.Web.Optimization;

public class BundleConfig
{
    public static void RegisterBundles(BundleCollection bundles)
    {
        bundles.Add(new StyleBundle("~/CSS").Include(
            "~/Content/styles.less"));


        bundles.Add(new ScriptBundle("~/Scripts/less").Include(
            "~/Content/less.js"));
    }
}