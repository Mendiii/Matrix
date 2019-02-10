using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatrixProj.Models
{
    //complex model
    public class ModelHeader
    {
        public int total_count { get; set; }
        public bool incomplete_results { get; set; }
        public List<ItemModel> items { get; set; }
    }

    public class ItemModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public OwnerModel owner { get; set; }
        public string html_url { get; set; }
        
    }

    public class OwnerModel
    {
        public string avatar_url { get; set; }
    }
}