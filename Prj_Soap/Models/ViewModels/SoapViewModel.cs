﻿using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prj_Soap.Models.ViewModels
{
    public class SoapListViewModel
    {
        public string Id { get; set; }

        public string ItemName { get; set; }

        public int Price { get; set; }

        public string ImageUrl { get; set; }

    }

    public class SoapDetailViewModel
    {
        public Soap Soap { get; set; }
   
        public IPagedList<MessageListViewModel> Messages { get; set; }

    }

}