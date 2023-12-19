using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RDotNet;
using System.IO;
namespace DailyMonitoringCMC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public void Rexecution()
        {
            //RScriptRunner rr = new RScriptRunner();
            //string curDirectory = "D:\\VisualStudioCommunity\\DailyMonitoringCMC\\DailyMonitoringCMC\\App_Data";
            //string result = RScriptRunner.RunFromCmd(curDirectory + @"\testCSharp.R", "rscript.exe","");
            //@"C:\Program Files\R\R-3.2.3\bin\x64", @"C:\Program Files\R\R-3.2.3"
            //IMPORTANT: Engine.evaluate("source('\\\\\\\\something.x.y./somelocation/somefile.r');");

            REngine.SetEnvironmentVariables();
            // There are several options to initialize the engine, but by default the following suffice:
            REngine engine = REngine.GetInstance();
            //engine.Evaluate("require('ggplot2')");
            //engine.Evaluate("library('ggplot2')");
            //engine.Evaluate("print(plot.ts(c(1:100))");
            // engine.Evaluate("setwd('D:/Thesis R')");
            //List<int> ans = new List<int>();
            engine.Initialize();
            NumericVector ans=engine.Evaluate("c(1:100)").AsNumeric();
            // engine.Evaluate("png(filename='D:/Plots123/testRCSharp/plottest123.bmp')");
            //  engine.Evaluate("plot(c(1:100));filename = paste('D:/Plots123/testRCSharp/plot12345.jpg',sep='');dev.copy(jpeg,filename=filename);dev.off()");
            // engine.Evaluate("plot(c(1:100))");
            // engine.Evaluate("filename = paste('D:/Plots123/testRCSharp/plot12345.jpg',sep='')");
            //engine.Evaluate("dev.copy(jpeg,filename=filename)");
          //  engine.Evaluate("library('stats')");
            engine.Evaluate("source('D:/Thesis R/testCSharp.r')");

            // .NET Framework array to R vector.
            //NumericVector group1 = engine.CreateNumericVector(new double[] { 30.02, 29.99, 30.11, 29.97, 30.01, 29.99 });
            //engine.SetSymbol("group1", group1);
            //// Direct parsing from R script.
            //NumericVector group2 = engine.Evaluate("group2 <- c(29.89, 29.93, 29.72, 29.98, 30.02, 29.98)").AsNumeric();

            //// Test difference of mean and get the P-value.
            //GenericVector testResult = engine.Evaluate("t.test(group1, group2)").AsList();
            //double p = testResult["p.value"].AsNumeric().First();

            //Console.WriteLine("Group1: [{0}]", string.Join(", ", group1));
            //Console.WriteLine("Group2: [{0}]", string.Join(", ", group2));
            // Console.WriteLine("P-value = {0:0.000}", p);

            // you should always dispose of the REngine properly.
            // After disposing of the engine, you cannot reinitialize nor reuse it
            //engine.Dispose();
        }
    }
}