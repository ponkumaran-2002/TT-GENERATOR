using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using System.Drawing.Printing;
using TTGenerator.Data;
using TTGenerator.Models;
using TTGenerator.Models.Domain;
using System.Reflection.Emit;
using NuGet.Protocol;
using Microsoft.AspNetCore.Http;


namespace TTGenerator.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        /*     public HomeController(ILogger<HomeController> logger)
             {
                 _logger = logger;
             }*/
        //MVCDemoDbContext
        private readonly MVCDemoDbContext mvcDemoDbContext;
        public HomeController(MVCDemoDbContext mvcDemoDbContext)
        {
            this.mvcDemoDbContext = mvcDemoDbContext;
        }
        public IActionResult Clgtt_coordinator_home()
        {
            return View();
        }
       
        public IActionResult Index1()
        {   
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index1(Index1 index)
        {
            Console.WriteLine("index.semester_id");
            Console.WriteLine(index.semester_id);
            Console.WriteLine(index.m10);
            Console.WriteLine(index.m1);
        //    var c =  mvcDemoDbContext.clg_tt_level.Count();
        
            
            for (int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if ((i == 0)&&(j==0))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg=new clg_tt_level { sno=c+1,
                                                           semester_id= index.semester_id ,
                                                           batch_start_year=index.batch_start_year,
                                                           year_s = index.year_s,
                                                           slot = 1,
                                                           day_tt="monday",
                                                           elective_id=index.m1
                                                            };
                         mvcDemoDbContext.clg_tt_level.Add(clg);
                         mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 1))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 2,
                            day_tt = "monday",
                            elective_id = index.m2
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 2))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 3,
                            day_tt = "monday",
                            elective_id = index.m3
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 3))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 4,
                            day_tt = "monday",
                            elective_id = index.m4
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 4))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 5,
                            day_tt = "monday",
                            elective_id = index.m5
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 5))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 6,
                            day_tt = "monday",
                            elective_id = index.m6
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 6))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 7,
                            day_tt = "monday",
                            elective_id = index.m7
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 7))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno= c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 8,
                            day_tt = "monday",
                            elective_id = index.m8
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 8))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno= c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 9,
                            day_tt = "monday",
                            elective_id = index.m9
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 0) && (j == 9))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 10,
                            day_tt = "monday",
                            elective_id = index.m10
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 0))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 1,
                            day_tt = "tuesday",
                            elective_id = index.t1
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 1))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 2,
                            day_tt = "tuesday",
                            elective_id = index.t2
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 2))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno= c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 3,
                            day_tt = "tuesday",
                            elective_id = index.t3
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 3))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {  sno= c+1,    
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 4,
                            day_tt = "tuesday",
                            elective_id = index.t4
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 4))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno= c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 5,
                            day_tt = "tuesday",
                            elective_id = index.t5
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 5))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {  sno= c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 6,
                            day_tt = "tuesday",
                            elective_id = index.t6
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 6))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {    sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 7,
                            day_tt = "tuesday",
                            elective_id = index.t7
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 7))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {    sno=c+1,   
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 8,
                            day_tt = "tuesday",
                            elective_id = index.t8
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 8))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,    
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 9,
                            day_tt = "tuesday",
                            elective_id = index.t9
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 1) && (j == 9))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno = c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 10,
                            day_tt = "tuesday",
                            elective_id = index.t10
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 0))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {    sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 1,
                            day_tt = "wednesday",
                            elective_id = index.w1
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 1))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        { sno = c + 1,  
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 2,
                            day_tt = "wednesday",
                            elective_id = index.w2
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 2))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno =c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 3,
                            day_tt = "wednesday",
                            elective_id = index.w3
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 3))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 4,
                            day_tt = "wednesday",
                            elective_id = index.w4
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 4))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 5,
                            day_tt = "wednesday",
                            elective_id = index.w5
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 5))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 6,
                            day_tt = "wednesday",
                            elective_id = index.w6
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 6))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno = c+1,  
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 7,
                            day_tt = "wednesday",
                            elective_id = index.w7
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 7))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno= c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 8,
                            day_tt = "wednesday",
                            elective_id = index.w8
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 8))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 9,
                            day_tt = "wednesday",
                            elective_id = index.w9
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 2) && (j == 9))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 10,
                            day_tt = "wednesday",
                            elective_id = index.w10
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 0))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        { sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 1,
                            day_tt = "thursday",
                            elective_id = index.th1
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 1))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno = c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 2,
                            day_tt = "thursday",
                            elective_id = index.th2
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 2))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno= c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 3,
                            day_tt = "thursday",
                            elective_id = index.th3
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 3))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {    sno= c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 4,
                            day_tt = "thursday",
                            elective_id = index.th4
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 4))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno= c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 5,
                            day_tt = "thursday",
                            elective_id = index.th5
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 5))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 6,
                            day_tt = "thursday",
                            elective_id = index.th6
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 6))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 7,
                            day_tt = "thursday",
                            elective_id = index.th7
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 7))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno= c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 8,
                            day_tt = "thursday",
                            elective_id = index.th8
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 8))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno= c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 9,
                            day_tt = "thursday",
                            elective_id = index.th9
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 3) && (j == 9))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {  sno= c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 10,
                            day_tt = "thursday",
                            elective_id = index.th10
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 0))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno = c + 1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 1,
                            day_tt = "friday",
                            elective_id = index.f1
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 1))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        { sno  = c + 1, 
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 2,
                            day_tt = "friday",
                            elective_id = index.f2
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 2))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno = c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 3,
                            day_tt = "friday",
                            elective_id = index.f3
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 3))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {  sno= c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 4,
                            day_tt = "friday",
                            elective_id = index.f4
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 4))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno= c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 5,
                            day_tt = "friday",
                            elective_id = index.f5
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 5))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 6,
                            day_tt = "friday",
                            elective_id = index.f6
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 6))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 7,
                            day_tt = "friday",
                            elective_id = index.f7
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 7))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 8,
                            day_tt = "friday",
                            elective_id = index.f8
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 8))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 9,
                            day_tt = "friday",
                            elective_id = index.f9
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 4) && (j == 9))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 10,
                            day_tt = "friday",
                            elective_id = index.f10
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 0))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 1,
                            day_tt = "saturday",
                            elective_id = index.s1
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 1))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 2,
                            day_tt = "saturday",
                            elective_id = index.s2
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 2))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 3,
                            day_tt = "saturday",
                            elective_id = index.s3
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 3))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 4,
                            day_tt = "saturday",
                            elective_id = index.s4
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 4))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {    sno=c+1,   
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 5,
                            day_tt = "saturday",
                            elective_id = index.s5
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 5))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 6,
                            day_tt = "saturday",
                            elective_id = index.s6
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else if ((i == 5) && (j == 6))
                    {
                        int c = mvcDemoDbContext.clg_tt_level.Count();
                        Console.WriteLine(c);
                        clg_tt_level clg = new clg_tt_level
                        {   sno=c+1,
                            semester_id = index.semester_id,
                            batch_start_year = index.batch_start_year,
                            year_s = index.year_s,
                            slot = 7,
                            day_tt = "saturday",
                            elective_id = index.s7
                        };
                        mvcDemoDbContext.clg_tt_level.Add(clg);
                        mvcDemoDbContext.SaveChanges();

                    }
                    else
                    {
                        break;
                    }
                    
                }
            }
            return View();

        }
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login loginrequest)
        {    Console.WriteLine("loginrequest.login_id");
             Console.WriteLine(loginrequest.login_id);
             var li = loginrequest.login_id.ToString();
             Console.WriteLine(loginrequest.login_id.GetType());
             Console.WriteLine(li.GetType());
             var login = await mvcDemoDbContext.Login_credentials.FindAsync(li);

           
            // Console.WriteLine("login.login_id" + login.login_id);
         /*   String connetionString;
            SqlDataReader datareader;
            String sql, outputl,outputp = null;
            SqlConnection cnn;
           
            connetionString = " Data Source =.\\sqlexpress; Initial Catalog = ttgenerator; Integrated Security = True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd;
            sql = "select * from login_credentials where login_id ='" + loginrequest.login_id +"';";
            Console.WriteLine(sql);
            cmd = new SqlCommand(sql, cnn);
            datareader = cmd.ExecuteReader();
            Console.WriteLine(datareader.ToString());
            //outputl = datareader("login_id").ToString();
            //Console.WriteLine('Datareader'+datareader);
                outputl = (String)datareader.GetValue(0);
                outputp = (String)datareader.GetValue(1);*/

            if (login != null)
            {
                
                if((login.password_l==loginrequest.password_l)&&(login.roleid==104))
                {
                    Console.WriteLine(login);
                    Console.WriteLine(login.password_l);
                    Console.WriteLine(login.roleid);
                    Console.WriteLine(login.faculty_id);
                    // return RedirectToAction("Index1");
                    return RedirectToAction("Clgtt_coordinator_home");
                }
            }
            return RedirectToAction("Error");

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}