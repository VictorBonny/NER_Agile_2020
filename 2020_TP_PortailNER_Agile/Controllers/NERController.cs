using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace _2020_TP_PortailNER_Agile.Controllers
{
    public class NERController : Controller
    {
        public ActionResult BioGaZ()
        {
            return View();
        } 

        public ActionResult Eolien()
        {
            return View();
        }

        public ActionResult EolienChart()
        {

            //Eolien

            double day01 = 11475.625;
            double day02 = 16856;
            double day03 = 13905.125;
            double day04 = 11180;
            double day05 = 8347.375;
            double day06 = 9567.5;
            double day07 = 13029;
            double day08 = 6568.25;
            double day09 = 5165.375;
            double day10 = 3434.625;
            double day11 = 10363;
            double day12 = 193.5;
            double day13 = 1419;
            double day14 = 5482.5;
            double day15 = 5907.125;
            double day16 = 8325.875;
            double day17 = 13582.625;
            double day18 = 12265.75;
            double day19 = 12088.375;
            double day20 = 4703.125;
            double day21 = 9594.375;
            double day22 = 8325.875;
            double day23 = 2547.75;
            double day24 = 112.875;

            new Chart(width: 1000, height: 200)

            .AddSeries(
            chartType: "line",
                xValue: new[] { "01.10.2013", "02.10.2013", "03.10.2013", "04.10.2013", "05.10.2013", "06.10.2013", "07.10.2013", "08.10.2013", "09.10.2013", "10.10.2013", "11.10.2013", "1.10.2013", "13.10.2013", "14.10.2013", "15.10.2013", "16.10.2013", "17.10.2013", "18.10.2013", "19.10.2013", "20.10.2013", "21.10.2013", "22.10.2013", "23.10.2013", "24.10.2013" },
                yValues: new[] { day01, day02, day03, day04, day05, day06, day07, day08, day09, day10, day11, day12, day13, day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24 })
            .Write("png");

            return null;
        }

        public ActionResult MiniHydr()
        {
            return View();
        }


        public ActionResult PV()
        {
            return View();
        }
        public ActionResult PVChart()
        {

            //photovoltaïque
          
            double day01 = 21.35;
            double day02 = 31.36;
            double day03 = 25.87;
            double day04 = 20.8;
            double day05 = 15.53;
            double day06 = 17.8;
            double day07 = 24.24;
            double day08 = 12.22;
            double day09 = 9.61;
            double day10 = 6.39;
            double day11 = 19.28;
            double day12 = 0.36;
            double day13 = 2.64;
            double day14 = 10.2;
            double day15 = 10.99;
            double day16 = 15.49;
            double day17 = 25.27;
            double day18 = 22.82;
            double day19 = 22.49;
            double day20 = 8.75;
            double day21 = 17.85;
            double day22 = 15.49;
            double day23 = 4.74;
            double day24 = 0.21;

            new Chart(width: 1000, height: 200)

            .AddSeries(
            chartType: "line",
                xValue: new[] { "01.10.2013", "02.10.2013", "03.10.2013", "04.10.2013", "05.10.2013", "06.10.2013", "07.10.2013", "08.10.2013", "09.10.2013", "10.10.2013", "11.10.2013", "1.10.2013", "13.10.2013", "14.10.2013", "15.10.2013", "16.10.2013", "17.10.2013", "18.10.2013", "19.10.2013", "20.10.2013", "21.10.2013", "22.10.2013", "23.10.2013", "24.10.2013" } ,
                yValues: new[] { day01, day02, day03, day04, day05, day06, day07, day08, day09, day10, day11, day12, day13, day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24})
            .Write("png");

            return null;
        }
    }
}