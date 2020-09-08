using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace p_aladdin
{
    [Route("products")]
    [ApiController]
    public class _c_products : Controller
    {
        [HttpGet]
        [Route("test")]
        public string f_test_() 
        {
            return "Test: " + DateTime.Now.ToString();
        }

        [HttpPost]
        [Route("list")]
        public List<_c_product> f_text_()
        {
            List<_c_product> l_lst_ = new List<_c_product>();



            return l_lst_;
        }
    }
}