using System.Web;
using System.Web.Optimization;

namespace Presentacion_Admin
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/bundles/jquery").Include(//-->SrciptBundle pasa a ser Bundle
                        "~/Scripts/jquery-{version}.js"));

            //-->Cada vez que agrego un nuevo paqute nugguet, lo debo de agregar aca:
            bundles.Add(new Bundle("~/bundles/complementos").Include(//-->Agrego los complementos
                        "~/Scripts/scripts.js",
                        "~/Scripts/fontawesome/all.min.js",
                        "~/Scripts/DataTables/jquery.dataTables.js",
                        "~/Scripts/DataTables/dataTables.responsive.js",
                        "~/Scripts/loadingoverlay/loadingoverlay.min.js",
                        "~/Scripts/sweetalert.min.js",
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery-ui.js"
                        ));//-->fontawesome me permite agregar que pueda ver los iconos, paquete nuget installado 

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.bundle.js"));//-->Agregue bootstrap.bundle.js

            //-->Cada vez que agrego un nuevo paqute nugguet, lo debo de agregar aca:
            bundles.Add(new StyleBundle("~/Content/css").Include( 
                      "~/Content/site.css",
                      "~/Content/DataTables/css/jquery.dataTables.css",
                      "~/Content/DataTables/css/responsive.dataTables.css",
                      "~/Content/sweetalert.css",
                      "~/Content/jquery-ui.css"
                      ));//-->Elimine "~/Content/bootstrap.css"
        }
    }
}
