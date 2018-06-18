using System.Web;
using System.Web.Optimization;

namespace Intranet
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/waves.css",
                      "~/Content/animate.css",
                      "~/Content/multi-select.css",
                      "~/Content/sweetalert.css",
                      "~/Content/bootstrap-material-datetimepicker.css",
                      "~/Content/waitMe.css",
                      "~/Content/bootstrap-select.css",
                      "~/Content/dataTables.bootstrap.css",
                      "~/Content/morris.css",
                      "~/Content/style.css",
                      "~/Content/all-themes.css"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
               "~/Scripts/angular.js",
               "~/AngularJSAPP/Produto/Module.js",
               "~/AngularJSAPP/Produto/Service.js",
               "~/AngularJSAPP/Produto/Controller.js"
               ));

            bundles.Add(new ScriptBundle("~/bundles/bsbAdmin").Include(
              "~/Scripts/bootstrap-select.js",
              "~/Scripts/jquery.slimscroll.js",
              "~/Scripts/jquery.multi-select.js",
              "~/Scripts/waves.js",
              "~/Scripts/sweetalert.min.js",
              "~/Scripts/jquery.dataTables.js",
              "~/Scripts/dataTables.bootstrap.js",
              "~/Scripts/dataTables.buttons.min.js",
              "~/Scripts/buttons.flash.min.js",
              "~/Scripts/jszip.min.js",
              "~/Scripts/pdfmake.min.js",
              "~/Scripts/vfs_fonts.js",
              "~/Scripts/buttons.html5.min.js",
              "~/Scripts/buttons.print.min.js",
              "~/Scripts/autosize.js",
              "~/Scripts/moment.js",
              "~/Scripts/bootstrap-material-datetimepicker.js",
              "~/Scripts/jquery.countTo.js",
              "~/Scripts/raphael.min.js",
              "~/Scripts/morris.js",
              "~/Scripts/Chart.bundle.js",
              "~/Scripts/jquery.flot.js",
              "~/Scripts/jquery.flot.resize.js",
              "~/Scripts/jquery.flot.pie.js",
              "~/Scripts/jquery.flot.categories.js",
              "~/Scripts/jquery.flot.time.js",
              "~/Scripts/query.sparkline.js",
              "~/Scripts/admin.js",
              "~/Scripts/index.js",
              "~/Scripts/basic-form-elements.js",
              "~/Scripts/advanced-form-elements.js",
              "~/Scripts/jquery-datatable.js",
              "~/Scripts/demo.js",
              "~/Scripts/bootstrap-notify.js",
              "~/Scripts/FuncoesCriadas.js",
              "~/Scripts/jquery.flot.js",
              "~/Scripts/jquery.flot.js",
              "~/Scripts/jquery.flot.js"
              ));
        }
    }
}
