﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prj_Soap.Models.ViewModels
{
    public class NewMessagesViewModel
    {
        [Required]
        public string P_Id { get; set; }

        [StringLength(200)]
        public string Content { get; set; }

    }

    public class MessageListViewModel
    {
        public string C_Name { get; set; }

        [StringLength(200)]
        public string Content { get; set; }

        [StringLength(200)]
        public string ReplyContent { get; set; }

        public DateTime AddTime { get; set; }

        public string FormattedAddDate => AddTime.ToString("yyyy/MM/dd HH:mm");


    }
}