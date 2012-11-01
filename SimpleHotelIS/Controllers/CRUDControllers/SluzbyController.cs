//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleHotelIS.Controllers.CRUDControllers
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Mvc;
    using SimpleHotelIS.Models;
    using SimpleHotelIS.DTO;
    using SimpleHotelIS.BusinessPipelines;
    
    public partial class SluzbyController  : Controller
    {
    
        	private ITaskBasedCrudServiceProvider<Sluzby, SluzbyDTO> icsp;
        
        	public SluzbyController
        		(
        			ITaskBasedCrudServiceProvider<Sluzby, SluzbyDTO> icsp
        		)
        	{
        		this.icsp = icsp;
        	}
    
            [HttpGet]
            public ActionResult Index()
            {
                return RedirectToActionPermanent("List");
            }
        
            [HttpGet]
            public ActionResult GetById(int id)
            {
                var result = icsp.CreateIGetByIdServiceTask().GetTask(id).Result;
                return View( "/Views/CRUDControllers/Sluzby/" +"Detail" +".cshtml", result);
            }
                
            [HttpGet]
            public ActionResult GetQueryable()
            {
                var querystring = this.Request.QueryString;
                var result = icsp.CreateIAsQueryableServiceTask().GetTask().Result;
                return View( "/Views/CRUDControllers/Sluzby/"+ "List"+ ".cshtml", result);
            }
    
            [HttpGet]
            public ActionResult Create()
            {
                return View( "/Views/CRUDControllers/Sluzby/"+ "Create"+ ".cshtml");
            }
    
            [HttpPost]
            public ActionResult Create(SluzbyDTO dto)
            {
    			try
    			{
    				var newent = icsp.CreateICreateServiceTask().GetTask(dto).Result;
    				return View("/Views/CRUDControllers/Sluzby/"+ "Detail"+ ".cshtml", newent);
    			} catch ( Exception e )
    			{
    				ViewBag.Original = dto;
    				ViewBag.Reasons = e;
    				return View("/Views/CRUDControllers/Sluzby/"+ "Create"+ ".cshtml");
    			}
            }
    
            [HttpGet]
            public ActionResult Update(int id)
            {
    			var result = icsp.CreateIGetByIdServiceTask().GetTask(id).Result;
                return View("/Views/CRUDControllers/Sluzby/"+ "Update"+ ".cshtml" , result);
            }
    
            [HttpPost]
            public ActionResult Update(SluzbyDTO dto)
            {
    			try
    			{
                    var updent = icsp.CreateIUpdateServiceTask().GetTask(dto).Result;
    				return View("/Views/CRUDControllers/Sluzby/"+ "Detail"+ ".cshtml", updent);
    			} catch ( Exception e )
    			{
    				ViewBag.Original = dto;
    				ViewBag.Reasons = e;
    				return View("/Views/CRUDControllers/Sluzby/"+ "Update"+ ".cshtml");
    			}
            }
    
            [HttpGet]
            public ActionResult Delete(int id)
            {
    			var result = icsp.CreateIGetByIdServiceTask().GetTask(id).Result;
    			ViewBag.ShowDeleteConfirmation = true;
                return View("/Views/CRUDControllers/Sluzby/"+ "Detail"+ ".cshtml", result);
            }
    
            [HttpPost]
            public ActionResult ConfirmDelete(int id)
            {
    			try
    			{
    				icsp.CreateIDeleteServiceTask().GetTask(id).RunSynchronously();
    				return View("/Views/CRUDControllers/Sluzby/"+ "List"+ ".cshtml");
    			} catch ( Exception e )
    			{
    				var result = icsp.CreateIGetByIdServiceTask().GetTask(id).Result;
    				ViewBag.Reasons = e;
    				return View( "/Views/CRUDControllers/Sluzby/"+ "Detail"+ ".cshtml", result);
    			}
            }
        
    }
}
