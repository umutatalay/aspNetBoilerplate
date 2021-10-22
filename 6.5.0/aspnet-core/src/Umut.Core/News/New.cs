using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umut.News
{
    public class New : Entity<long>
    {
        //??// public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public string CreateDate { get; set; }
        public string ModifyDate { get; set; }
        public long? CreateUserId { get; set; }
        public long? ModifyUserId { get; set; }
        public string InNewImage { get; set; }
        public string InNewContentHtml { get; set; }
        public string InNewContentQuill { get; set; }
    }
}
